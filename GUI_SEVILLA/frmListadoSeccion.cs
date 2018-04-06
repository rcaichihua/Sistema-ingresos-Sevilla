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
    public partial class frmListadoSeccion : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public frmListadoSeccion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoSeccion_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Listado de secciones del año escolar " + VariablesGlobales.AnioEscolarLogueado + " - " + VariablesGlobales.AnioFaseEscolarLogueado;
            CargarSecciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                frmMantenimientoSeccion winSec = new frmMantenimientoSeccion();
                winSec.IdSeccion = 0;
                winSec.TipoMantenimiento = "I";
                winSec.ShowDialog();
                CargarSecciones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSeccion.Rows.Count <= 0) return;

            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                int indexModGrado;
                indexModGrado = dgvSeccion.CurrentRow.Index;

                frmMantenimientoSeccion winSec = new frmMantenimientoSeccion();
                winSec.IdSeccion = Convert.ToInt32(dgvSeccion.Rows[indexModGrado].Cells["IDSECCION"].Value);
                winSec.TipoMantenimiento = "U";
                winSec.ShowDialog();
                CargarSecciones();
            }
        }
        private void CargarSecciones()
        {
            dgvSeccion.DataSource = cn.EjecutarSqlDTS("SELECT A.IDSECCION,B.IDGRADO, B.DESCRIPCIONGRADO,A.NIVEL,A.LETRASECCION,A.TURNO,A.CODAULA,A.NUMEROVACANTES,D.IDFASE,D.DESCRIPCIONFASE FROM SECCION A INNER JOIN GRADOS B ON A.IDGRADO = B.IDGRADO INNER JOIN ANIOESCOLAR C ON C.IDANIO = B.IDANIO INNER JOIN FASE D ON D.IDFASE = A.IDFASE WHERE C.ANIO = " + VariablesGlobales.AnioEscolarLogueado + " AND D.DESCRIPCIONFASE = '" + VariablesGlobales.AnioFaseEscolarLogueado + "'", conectar.conexionbdSevilla).Tables[0];
            dgvSeccion.Refresh();
        }
    }
}
