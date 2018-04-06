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
    public partial class frmListadoAlumnosMatriculados : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public frmListadoAlumnosMatriculados()
        {
            InitializeComponent();
        }

        private void frmListadoAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
            lblEncabezado.Text = "Lista de alumnos Matriculados - Año escolar " + VariablesGlobales.AnioEscolarLogueado + "-" + VariablesGlobales.AnioFaseEscolarLogueado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarMatricula();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                frmFichaMatricula winfrmFichaMatricula = new frmFichaMatricula();
                winfrmFichaMatricula.IdMatricula = 0;
                winfrmFichaMatricula.TipoMantenimiento = "I";
                winfrmFichaMatricula.ShowDialog();
                CargarMatricula();
            }
        }
        private void CargarMatricula()
        {
            int dniNum;

            //if (txtFiltro.Text.Trim() == string.Empty) return;

            if (int.TryParse(txtFiltro.Text, out dniNum))
            {
                this.dgvAlumnosMatriculados.DataSource = cn.TraerDataset("USP_MATRICULASearch", conectar.conexionbdSevilla, 
                    dniNum.ToString(), "D",rbActivos.Checked==true ? true:false).Tables[0];
            }
            else
            {
                this.dgvAlumnosMatriculados.DataSource = cn.TraerDataset("USP_MATRICULASearch", conectar.conexionbdSevilla, 
                    txtFiltro.Text, "N", rbActivos.Checked == true ? true : false).Tables[0];
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnosMatriculados.Rows.Count <= 0) return;

            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                int indexModGrado;
                indexModGrado = this.dgvAlumnosMatriculados.CurrentRow.Index;

                frmFichaMatricula winfrmFichaMatricula = new frmFichaMatricula();
                winfrmFichaMatricula.IdMatricula = Convert.ToInt32(dgvAlumnosMatriculados.Rows[indexModGrado].Cells["IDMATRICULA"].Value);
                winfrmFichaMatricula.TipoMantenimiento = "U";
                winfrmFichaMatricula.ShowDialog();
                CargarMatricula();
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {

            }
        }
    }
}
