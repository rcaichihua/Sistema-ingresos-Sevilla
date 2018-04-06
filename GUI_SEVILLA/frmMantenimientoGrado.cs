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
    public partial class frmMantenimientoGrado : MetroFramework.Forms.MetroForm
    {
        public string TipoMantenimiento { get; set; }
        public int IdGrado { get; set; }

        CNegocio cn = new CNegocio();

        public frmMantenimientoGrado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtNombreGrado.Text = MetodosGlobales.QuitarCaracteres(txtNombreGrado.Text);
            txtObservaciones.Text = MetodosGlobales.QuitarCaracteres(txtObservaciones.Text);

            try
            {
                if (!Validar() == true) return;

                if (TipoMantenimiento == "I")
                {
                    if (ActualizaInsertaAlumno("USP_GRADOSInsert"))
                    {
                        MessageBox.Show("Grado Ingresado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TipoMantenimiento == "U")
                {
                    if (ActualizaInsertaAlumno("USP_GRADOSUpdate"))
                    {
                        MessageBox.Show("Grado actualizado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Boolean ActualizaInsertaAlumno(string procedimiento)
        {
            Boolean resultado;
            resultado = false;

            if (cn.EjecutarSP(procedimiento, conectar.conexionbdSevilla, txtNombreGrado.Text.Trim(), txtObservaciones.Text.Trim(), chkActivo.Checked,VariablesGlobales.AnioEscolarAperturado,
                      IdGrado) > 0)
            {
                resultado = true;
            }
            return resultado;
        }

        private bool Validar()
        {
            bool rspta;

            if (txtNombreGrado.Text.Trim() != "")
            {
                rspta = true;
            }
            else
            {
                MessageBox.Show("Ingrese la descripción del grado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreGrado.Focus();
                rspta = false;
            }
            return rspta;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientoGrado_Load(object sender, EventArgs e)
        {
            try
            {
                if (TipoMantenimiento == "U")
                {
                    DataTable dtDatosGrado = new DataTable();
                    dtDatosGrado = cn.EjecutarSqlDTS("select IDGRADO,DESCRIPCIONGRADO,OBSERVACIONES,ESTADO,IDANIO from GRADOS where IDGRADO=" + IdGrado + "", conectar.conexionbdSevilla).Tables[0];
                    lblIdAnio.Text = dtDatosGrado.Rows[0][4].ToString();
                    txtNombreGrado.Text = dtDatosGrado.Rows[0][1].ToString();
                    chkActivo.Checked = Convert.ToBoolean(dtDatosGrado.Rows[0][3]);
                    txtObservaciones.Text = dtDatosGrado.Rows[0][2].ToString();
                }
            }
            catch (Exception)
            {

            }
            
        }
    }
}
