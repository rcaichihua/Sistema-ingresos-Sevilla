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
        public int idAlumno_ { get; set; }
        public string dni_ { get; set; }
        public string nombreAlumno_ { get; set; }
        public DateTime fechaNac_ { get; set; }
        public int edad_ { get; set; }
        public string ubigeoDirec_ { get; set; }
        public string direccion_ { get; set; }
        public string ubigeoLugNac_ { get; set; }
        public string telefono_ { get; set; }
        public string seguro_ { get; set; }
        public string observacionesAlum_ { get; set; }

        public string TipoModalidad { get; set; }

        public frmBuscarAlumno()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnBuscar,"Permite buscar segun el filtro ingresado");
        }
        CNegocio cn = new CNegocio();

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            cboBuscar.SelectedIndex = 0;
            if (TipoModalidad=="M")
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }

        private void BuscarAlumnos()
        {
            try
            {
                DataTable dtAlumnos = new DataTable();
                dtAlumnos = cn.TraerDataset("USP_ALUMNOSelectByFilter", conectar.conexionbdSevilla, cboBuscar.Text== "Nº DOC" ? "dni": cboBuscar.Text, txtFiltro.Text.Trim()).Tables[0];
                dgvAlumnos.DataSource = dtAlumnos;
                dgvAlumnos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TipoModalidad == "A")
            {
                frmAlumnos winAlumno = new frmAlumnos();
                winAlumno.TipoMantenimiento = "I";
                winAlumno.IdAlumno = 0;
                winAlumno.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else if (TipoModalidad=="M")//para matricula
            {
                if (this.dgvAlumnos.Rows.Count <= 0) return;
                DataTable dtAlumno = new DataTable();
                int indexAlumno_ = 0;
                indexAlumno_ = this.dgvAlumnos.CurrentRow.Index;

                if (!Convert.ToBoolean(this.dgvAlumnos.Rows[indexAlumno_].Cells["ESTADO"].Value)) {
                    MessageBox.Show("No se puede generar matricula, el estado del registro es anulado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dtAlumno = cn.TraerDataset("USP_ALUMNO_MATRICULASearch", conectar.conexionbdSevilla, Convert.ToInt32(this.dgvAlumnos.Rows[indexAlumno_].Cells["IDALUMNO"].Value)).Tables[0];
                idAlumno_ = Convert.ToInt32(dtAlumno.Rows[0][0]);
                dni_ = dtAlumno.Rows[0][1].ToString();
                nombreAlumno_ = dtAlumno.Rows[0][2].ToString();
                fechaNac_ = dtAlumno.Rows[0][3].ToString().Trim()=="" ? DateTime.Now : Convert.ToDateTime(dtAlumno.Rows[0][3]);
                edad_ = Convert.ToInt32(calcularEdad(fechaNac_.ToString("yyyyMMdd")).ToString().ToString());
                ubigeoDirec_ = dtAlumno.Rows[0][4].ToString();
                direccion_ = dtAlumno.Rows[0][5].ToString();
                ubigeoLugNac_ = dtAlumno.Rows[0][6].ToString();
                telefono_ = dtAlumno.Rows[0][7].ToString();
                seguro_ = dtAlumno.Rows[0][8].ToString();
                observacionesAlum_ = dtAlumno.Rows[0][9].ToString();
                this.Close();
            }
        }

        private decimal calcularEdad(string fecha)
        {
            return Math.Floor(Convert.ToDecimal((Convert.ToInt32(VariablesGlobales.FechaActual) - Convert.ToInt32(fecha)) / 10000));
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
            btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = MetodosGlobales.QuitarCaracteres(txtFiltro.Text.Trim());

            AnularAutocompletadoColumnas();
            if (cboBuscar.Text=="Nº DOC")
            {
                Int64 dniAlumno = 0;

                if (!Int64.TryParse(txtFiltro.Text.Trim(),out dniAlumno))
                {
                    MessageBox.Show("En el caso de busqueda por Nº de documento, favor de ingresar datos correctos..", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFiltro.Focus();
                    return;
                }
            }
            BuscarAlumnos();
        }

        private void AnularAutocompletadoColumnas()
        {
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnListadoAlumnos_Click(object sender, EventArgs e)
        {
            frmImpresion winImpre = new frmImpresion();
            winImpre.TipoReporte = 2;
            winImpre.MiTabla = cn.TraerDataset("USP_ALUMNOSelectAll", conectar.conexionbdSevilla,1).Tables[0];
            winImpre.ShowDialog();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
