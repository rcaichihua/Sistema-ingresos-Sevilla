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
            if (TipoMantenimiento == "U")
            {
                DataTable dtAlumSecc = new DataTable();
                this.btnAsignarSeccion.Enabled = false;
                this.btnBuscar.Enabled = false;
                cboSituacion.Enabled = false;
                dtpFechaIngreso.Enabled = false;
                txtNombres.ReadOnly = true;

                dtAlumSecc = cn.TraerDataset("USP_MATRICULASearchAlumnoSeccion", conectar.conexionbdSevilla, IdMatricula).Tables[0];

                lblIdAlumno.Text = dtAlumSecc.Rows[0][0].ToString();
                lblIdSeccion.Text = dtAlumSecc.Rows[0][1].ToString();
                cboSituacion.SelectedValue = dtAlumSecc.Rows[0][2].ToString();
                txtObservacionesMatricula.Text = dtAlumSecc.Rows[0][3].ToString();
                dtpFechaIngreso.Value = Convert.ToDateTime(dtAlumSecc.Rows[0][4]);
                LlenaDatosAlumno();
                LlenaDatosSeccion();
                txtObservacionesMatricula.Focus();
            }
        }

        private void LlenaDatosAlumno()
        {
            DataTable dtAlumno = new DataTable();

            dtAlumno = cn.TraerDataset("USP_ALUMNO_MATRICULASearch", conectar.conexionbdSevilla, lblIdAlumno.Text).Tables[0];
            txtDni.Text = dtAlumno.Rows[0][1].ToString();
            txtNombres.Text = dtAlumno.Rows[0][2].ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dtAlumno.Rows[0][3]);
            txtEdad.Text = Convert.ToInt32(calcularEdad(dtpFechaNacimiento.Value.ToString("yyyyMMdd")).ToString()).ToString();
            txtUbigeoDireccion.Text = dtAlumno.Rows[0][4].ToString();
            txtDIreccion.Text = dtAlumno.Rows[0][5].ToString();
            txtUbigeoLugarNacim.Text = dtAlumno.Rows[0][6].ToString();
            txtSeguro.Text = dtAlumno.Rows[0][8].ToString();
            txtObservacionesAlumno.Text = dtAlumno.Rows[0][9].ToString();
        }

        private void LlenaDatosSeccion()
        {
            DataTable dtSeccion = new DataTable();

            dtSeccion = cn.TraerDataset("USP_SECCIONFiltroMatriculaForMatricula", conectar.conexionbdSevilla,
                lblIdSeccion.Text).Tables[0];
            txtGrado.Text = dtSeccion.Rows[0][1].ToString();
            txtNivel.Text = dtSeccion.Rows[0][2].ToString();
            txtSeccion.Text = dtSeccion.Rows[0][3].ToString();
            txtTurno.Text = dtSeccion.Rows[0][3].ToString();
            txtVacantes.Text = cn.TraerDataset("USP_MATRICULAVerificaVacantes", conectar.conexionbdSevilla,
                lblIdSeccion.Text).Tables[0].Rows[0][1].ToString();
            txtAnioEscolar.Text = dtSeccion.Rows[0][6].ToString();
            txtFase.Text = dtSeccion.Rows[0][7].ToString();
        }

        private decimal calcularEdad(string fecha)
        {
            return Math.Floor(Convert.ToDecimal((Convert.ToInt32(VariablesGlobales.FechaActual) - Convert.ToInt32(fecha)) / 10000));
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
            if (TipoMantenimiento == "I")
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
            else
            {
                string message2 = "Esta seguro de actualizar las observaciones de la Matrícula?";
                string caption2 = VariablesGlobales.NombreMensajes;
                MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                DialogResult result2;

                result2 = MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result2 == System.Windows.Forms.DialogResult.Yes)
                {
                    if (cn.EjecutarSP("USP_MATRICULAUpdateObservaciones", conectar.conexionbdSevilla, IdMatricula, txtObservacionesMatricula.Text,
                        VariablesGlobales.NombreUsuario, VariablesGlobales.UserHostIp) > 0)
                    {
                        MessageBox.Show("La matrícula se actualizo correctamente.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error en la actualización, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool VerificaVacantes()
        {
            return (Convert.ToInt32(cn.TraerDataset("USP_MATRICULAVerificaVacantes", conectar.conexionbdSevilla, lblIdSeccion.Text).Tables[0].Rows[0][1]) >= 0);
        }


        private bool VerificaAlumno()
        {
            return (cn.TraerDataset("USP_MATRICULAVerificaAlumno", conectar.conexionbdSevilla, VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, lblIdAlumno.Text).Tables[0].Rows[0][0].ToString() == "0");
        }

        private bool ValidarInicioMes()
        {
            int mes;
            int anio;
            DataTable dtFechaAperturaInicio = new DataTable();

            DateTime fechaInicioApertura; //inicio del mes y año de la apertura del año activo.

            dtFechaAperturaInicio = cn.EjecutarSqlDTS("SELECT DESDE,ANIO FROM APERTURAANIOESCOLAR A INNER JOIN ANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN FASE C ON A.IDFASE=C.IDFASE WHERE A.ESTADO=1 AND B.ANIO=" + VariablesGlobales.AnioEscolarLogueado + " AND C.DESCRIPCIONFASE='" + VariablesGlobales.AnioFaseEscolarLogueado + "'", conectar.conexionbdSevilla).Tables[0];

            mes = Convert.ToInt32(dtFechaAperturaInicio.Rows[0][0]);
            anio = Convert.ToInt32(dtFechaAperturaInicio.Rows[0][1]);

            fechaInicioApertura = new DateTime(anio, mes, 1);

            return (fechaInicioApertura > dtpFechaIngreso.Value);
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
