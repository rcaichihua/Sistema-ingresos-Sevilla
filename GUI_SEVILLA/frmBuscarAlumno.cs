using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmBuscarAlumno : MetroFramework.Forms.MetroForm
    {
        public frmBuscarAlumno()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            cboBuscar.SelectedIndex = 0;

        }

        private void BuscarAlumnos()
        {
            DataTable dtAlumnos = new DataTable();
            dtAlumnos = cn.TraerDataset("USP_ALUMNOSelectByFilter", conectar.conexionbdSevilla,cboBuscar.Text,txtFiltro.Text.Trim()).Tables[0];
            dgvAlumnos.DataSource = dtAlumnos;
            dgvAlumnos.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumnos winAlumno = new frmAlumnos();
            winAlumno.TipoMantenimiento = "I";
            winAlumno.IdAlumno = 0;
            winAlumno.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.Rows.Count <= 0) return;

            if (dgvAlumnos.CurrentRow is null) return;

            int indexModAlumno = 0;
            indexModAlumno = dgvAlumnos.CurrentRow.Index;

            frmAlumnos winAlumno = new frmAlumnos();
            winAlumno.TipoMantenimiento = "U";
            winAlumno.IdAlumno = Convert.ToInt32(dgvAlumnos.Rows[indexModAlumno].Cells["IDALUMNO"].Value);
            winAlumno.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            BuscarAlumnos();
        }

        private void AnularAutocompletadoColumnas()
        {
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.AutoGenerateColumns = false;
        }
    }
}
