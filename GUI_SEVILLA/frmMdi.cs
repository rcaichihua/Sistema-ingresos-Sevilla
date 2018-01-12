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
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }
        public bool Salir_ { get; set; }
        CNegocio cn = new CNegocio();

        private void creaciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario winUser = new frmUsuario();
            winUser.MdiParent = this;
            winUser.Show();
        }

        private void usuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioListado winUserList = new frmUsuarioListado();
            winUserList.MdiParent = this;
            winUserList.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioContrasenia WinUsuContra = new frmUsuarioContrasenia
            {
                NombreUSuario = VariablesGlobales.NombreUsuario,
                Flag = true
            };
            WinUsuContra.ShowDialog();
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {
            this.Text = "Sociedad de Beneficencia de Lima [USUARIO: " + VariablesGlobales.NombreCompletoUsuario + "].";
            if (Convert.ToBoolean(cn.EjecutarSqlDTS("SELECT CAMBIAPASSWORD FROM USUARIO WHERE NOMBREUSUARIO='" +
                VariablesGlobales.NombreUsuario + "'", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString()))
            {
                frmUsuarioContrasenia winContras = new frmUsuarioContrasenia();
                winContras.NombreUSuario = VariablesGlobales.NombreUsuario;
                winContras.ShowDialog();
                if (winContras.Salir == true)
                {
                    Salir_ = winContras.Salir;
                    this.Close();
                }
            }
        }

        private void frmMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
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
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {

                throw;
            }          
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno winAlum = new frmBuscarAlumno();
            winAlum.MdiParent = this;
            winAlum.Show();
        }
    }
}
