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
            frmUsuario winUser = new frmUsuario();
            winUser.MdiParent = this;
            winUser.Show();
        }

        private void rbActualizarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioListado winUserList = new frmUsuarioListado();
            winUserList.MdiParent = this;
            winUserList.Show();
        }

        private void rbCambiarContrasenia_Click(object sender, EventArgs e)
        {
            frmUsuarioContrasenia WinUsuContra = new frmUsuarioContrasenia
            {
                NombreUSuario = VariablesGlobales.NombreUsuario,
                Flag = true
            };
            WinUsuContra.ShowDialog();
        }
    }
}
