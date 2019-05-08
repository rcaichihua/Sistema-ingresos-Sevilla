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
            this.ttMensaje.SetToolTip(this.btnBuscar,"Buscar");
            this.ttMensaje.SetToolTip(this.btnDarDeBaja, "Dar de baja");
            this.ttMensaje.SetToolTip(this.btnEditar, "Editar");
            this.ttMensaje.SetToolTip(this.btnImpresion, "Listado de matriculas por nivel y sección");
            this.ttMensaje.SetToolTip(this.btnSalir, "Salir de la Ventana");
            this.ttMensaje.SetToolTip(this.btnActivar, "Volver a activar la matricula");
            this.ttMensaje.SetToolTip(this.btnNuevo, "Nueva matrícula");
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
            lblCantidadRegistros.Text = dgvAlumnosMatriculados.Rows.Count.ToString();
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
            Int64 dniNum;

            //if (txtFiltro.Text.Trim() == string.Empty) return;

            if (Int64.TryParse(txtFiltro.Text, out dniNum))
            {
                this.dgvAlumnosMatriculados.DataSource = cn.TraerDataset("USP_MATRICULASearch", conectar.conexionbdSevilla, 
                    dniNum.ToString(), "D",rbActivos.Checked==true ? true:false,VariablesGlobales.AnioEscolarLogueado,VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            }
            else
            {
                this.dgvAlumnosMatriculados.DataSource = cn.TraerDataset("USP_MATRICULASearch", conectar.conexionbdSevilla, 
                    txtFiltro.Text, "N", rbActivos.Checked == true ? true : false, VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnosMatriculados.Rows.Count <= 0) return;

            if (MetodosGlobales.VerificaAnioEscolar(cn))
            {
                int indexModGrado;
                indexModGrado = this.dgvAlumnosMatriculados.CurrentRow.Index;

                if (Convert.ToBoolean(this.dgvAlumnosMatriculados.Rows[indexModGrado].Cells["ESTADO"].Value) == false)
                {
                    MessageBox.Show("La matrícula ya fue dada de baja.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

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
                if (this.dgvAlumnosMatriculados.Rows.Count <= 0) return;

                int indexMatricula;
                indexMatricula = this.dgvAlumnosMatriculados.CurrentRow.Index;

                if (this.dgvAlumnosMatriculados.Rows.Count <= 0) return;

                //if (Convert.ToBoolean(this.dgvAlumnosMatriculados.Rows[indexMatricula].Cells["ESTADO"].Value)==false)
                if (Convert.ToBoolean(cn.EjecutarSqlDTS("select ESTADO from MATRICULA where IDMATRICULA="+ this.dgvAlumnosMatriculados.Rows[indexMatricula].Cells["IDMATRICULA"].Value + "", conectar.conexionbdSevilla).Tables[0].Rows[0][0])==false)
                {
                    MessageBox.Show("La matrícula ya fue dada de baja.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (VerificaSiHayPagos(Convert.ToInt32(this.dgvAlumnosMatriculados.Rows[indexMatricula].Cells["IDMATRICULA"].Value)))
                {
                    string message = "La matrícula tiene pagos ya realizados." + Environment.NewLine +
                    Environment.NewLine +
                    "Esta seguro de continuar con el proceso de baja?";

                    string caption = VariablesGlobales.NombreMensajes;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                }
                                  
                frmBajaMatricula winBajaMatricula = new frmBajaMatricula();
                winBajaMatricula.IdMatricula = Convert.ToInt32(this.dgvAlumnosMatriculados.Rows[indexMatricula].Cells["IDMATRICULA"].Value);
                winBajaMatricula.ShowDialog();
                btnBuscar_Click(sender, e);    
                              
            }
        }
        private bool VerificaSiHayPagos(int idMatri)
        {
            return (cn.TraerDataset("USP_CUENTACORRIENTEVerificaPagos", conectar.conexionbdSevilla,idMatri).Tables[0].Rows[0][0].ToString()!="0");
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void rbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnImpresion_Click(object sender, EventArgs e)
        {
            DataTable dtAlMa = new DataTable();
            dtAlMa = cn.TraerDataset("USP_MATRICULASearch", conectar.conexionbdSevilla,
                    "", "N", rbActivos.Checked == true ? true : false, VariablesGlobales.AnioEscolarLogueado,
                    VariablesGlobales.AnioFaseEscolarLogueado).Tables[0];
            if (dtAlMa.Rows.Count <= 0) return;
            frmImpresion winImpre = new frmImpresion();
            winImpre.TipoReporte = 3;
            winImpre.MiTabla = dtAlMa;
            winImpre.ShowDialog();
        }
    }
}
