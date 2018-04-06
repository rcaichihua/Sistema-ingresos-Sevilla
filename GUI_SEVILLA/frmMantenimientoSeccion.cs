using BL_SEVILLA;
using DAO_SEVILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    public partial class frmMantenimientoSeccion : MetroFramework.Forms.MetroForm
    {
        public string TipoMantenimiento { get; set; }
        public int IdSeccion { get; set; }
        DataTable dtDatosSeccion = new DataTable();

        CNegocio cn = new CNegocio();

        public frmMantenimientoSeccion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtNombreSeccion.Text = MetodosGlobales.QuitarCaracteres(txtNombreSeccion.Text);
            txtAnioEscolar.Text = MetodosGlobales.QuitarCaracteres(txtAnioEscolar.Text);
            txtCodigoAula.Text = MetodosGlobales.QuitarCaracteres(txtCodigoAula.Text);
            txtNumeroVacantes.Text = MetodosGlobales.QuitarCaracteres(txtNumeroVacantes.Text);
            txtFase.Text = MetodosGlobales.QuitarCaracteres(txtFase.Text);
            try
            {
                if (!Validar() == true) return;

                if (TipoMantenimiento == "I")
                {
                    if (!VerificaSeccion())
                    {
                        MessageBox.Show("El registro ya existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    if (ActualizaInsertaSeccion("USP_SECCIONInsert"))
                    {
                        MessageBox.Show("Sección Ingresado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TipoMantenimiento == "U")
                {
                    if (dtDatosSeccion.Rows[0][1].ToString() + dtDatosSeccion.Rows[0][2].ToString() + dtDatosSeccion.Rows[0][3].ToString() + dtDatosSeccion.Rows[0][4].ToString() + dtDatosSeccion.Rows[0][5].ToString() + dtDatosSeccion.Rows[0][8].ToString()
                        != (cboGrado.SelectedValue.ToString() + (cboNivel.Text == "PRIMARIA (P)" ? "P" : "S") + txtNombreSeccion.Text + (cboTurno.Text == "MAÑANA (M)" ? "M" : "T") + txtAnioEscolar.Text + txtFase.Text))
                    {
                        if (!VerificaSeccion())
                        {
                            MessageBox.Show("El registro ya existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            return;
                        }
                    }

                    if (ActualizaInsertaSeccion("USP_SECCIONUpdate"))
                    {
                        MessageBox.Show("Sección actualizado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean VerificaSeccion()
        {
            return (cn.TraerDataset("USP_SECCIONVerifica", conectar.conexionbdSevilla,cboGrado.SelectedValue, cboNivel.Text == "PRIMARIA (P)" ? "P" : "S",txtNombreSeccion.Text, cboTurno.Text == "MAÑANA (M)" ? "M" : "T",txtAnioEscolar.Text,txtFase.Text).Tables[0].Rows[0][0].ToString() == "0");
        }

        private Boolean ActualizaInsertaSeccion(string procedimiento)
        {
            Boolean resultado;
            resultado = false;

            if (cn.EjecutarSP(procedimiento, conectar.conexionbdSevilla, cboGrado.SelectedValue, cboNivel.Text== "PRIMARIA (P)" ? "P":"S", txtNombreSeccion.Text,cboTurno.Text== "MAÑANA (M)" ? "M":"T",txtAnioEscolar.Text,txtCodigoAula.Text,txtNumeroVacantes.Text,VariablesGlobales.AnioFaseEscolarLogueado, IdSeccion) > 0)
            {
                resultado = true;
            }
            return resultado;
        }

        private bool Validar()
        {
            bool resu;
            resu = false;

            if (cboNivel.SelectedIndex>-1)
            {
                if (txtNombreSeccion.Text.Trim()!=String.Empty)
                {
                    if (cboTurno.SelectedIndex>-1)
                    {
                        if (txtNumeroVacantes.Text!=string.Empty)
                        {
                            resu = true;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el número de vacantes.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNumeroVacantes.Focus();
                            resu = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el turno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboTurno.Focus();
                        resu = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre de sección.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreSeccion.Focus();
                    resu = false;
                }

            }
            else
            {
                MessageBox.Show("Seleccione el nivel educativo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboNivel.Focus();
                resu = false;
            }

            return resu;
        }

        private void frmMantenimientoSeccion_Load(object sender, EventArgs e)
        {
            LlenarGrados();
            txtAnioEscolar.Text = VariablesGlobales.AnioEscolarLogueado.ToString();

            try
            {
                if (TipoMantenimiento == "U")
                {
                    dtDatosSeccion = cn.EjecutarSqlDTS("select IDSECCION,IDGRADO,NIVEL,LETRASECCION,TURNO,B.ANIO,CODAULA,NUMEROVACANTES,C.DESCRIPCIONFASE from SECCION A INNER JOIN ANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN FASE C ON C.IDFASE=A.IDFASE where IDSECCION=" + IdSeccion + "", conectar.conexionbdSevilla).Tables[0];

                    lblIdSeccion.Text = dtDatosSeccion.Rows[0][0].ToString();
                    cboGrado.SelectedValue = dtDatosSeccion.Rows[0][1].ToString();

                    cboNivel.Text = dtDatosSeccion.Rows[0][2].ToString()=="P" ? "PRIMARIA (P)":"SECUNDARIA (S)";
                    txtNombreSeccion.Text = dtDatosSeccion.Rows[0][3].ToString();
                    cboTurno.Text = dtDatosSeccion.Rows[0][4].ToString() == "M" ? "MAÑANA (M)" : "TARDE (T)";
                    txtAnioEscolar.Text = dtDatosSeccion.Rows[0][5].ToString();
                    txtCodigoAula.Text = dtDatosSeccion.Rows[0][6].ToString();
                    txtNumeroVacantes.Text = dtDatosSeccion.Rows[0][7].ToString();
                    txtFase.Text = dtDatosSeccion.Rows[0][8].ToString();                  
                }
                else
                {
                    txtFase.Text = VariablesGlobales.AnioFaseEscolarLogueado;
                }
            }
            catch (Exception)
            {

            }
        }

        private void LlenarGrados()
        {
            cboGrado.DataSource = cn.EjecutarSqlDTS("SELECT A.IDGRADO,A.DESCRIPCIONGRADO FROM GRADOS A INNER JOIN APERTURAANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN FASE C ON B.IDFASE=C.IDFASE INNER JOIN ANIOESCOLAR D ON D.IDANIO=B.IDANIO WHERE D.ANIO="+VariablesGlobales.AnioEscolarLogueado+" AND C.DESCRIPCIONFASE='"+VariablesGlobales.AnioFaseEscolarLogueado+"' AND A.ESTADO=1",conectar.conexionbdSevilla).Tables[0];
            cboGrado.DisplayMember = "DESCRIPCIONGRADO";
            cboGrado.ValueMember = "IDGRADO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroVacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtCodigoAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
