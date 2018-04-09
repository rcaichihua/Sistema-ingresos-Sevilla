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
    public partial class frmEstadoCuenta : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        public frmEstadoCuenta()
        {
            InitializeComponent();
        }

        private void frmEstadoCuenta_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            lblEncabezado.Text = "Estado de cuenta - Pago de pensiones - año escolar " + VariablesGlobales.AnioEscolarLogueado + "-" + VariablesGlobales.AnioFaseEscolarLogueado;
        }

        private void AnularAutocompletadoColumnas()
        {
            this.dgvEstadoCuenta.AutoGenerateColumns = false;
            this.dgvEstadoCuenta.AutoGenerateColumns = false;
            this.dgvEstadoCuenta.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtDatosAlumno = new DataTable();

            if (txtFiltro.Text.Trim()!="")
            {
                dtDatosAlumno = cn.TraerDataset("USP_ALUMNOSearch", conectar.conexionbdSevilla, txtFiltro.Text.Trim(),VariablesGlobales.AnioEscolarLogueado,
                    VariablesGlobales.AnioFaseEscolarLogueado,chkBaja.Checked ? false:true).Tables[0];

                if (dtDatosAlumno.Rows.Count<=0)
                {
                    MessageBox.Show("El dni ingresado no existe o no tiene asignado una matrícula.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombres.Clear();
                    LlenarGrilla(0);
                    return;
                }
                txtNombres.Text = dtDatosAlumno.Rows[0][1].ToString();

                LlenarGrilla(Convert.ToInt32(dtDatosAlumno.Rows[0][0]));
            }
            else
            {
                MessageBox.Show("Ingrese el DNI para la búsqueda.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFiltro.Focus();
            }          
        }

        private void LlenarGrilla(int idAlumno)
        {
            this.dgvEstadoCuenta.DataSource = cn.TraerDataset("USP_MATRICULAAlumnoSearch", conectar.conexionbdSevilla, 
                idAlumno,rbPendiente.Checked ? "P": (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" : 
                (rbAcuenta.Checked ? "E" : "T"))),VariablesGlobales.AnioEscolarLogueado,VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            this.dgvEstadoCuenta.Refresh();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void rbPendiente_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void rbAnulado_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void rbAcuenta_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }
    }
}
