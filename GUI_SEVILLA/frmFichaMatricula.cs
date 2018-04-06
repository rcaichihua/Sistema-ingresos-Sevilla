using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmFichaMatricula : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public string TipoMantenimiento { get; set; }
        public int IdMatricula { get; set; }

        public frmFichaMatricula()
        {
            InitializeComponent();
        }

        private void frmFichaMatricula_Load(object sender, EventArgs e)
        {
            cboSituacion.DataSource = cn.EjecutarSqlDTS("select IDSITUACION,DESCRIPCION from SITUACION", conectar.conexionbdSevilla).Tables[0];
            cboSituacion.DisplayMember = "DESCRIPCION";
            cboSituacion.ValueMember = "IDSITUACION";

            lblEncabezado.Text = "Ficha de Matrícula - Año escolar " + VariablesGlobales.AnioEscolarLogueado + "-" + VariablesGlobales.AnioFaseEscolarLogueado;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno winfrmBuscarAlumno = new frmBuscarAlumno();
            winfrmBuscarAlumno.TipoModalidad = "M"; //Abrir para matricula
            winfrmBuscarAlumno.ShowDialog();
            if (winfrmBuscarAlumno.idAlumno_ != 0)
            {
                lblIdAlumno.Text = winfrmBuscarAlumno.idAlumno_.ToString();
                txtNombres.Text = winfrmBuscarAlumno.nombreAlumno_.ToString();
                txtDni.Text = winfrmBuscarAlumno.dni_.ToString();
                txtSeguro.Text = winfrmBuscarAlumno.seguro_.ToString();
                dtpFechaNacimiento.Value = winfrmBuscarAlumno.fechaNac_;
                txtEdad.Text = winfrmBuscarAlumno.edad_.ToString();
                txtUbigeoDireccion.Text = winfrmBuscarAlumno.ubigeoDirec_;
                txtDIreccion.Text = winfrmBuscarAlumno.direccion_;
                txtUbigeoLugarNacim.Text = winfrmBuscarAlumno.ubigeoLugNac_;
                txtObservacionesAlumno.Text = winfrmBuscarAlumno.observacionesAlum_;
                cboSituacion.Focus();
            }
        }

        private void btnAsignarSeccion_Click(object sender, EventArgs e)
        {
            frmBuscaSeccion winfrmBuscaSeccion = new frmBuscaSeccion();
            winfrmBuscaSeccion.ShowDialog();
            if (winfrmBuscaSeccion.IdSeccion_ != 0)
            {
                lblIdSeccion.Text = winfrmBuscaSeccion.IdSeccion_.ToString();
                txtGrado.Text = winfrmBuscaSeccion.Grado_;
                txtNivel.Text = winfrmBuscaSeccion.Nivel_;
                txtSeccion.Text = winfrmBuscaSeccion.Seccion_;
                txtTurno.Text = winfrmBuscaSeccion.Turno_;
                txtVacantes.Text = cn.TraerDataset("USP_MATRICULAVerificaVacantes", conectar.conexionbdSevilla, winfrmBuscaSeccion.IdSeccion_).Tables[0].Rows[0][1].ToString();//winfrmBuscaSeccion.Nrovacantes_.ToString();
                txtAnioEscolar.Text = winfrmBuscaSeccion.Anio_.ToString();
                txtFase.Text = winfrmBuscaSeccion.Fase_;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string message = "Esta seguro de registrar la Matrícula?" + Environment.NewLine +
                Environment.NewLine +
                "ALUMNO : " + txtNombres.Text + Environment.NewLine + 
                "GRADO : " + txtGrado.Text + Environment.NewLine + 
                "NIVEL : " + txtNivel.Text + Environment.NewLine +
                "SECCION : " + txtSeccion.Text + Environment.NewLine +
                Environment.NewLine +
                "LA DEUDA SE GENERARA A PARTIR DEL MES DE " + MetodosGlobales.NombreMes(dtpFechaIngreso.Value.Month).ToUpper() + Environment.NewLine +
                Environment.NewLine +
                "Verifique bien la información antes de aceptar.";
            string caption = VariablesGlobales.NombreMensajes;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (Convert.ToInt32(lblIdAlumno.Text) * Convert.ToInt32(lblIdSeccion.Text) > 0)
                {
                    if (!VerificaVacantes())
                    {
                        MessageBox.Show("Ya no quedan vacantes libres.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (!VerificaAlumno()) //verifica si el alumno ya esta matriculado
                    {
                        MessageBox.Show("El alumno seleccionado ya se encuentra matriculado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (!ValidarInicioMes())
                    {
                        if (!Validar()) return;

                        if (cn.TraerDataset("USP_MATRICULARegistro", conectar.conexionbdSevilla, lblIdSeccion.Text, lblIdAlumno.Text,
                        cboSituacion.SelectedValue, dtpFechaIngreso.Value, txtObservacionesMatricula.Text, VariablesGlobales.NombreUsuario, VariablesGlobales.UserHostIp,
                        VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado).Tables[0].Rows[0][0].ToString() != "0")
                        {
                            MessageBox.Show("La matrícula fue registrada con exito.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de ingreso no puede ser menor al inicio del mes del año escolar aperturado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Falta seleccionar al alumno o sección, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }           
        }

        private bool VerificaVacantes()
        {
            return (Convert.ToInt32(cn.TraerDataset("USP_MATRICULAVerificaVacantes",conectar.conexionbdSevilla, lblIdSeccion.Text).Tables[0].Rows[0][1]) >= 0);
        }


        private bool VerificaAlumno()
        {
            return (cn.TraerDataset("USP_MATRICULAVerificaAlumno",conectar.conexionbdSevilla,VariablesGlobales.AnioEscolarLogueado,VariablesGlobales.AnioFaseEscolarLogueado,lblIdAlumno.Text).Tables[0].Rows[0][0].ToString()=="0");
        }

        private bool ValidarInicioMes()
        {
            int mes;
            int anio;
            DataTable dtFechaAperturaInicio = new DataTable();

            DateTime fechaInicioApertura; //inicio del mes y año de la apertura del año activo.

            dtFechaAperturaInicio = cn.EjecutarSqlDTS("SELECT DESDE,ANIO FROM APERTURAANIOESCOLAR A INNER JOIN ANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN FASE C ON A.IDFASE=C.IDFASE WHERE A.ESTADO=1 AND B.ANIO=" + VariablesGlobales.AnioEscolarLogueado + " AND C.DESCRIPCIONFASE='" + VariablesGlobales.AnioFaseEscolarLogueado + "'", conectar.conexionbdSevilla).Tables[0];

            mes = Convert.ToInt32(dtFechaAperturaInicio.Rows[0][0]);
            anio =Convert.ToInt32(dtFechaAperturaInicio.Rows[0][1]);

            fechaInicioApertura = new DateTime(anio, mes, 1);

            return (fechaInicioApertura>dtpFechaIngreso.Value);
        }

        private bool Validar()
        {
            bool rspta;

            if (cboSituacion.SelectedIndex > -1)
            {
                rspta = true;
            }
            else
            {
                MessageBox.Show("Seleccione la situación del alumno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSituacion.Focus();
                rspta = false;
            }
            return rspta;
        }
    }
}
