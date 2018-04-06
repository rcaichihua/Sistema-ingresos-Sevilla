using BL_SEVILLA;
using DAO_SEVILLA;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    public partial class frmUsuario : MetroFramework.Forms.MetroForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        public bool mantenimiento { get; set; }
        public string NombresCompletos { get; set; }
        public string NroDoc { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public bool UsuDebeCambiarContrasenia { get; set; }
        public bool UsuNocamnbiaContrasenia { get; set; }
        public bool UsuNuncaCaduca { get; set; }
        public bool UsuUsuDeshabilita { get; set; }
        public bool Admin { get; set; }

        CNegocio cn = new CNegocio();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cambioClave = "NO";
            txtApellidosNombres.Text = MetodosGlobales.QuitarCaracteres(txtApellidosNombres.Text);
            txtDocIdentidad.Text = MetodosGlobales.QuitarCaracteres(txtDocIdentidad.Text);
            txtNombreUsuario.Text = MetodosGlobales.QuitarCaracteres(txtNombreUsuario.Text);
            txtConfirmaContrasenia.Text = MetodosGlobales.QuitarCaracteres(txtConfirmaContrasenia.Text);
            txtContrasenia.Text = MetodosGlobales.QuitarCaracteres(txtContrasenia.Text);
            try
            {
                if (txtApellidosNombres.Text.Trim()==String.Empty)
                {
                    MessageBox.Show("Ingrese los nombres completos.",VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    txtApellidosNombres.Focus();
                    return;
                }

                if (txtNombreUsuario.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Ingrese el nombre de usuario.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtNombreUsuario.Focus();
                    return;
                }

                if (txtContrasenia.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Ingrese la contraseña.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtContrasenia.Focus();
                    return;
                }

                if (txtConfirmaContrasenia.Text.Trim() != txtContrasenia.Text.Trim())
                {
                    MessageBox.Show("Las contraseñas no coinciden.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtConfirmaContrasenia.Focus();
                    return;
                }

                byte[] pass = GetPasswordBytes();

                if (txtContrasenia.Text.Trim() != VariablesGlobales.llave_publica)
                {
                    cambioClave = "SI";
                }

                if (mantenimiento != true)
                {
                    if (cn.TraerDataset("USP_VALIDAR_USUARIO", conectar.conexionbdSevilla, txtNombreUsuario.Text.Trim()).Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Nombre de inicio de sesion ya existe, elija otro.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        txtNombreUsuario.Focus();
                        return;
                    }

                    if ((MessageBox.Show("¿Seguro de ingresa el Usuario?", VariablesGlobales.NombreMensajes,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.EjecutarSP("USP_USUARIOInsert", conectar.conexionbdSevilla, txtApellidosNombres.Text.Trim(), txtDocIdentidad.Text.Trim(),
                            txtNombreUsuario.Text.Trim(), MetodosGlobales2.Encrypt(VariablesGlobales.llave_publica, pass), chkCambiarContraseniaInicioSesion.Checked,
                            chkUsuarioNoCambiaContrasenia.Checked, chkContraseniaCaduca.Checked, chkDeshabilitausuario.Checked, DateTime.Now,
                            DateTime.Now, DateTime.Now, cambioClave,chkAdmin.Checked);

                        MessageBox.Show("Ingresado correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LimpiarControles();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if ((MessageBox.Show("¿Seguro de actualizar los datos del Usuario?", VariablesGlobales.NombreMensajes,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.TraerDataset("USP_USUARIOUpdate", conectar.conexionbdSevilla, txtApellidosNombres.Text.Trim(), txtDocIdentidad.Text.Trim() ,
                            txtNombreUsuario.Text.Trim() , MetodosGlobales2.Encrypt(VariablesGlobales.llave_publica, pass) , 
                            chkCambiarContraseniaInicioSesion.Checked ,chkUsuarioNoCambiaContrasenia.Checked,
                            chkContraseniaCaduca.Checked, chkDeshabilitausuario.Checked, DateTime.Now ,
                            DateTime.Now, DateTime.Now , cambioClave, chkAdmin.Checked);

                        MessageBox.Show("Datos actualizados correctamente.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LimpiarControles();
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarControles()
        {
            txtApellidosNombres.Clear();
            txtConfirmaContrasenia.Clear();
            txtContrasenia.Clear();
            txtDocIdentidad.Clear();
            txtNombreUsuario.Clear();
            chkCambiarContraseniaInicioSesion.Checked = false;
            chkContraseniaCaduca.Checked = false;
            chkDeshabilitausuario.Checked = false;
            chkUsuarioNoCambiaContrasenia.Checked = false;
            txtApellidosNombres.Focus();
            chkAdmin.Checked = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cn.TraerServidorSevilla();
            txtApellidosNombres.Focus();

            if (mantenimiento==true)
            {
                txtNombreUsuario.ReadOnly = true;
                txtApellidosNombres.Text = NombresCompletos;
                txtDocIdentidad.Text = NroDoc;
                txtNombreUsuario.Text = NombreUsuario;
                txtContrasenia.Text = VariablesGlobales.llave_publica;
                txtConfirmaContrasenia.Text = VariablesGlobales.llave_publica;
                chkCambiarContraseniaInicioSesion.Checked = UsuDebeCambiarContrasenia;
                chkUsuarioNoCambiaContrasenia.Checked = UsuNocamnbiaContrasenia;
                chkContraseniaCaduca.Checked = UsuNuncaCaduca;
                chkDeshabilitausuario.Checked = UsuUsuDeshabilita;
                chkAdmin.Checked = Admin;
            }
        }
    }
}
