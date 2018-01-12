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
            frmAlumno winAlumno = new frmAlumno();
            winAlumno.TipoMantenimiento = "I";
            winAlumno.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAlumno winAlumno = new frmAlumno();
            winAlumno.TipoMantenimiento = "U";
            winAlumno.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAlumnos();
        }
    }
}
