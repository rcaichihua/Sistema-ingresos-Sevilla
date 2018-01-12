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
using System.Runtime.InteropServices;

namespace GUI_SEVILLA
{
    public partial class frmUsuarioContrasenia : MetroFramework.Forms.MetroForm
    {
        public frmUsuarioContrasenia()
        {
            InitializeComponent();
        }
        public bool Salir { get; set; }

        CNegocio cn = new CNegocio();
        public string NombreUSuario { get; set; }
        public bool Flag { get; set; }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (NombreUSuario == VariablesGlobales.NombreUsuario && Flag != true)
                {
                    Application.Exit();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Close();
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            byte[] pass = GetPasswordBytes();

            if (txtContrasenia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la contraseña.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContrasenia.Focus();
                return;
            }
            if (txtContrasenia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la contraseña repetida.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContraseniaRepite.Focus();
                return;
            }

            if (txtContrasenia.Text.Trim()!=txtContraseniaRepite.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((MessageBox.Show("¿Esta seguro de cambiar la contraseña.?", VariablesGlobales.NombreMensajes,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                cn.EjecutarSqlDTS("UPDATE USUARIO SET CAMBIAPASSWORD=0 ,[PASSWORD]='" + MetodosGlobales2.Encrypt(VariablesGlobales.llave_publica, pass) + 
                    "' WHERE NOMBREUSUARIO='" + NombreUSuario + "'",conectar.conexionbdSevilla);

                MessageBox.Show("La contraseña ha sido cambiada exitosamente.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                return;
            }
            this.Close();
        }

        private byte[] GetPasswordBytes()
        {
            byte[] ba = null;

            if (txtContrasenia.Text.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(MetodosGlobales.ConvertToSecureString(txtContrasenia.Text));
                try
                {
                    unsafe
                    {
                        byte* byteArray = (byte*)unmanagedBytes.ToPointer();

                        byte* pEnd = byteArray;
                        while (*pEnd++ != 0) { }

                        int length = (int)((pEnd - byteArray) - 1);

                        ba = new byte[length];

                        for (int i = 0; i < length; ++i)
                        {
                            byte dataAtIndex = *(byteArray + i);
                            ba[i] = dataAtIndex;
                        }
                    }
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocAnsi(unmanagedBytes);
                }
            }
            return System.Security.Cryptography.SHA256.Create().ComputeHash(ba);
        }

        private void frmUsuarioContrasenia_Load(object sender, EventArgs e)
        {

        }
    }
}
