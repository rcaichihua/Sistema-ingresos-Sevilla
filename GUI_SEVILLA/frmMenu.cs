using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmMenu : Form
    {
        CNegocio cn = new CNegocio();

        public frmMenu()
        {
            InitializeComponent();
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

            this.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.sevilla_fondo_fw;
            this.BackgroundImageLayout = ImageLayout.Center;
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

        private void rbCobros_Click(object sender, EventArgs e)
        {
            //if (MetodosGlobales.VerificaAnioEscolar(cn))
            //{
                if (FormIsOpen("frmGeneraDeuda"))

                {
                    return;
                }
                frmGeneraDeuda winfrmGeneraDeuda = new frmGeneraDeuda();
                winfrmGeneraDeuda.MdiParent = this;
                winfrmGeneraDeuda.Show();
            //}
        }

        private void rbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMantAlumnos_Click(object sender, EventArgs e)
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

        private void rbMantConceptos_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmConceptos"))

            {
                return;
            }
            frmListadoConceptos winfrmConceptos = new frmListadoConceptos();
            winfrmConceptos.MdiParent = this;
            winfrmConceptos.Show();
        }

        private void rbRegistroPagos_Click(object sender, EventArgs e)
        {
            //if (MetodosGlobales.VerificaAnioEscolar(cn))
            //{
                if (FormIsOpen("frmPagos"))
                {
                    return;
                }
                frmPagos winfrmPagos = new frmPagos();
                winfrmPagos.MdiParent = this;
                winfrmPagos.Show();
            //}
        }

        private void rbCrearUser_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmUsuario"))

            {
                return;
            }
            frmUsuario winUser = new frmUsuario();
            winUser.MdiParent = this;
            winUser.Show();
        }

        private void rbActualizar_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmUsuarioListado"))

            {
                return;
            }
            frmUsuarioListado winUserList = new frmUsuarioListado();
            winUserList.MdiParent = this;
            winUserList.Show();
        }

        private void rbCambiarPassword_Click(object sender, EventArgs e)
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

        private void rbListadoPagos_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("frmPagosListado"))

            {
                return;
            }
            frmPagosListado winfrmPagosListado = new frmPagosListado();
            winfrmPagosListado.MdiParent = this;
            winfrmPagosListado.Show();
        }

        private void rbGeneraTxtDeudas_Click(object sender, EventArgs e)
        {
            frmSeleccionDeudaAnio win = new frmSeleccionDeudaAnio();
            win.ShowDialog();
            //try
            //{
            //    if (!Directory.Exists(@"C:\BBVA"))
            //    {
            //        Directory.CreateDirectory(@"C:\BBVA");
            //    }

            //    DataTable TablaDatos = new DataTable();

            //    TablaDatos = cn.TraerDataset("USP_DEUDA_TOTAL_MENSUAL_BANCOS", conectar.conexionbdSevilla, 
            //        VariablesGlobales.AnioEscolarAperturado).Tables[0];

            //    int rowcount = TablaDatos.Rows.Count;

            //    TextWriter sw = new StreamWriter($@"C:\BBVA\DeudaSevilla" + DateTime.Now.ToString("yyyyMMdd") + ".txt");

            //    for (int i = 0; i < rowcount; i++)
            //    {
            //        sw.WriteLine(TablaDatos.Rows[i][0].ToString());
            //    }

            //    sw.Close();

            //    MessageBox.Show(@"Archivo deudas Exportados correctamente a TXT en la ruta C:\BBVA", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void rbGeneraTxtBanco_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("Form1"))

            {
                return;
            }
            Form1 winfrmEstadoCuenta = new Form1();
            winfrmEstadoCuenta.MdiParent = this;
            winfrmEstadoCuenta.Show();
        }
    }
}
