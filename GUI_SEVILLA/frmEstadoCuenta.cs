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
        DataTable dtDatosAlumno = new DataTable();

        public frmEstadoCuenta()
        {
            InitializeComponent();
        }

        private void frmEstadoCuenta_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            lblEncabezado.Text = "Estado de cuenta - Pago de pensiones y otros - año escolar " + VariablesGlobales.AnioEscolarLogueado + "-" + VariablesGlobales.AnioFaseEscolarLogueado;
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
            if (txtFiltro.Text.Trim()!="")
            {
                dtDatosAlumno = cn.TraerDataset("USP_ALUMNOSearchMatriculados", conectar.conexionbdSevilla, txtFiltro.Text.Trim(),VariablesGlobales.AnioEscolarLogueado,
                    VariablesGlobales.AnioFaseEscolarLogueado,rbMatriculaBaja.Checked ? false:true,rbOtrasDeudas.Checked).Tables[0];

                if (dtDatosAlumno.Rows.Count<=0)
                {
                    MessageBox.Show("El dni ingresado no existe o no tiene asignado una matrícula.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombres.Clear();
                    LlenarGrilla(0,0);
                    return;
                }
                txtNombres.Text = dtDatosAlumno.Rows[0][2].ToString();

                LlenarGrilla(Convert.ToInt32(dtDatosAlumno.Rows[0][0]),Convert.ToInt32(dtDatosAlumno.Rows[0][1]));

                foreach (DataGridViewRow item in dgvEstadoCuenta.Rows)
                {
                    item.Cells["MONTODEUDA"].Value = Convert.ToDecimal(item.Cells["IMPORTE"].Value) - Convert.ToDecimal(item.Cells["MONTOPAGADO"].Value);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nº de documento para la búsqueda.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFiltro.Focus();
            }          
        }

        private void LlenarGrilla(int IdMatricula,int idAlumno)
        {
            if (!rbOtrasDeudas.Checked)
            {
                this.dgvEstadoCuenta.DataSource = cn.TraerDataset("USP_MATRICULAAlumnoSearch", conectar.conexionbdSevilla,
                    idAlumno, rbPendiente.Checked ? "P" : (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" :
                    (rbAcuenta.Checked ? "E" : "T"))), VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, IdMatricula).Tables[0];
                this.dgvEstadoCuenta.Refresh();
            }
            else
            {
                this.dgvEstadoCuenta.DataSource = cn.TraerDataset("USP_OTRASDEUDASSelect", conectar.conexionbdSevilla,
                    idAlumno, rbPendiente.Checked ? "P" : (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" :
                    (rbAcuenta.Checked ? "E" : "T"))), VariablesGlobales.AnioEscolarLogueado, IdMatricula).Tables[0];
                this.dgvEstadoCuenta.Refresh();              
            }
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

        private void chkBaja_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //if (this.dgvEstadoCuenta.Rows.Count <= 0) return;
            //frmImpresion winImpre = new frmImpresion();
            //winImpre.TipoReporte = 1;
            //winImpre.MiTabla = cn.TraerDataset("USP_MATRICULAAlumnoSearch", conectar.conexionbdSevilla,
            //    Convert.ToInt32(dtDatosAlumno.Rows[0][1]), rbPendiente.Checked ? "P" : (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" :
            //    (rbAcuenta.Checked ? "E" : "T"))), VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, Convert.ToInt32(dtDatosAlumno.Rows[0][0])).Tables[0];
            //winImpre.ShowDialog();

            if (this.dgvEstadoCuenta.Rows.Count <= 0) return;
            frmImpresion winImpre = new frmImpresion();
            winImpre.TipoReporte = 1;

            if (!rbOtrasDeudas.Checked)
            {
                winImpre.MiTabla = cn.TraerDataset("USP_MATRICULAAlumnoSearch", conectar.conexionbdSevilla,
                 Convert.ToInt32(dtDatosAlumno.Rows[0][1]), rbPendiente.Checked ? "P" : (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" :
                 (rbAcuenta.Checked ? "E" : "T"))), VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, Convert.ToInt32(dtDatosAlumno.Rows[0][0])).Tables[0];
                winImpre.ShowDialog();
            }
            else
            {
                winImpre.MiTabla = cn.TraerDataset("USP_OTRASDEUDASSelect", conectar.conexionbdSevilla,
                Convert.ToInt32(dtDatosAlumno.Rows[0][1]), rbPendiente.Checked ? "P" : (rbCancelado.Checked ? "C" : (rbAnulado.Checked ? "A" :
                (rbAcuenta.Checked ? "E" : "T"))), VariablesGlobales.AnioEscolarLogueado, Convert.ToInt32(dtDatosAlumno.Rows[0][0])).Tables[0];
                winImpre.ShowDialog();
            }
        }

        private void btnImprimirTotal_Click(object sender, EventArgs e)
        {
            frmImpresion winImpre = new frmImpresion();
            winImpre.TipoReporte = 4;
            winImpre.MiTabla = cn.TraerDataset("USP_CUENTACORRIENTEDeudaTotalPorAlumno", conectar.conexionbdSevilla,
                VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            winImpre.ShowDialog();
        }

        private void rbMatriculaBaja_CheckedChanged(object sender, EventArgs e)
        {
            //btnBuscar_Click(sender, e);
        }

        private void rbOtrasDeudas_CheckedChanged(object sender, EventArgs e)
        {
            //btnBuscar_Click(sender, e);
        }

        private void rbMatriculaActiva_CheckedChanged(object sender, EventArgs e)
        {
            //btnBuscar_Click(sender, e);
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
