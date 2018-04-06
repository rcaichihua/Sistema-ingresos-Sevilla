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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void rbCrearUsuario_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmUsuario"))

            {
                return;
            }
            frmUsuario winUser = new frmUsuario();
            winUser.MdiParent = this;
            winUser.Show();
        }

        private void rbActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmUsuarioListado"))

            {
                return;
            }
            frmUsuarioListado winUserList = new frmUsuarioListado();
            winUserList.MdiParent = this;
            winUserList.Show();
        }

        private void rbCambiarContrasenia_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmUsuarioContrasenia"))

            {
                return;
            }
            frmUsuarioContrasenia WinUsuContra = new frmUsuarioContrasenia
            {
                NombreUSuario = VariablesGlobales.NombreUsuario,
                Flag = true
            };
            WinUsuContra.ShowDialog();
        }

        public static Boolean FormIsOpen(String FormABuscar)

        {
            Boolean lEncontrado = false;

            foreach (Form form in Application.OpenForms)

            {
                if (form.Name == FormABuscar)

                {
                    form.WindowState = FormWindowState.Normal;

                    form.Activate();

                    lEncontrado = true;

                    break;
                }
            }
            return lEncontrado;
        }

        private void rbAlumnos_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmBuscarAlumno"))

            {
                return;
            }
            frmBuscarAlumno winUserList = new frmBuscarAlumno();
            winUserList.MdiParent = this;
            winUserList.TipoModalidad = "A"; //modalidad Agregar o modificar nuevo alumno
            winUserList.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (varGlobales.verificaCierre == false)
            //{
            string message = "Esta seguro que desea salir del Sistema?";
            string caption = "...:::Salir del Sistema:::...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else //if (varGlobales.verificaCierre == false)
            {
                e.Cancel = true;
            }
            //}
        }

        private void rbConceptos_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmConceptos"))

            {
                return;
            }
            frmListadoConceptos winfrmConceptos = new frmListadoConceptos();
            winfrmConceptos.MdiParent = this;
            winfrmConceptos.Show();
        }

        private void rbAperturaAnio_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmAperturaAnioEscolar"))

            {
                return;
            }
            frmAperturaAnioEscolar winfrmAperturaAnioEscolar = new frmAperturaAnioEscolar();
            winfrmAperturaAnioEscolar.MdiParent = this;
            winfrmAperturaAnioEscolar.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = "...::: S I S T E M A  D E  M A T R I C U L A :::..  || Año " + VariablesGlobales.AnioFiscal + " : " + VariablesGlobales.NombreAnioActual;
        }

        private void rbRegistroGrado_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmListadoGrado"))

            {
                return;
            }
            frmListadoGrado winfrmListadoGrado = new frmListadoGrado();
            winfrmListadoGrado.MdiParent = this;
            winfrmListadoGrado.Show();
        }

        private void rbRegistroSeccion_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmListadoSeccion"))

            {
                return;
            }
            frmListadoSeccion winfrmListadoSeccion = new frmListadoSeccion();
            winfrmListadoSeccion.MdiParent = this;
            winfrmListadoSeccion.Show();
        }

        private void rbMatricula_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmListadoAlumnosMatriculados"))

            {
                return;
            }
            frmListadoAlumnosMatriculados winfrmListadoAlumnosMatriculados = new frmListadoAlumnosMatriculados();
            winfrmListadoAlumnosMatriculados.MdiParent = this;
            winfrmListadoAlumnosMatriculados.Show();
        }

        private void rbCtaCorreinte_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmEstadoCuenta"))

            {
                return;
            }
            frmEstadoCuenta winfrmEstadoCuenta = new frmEstadoCuenta();
            winfrmEstadoCuenta.MdiParent = this;
            winfrmEstadoCuenta.Show();
        }
    }
}
