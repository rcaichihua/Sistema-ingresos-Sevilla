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
    public partial class frmListadoGrado : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public frmListadoGrado()
        {
            InitializeComponent();
        }

        private void frmMantenimientoGrado_Load(object sender, EventArgs e)
        {
            lblEncabezado.Text = "Listado de Grados del año escolar " + VariablesGlobales.AnioEscolarLogueado + " - " + VariablesGlobales.AnioFaseEscolarLogueado +"";
            LlenarGrados();
        }
        private void LlenarGrados()
        {
            try
            {
                //AQUI SE LLENA LOS GRADOS DEL AÑO CON EL QUE SE LOGUEO EL USUARIO
                dgvGrados.DataSource = cn.EjecutarSqlDTS("SELECT A.IDGRADO,A.DESCRIPCIONGRADO,A.OBSERVACIONES,A.ESTADO FROM GRADOS A INNER JOIN APERTURAANIOESCOLAR B ON A.IDANIO = B.IDANIO INNER JOIN FASE C ON B.IDFASE = C.IDFASE INNER JOIN ANIOESCOLAR D ON D.IDANIO = B.IDANIO WHERE D.ANIO = " + VariablesGlobales.AnioEscolarLogueado + " AND C.DESCRIPCIONFASE = '" + VariablesGlobales.AnioFaseEscolarLogueado + "' order by A.IDGRADO asc", conectar.conexionbdSevilla).Tables[0];
                dgvGrados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                frmMantenimientoGrado winManGrado = new frmMantenimientoGrado();
                winManGrado.TipoMantenimiento = "I";
                winManGrado.IdGrado = 0;
                winManGrado.ShowDialog();
                LlenarGrados();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGrados.Rows.Count <= 0) return;

            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                int indexModGrado;
                indexModGrado = dgvGrados.CurrentRow.Index;
                frmMantenimientoGrado winManGrado = new frmMantenimientoGrado();
                winManGrado.TipoMantenimiento = "U";
                winManGrado.IdGrado = Convert.ToInt32(dgvGrados.Rows[indexModGrado].Cells["IDGRADO"].Value);
                winManGrado.ShowDialog();
                LlenarGrados();
            }
        }
    }

}
