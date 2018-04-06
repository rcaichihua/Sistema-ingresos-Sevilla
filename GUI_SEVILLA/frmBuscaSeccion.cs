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
    public partial class frmBuscaSeccion : MetroFramework.Forms.MetroForm
    {
        public int IdSeccion_ { get; set; }
        public string Grado_ { get; set; }
        public string Nivel_ { get; set; }
        public string Seccion_ { get; set; }
        public string Turno_ { get; set; }
        public int Nrovacantes_ { get; set; }
        public int Anio_ { get; set; }
        public string Fase_ { get; set; }

        CNegocio cn = new CNegocio();

        public frmBuscaSeccion()
        {
            InitializeComponent();
        }

        private void frmBuscaSeccion_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSeccion.DataSource = cn.TraerDataset("USP_SECCIONFiltroMatricula", conectar.conexionbdSevilla, VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            }
            catch (Exception)
            {
                //throw;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvSeccion.Rows.Count>0)
            {
                int indexSeccion;
                indexSeccion = this.dgvSeccion.CurrentRow.Index;
                IdSeccion_ = Convert.ToInt32(this.dgvSeccion.Rows[indexSeccion].Cells["IDSECCION"].Value);
                Grado_ = this.dgvSeccion.Rows[indexSeccion].Cells["GRADO"].Value.ToString();
                Nivel_ = this.dgvSeccion.Rows[indexSeccion].Cells["NIVEL"].Value.ToString();
                Seccion_ = this.dgvSeccion.Rows[indexSeccion].Cells["SECCION"].Value.ToString();
                Turno_ = this.dgvSeccion.Rows[indexSeccion].Cells["TURNO"].Value.ToString();
                Nrovacantes_ = Convert.ToInt32(this.dgvSeccion.Rows[indexSeccion].Cells["NUMEROVACANTES"].Value);
                Anio_= Convert.ToInt32(this.dgvSeccion.Rows[indexSeccion].Cells["ANIO"].Value);
                Fase_= this.dgvSeccion.Rows[indexSeccion].Cells["FASE"].Value.ToString();
                this.Close();
            }
        }
    }
}
