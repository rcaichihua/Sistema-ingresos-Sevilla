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
    public partial class frmPagosListado : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        private DataTable dtDatosReporte;

        public frmPagosListado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvListadoRecibos.DataSource = CargarDatos();
            lblCantidadRegistros.Text = dgvListadoRecibos.Rows.Count.ToString();
            SumarTotales();
        }

        private DataTable CargarDatos()
        {
            return cn.TraerDataset("USP_RECIBOSelectAll", conectar.conexionbdSevilla,dtpDesde.Value,dtpHasta.Value, 
                (txtNroRecibo.Text.Trim()==""?null: txtNroRecibo.Text), txtNombres.Text.Trim(),
                rbActivos.Checked ? "A" : (rbAnulado.Checked ? "N":"T")).Tables[0];
        }

        private void SumarTotales()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow row in dgvListadoRecibos.Rows)
            {
                total = total + Convert.ToDecimal(row.Cells["IMPORTERECIBO"].Value);
            }

            lblTotalSoles.Text = String.Format("{0:0.00}", total);
        }

        private void frmPagosListado_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            btnBuscar_Click(sender, e);
        }
        private void AnularAutocompletadoColumnas()
        {
            this.dgvListadoRecibos.AutoGenerateColumns = false;
            this.dgvListadoRecibos.AutoGenerateColumns = false;
            this.dgvListadoRecibos.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListadoRecibos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }

        private void marcarGrilla()
        {
            if (dgvListadoRecibos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvListadoRecibos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Estado"].Value) == false)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnVerRecibo_Click(object sender, EventArgs e)
        {
            if (this.dgvListadoRecibos.Rows.Count <= 0) return;
            int index = dgvListadoRecibos.CurrentRow.Index;

            frmImpresion winImpre = new frmImpresion();
            winImpre.TipoReporte = 5;
            winImpre.MiTabla = cn.TraerDataset("USP_RECIBOSSelectOne", conectar.conexionbdSevilla,this.dgvListadoRecibos.Rows[index].Cells[0].Value).Tables[0];
            winImpre.ShowDialog();
        }

        private void btnAnularRecibo_Click(object sender, EventArgs e)
        {
            if (this.dgvListadoRecibos.Rows.Count <= 0) return;
            int index = dgvListadoRecibos.CurrentRow.Index;

            if (Convert.ToBoolean(dgvListadoRecibos.Rows[index].Cells["Estado"].Value) == false)
            {
                MessageBox.Show("El documento ya se encuentra ANULADO.", VariablesGlobales.NombreMensajes,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMotivoAnulacion winAnula = new frmMotivoAnulacion();
            winAnula.TipoDocu= dgvListadoRecibos.Rows[index].Cells["TIPO"].Value.ToString();
            winAnula.NroDocumento = dgvListadoRecibos.Rows[index].Cells["NUMERORECIBO"].Value.ToString();
            winAnula.Id_Comprobante_Anular= Convert.ToInt32(dgvListadoRecibos.Rows[index].Cells["IDRECIBO"].Value);
            winAnula.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void btnReporteLiquidacion_Click(object sender, EventArgs e)
        {

            dtDatosReporte = cn.TraerDataset("USP_RECIBOSelect_Liquidacion", conectar.conexionbdSevilla, 
                dtpDesde.Value.ToString("yyyyMMdd")
              , dtpHasta.Value.ToString("yyyyMMdd"), rbActivos.Checked ? "A" : (rbAnulado.Checked ? "N" : "T")).Tables[0];

            if (dtDatosReporte.Rows.Count > 0)
            {
                frmReporte win = new frmReporte();

                Reportes.rptReporteDiario rptReporteDiario = new Reportes.rptReporteDiario();

                rptReporteDiario.SetDataSource(dtDatosReporte);
                rptReporteDiario.SetParameterValue("@Desde", dtpDesde.Value.ToShortDateString());
                rptReporteDiario.SetParameterValue("@Hasta", dtpHasta.Value.ToShortDateString());


                win.crvReportes.ReportSource = rptReporteDiario;

                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnVouchers_Click(object sender, EventArgs e)
        {
            dtDatosReporte = cn.TraerDataset("USP_LISTA_VOUCHEERS_RECIBOS", conectar.conexionbdSevilla,
                dtpDesde.Value.ToString("yyyyMMdd")
              , dtpHasta.Value.ToString("yyyyMMdd"), rbActivos.Checked ? "A" : (rbAnulado.Checked ? "N" : "T"),
                txtNombres.Text.Trim()).Tables[0];

            if (dtDatosReporte.Rows.Count > 0)
            {
                frmReporte win = new frmReporte();

                Reportes.rptListaVouchers rptReporteDiario = new Reportes.rptListaVouchers();

                rptReporteDiario.SetDataSource(dtDatosReporte);
                rptReporteDiario.SetParameterValue("@Desde", dtpDesde.Value.ToShortDateString());
                rptReporteDiario.SetParameterValue("@Hasta", dtpHasta.Value.ToShortDateString());


                win.crvReportes.ReportSource = rptReporteDiario;

                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
