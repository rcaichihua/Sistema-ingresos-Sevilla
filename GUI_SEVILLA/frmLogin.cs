using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;
using System.Data;
using System.Runtime.InteropServices;

namespace GUI_SEVILLA
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        private int intentos;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string con_are = "SBLMLAN";
            int sblmLan = 0;
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if (con_are.ToLower() == adapter.Name.ToString().ToLower() ||
                        adapter.Name.ToString().ToLower() == "sblmlan1")
                    {
                        sblmLan++;
                        break;
                    }
                }

                if (sblmLan == 0)
                {
                    MessageBox.Show("Debe configurar los parametros del sistema correctamente, contacte con el administrador del sistema. Se saldrá del sistema.",
                        VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                       MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }

                string Ip = "", HostUser = "";

                HostUser = Dns.GetHostName();
                IPAddress[] hostIPs = Dns.GetHostAddresses(HostUser);

                for (int i = 0; i < hostIPs.Length; i++)
                {
                    Ip = hostIPs[i].ToString();
                    if (Ip.Substring(0, 9) == "192.168.1") break;
                }

                VariablesGlobales.UserHostIp = HostUser + "/" + Ip;

                cn.TraerServidorSGI();
                cn.TraerServidorSUNATFE();
                cn.TraerServidorTesoreria();
                cn.TraerServidorTesoreria();
                cn.TraerServidorSevilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la base de datos, contacte con sistemas o intente de nuevo. " + ex.Message + ""
                    , VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataSet dtsDatosUsuario = new DataSet();
            VariablesGlobales.NombreMensajes = "...::: SISTEMA SEVILLA :::...";

            string clave_user = null;

            try
            {
                //txtUsuario.Text = "RCAICHIHUA";
                //txtContrasenia.Text = "123";

                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese su nombre de Usuario !!!", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                            MessageBoxDefaultButton.Button1);
                    txtUsuario.Focus();
                    return;
                }
                if ((txtContrasenia.Text).ToString().Length <= 0)
                {
                    MessageBox.Show("Ingrese su Contraseña !!!", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                        MessageBoxDefaultButton.Button1);
                    txtContrasenia.Focus();
                    return;
                }

                dtsDatosUsuario = cn.TraerDataset("USP_VALIDAR_USUARIO", conectar.conexionbdSevilla, this.txtUsuario.Text.ToString());

                bool FLG_ACTIVO = false;

                VariablesGlobales.AnioFiscal = Convert.ToInt32(cn.EjecutarSqlDTS("select year(getdate())", conectar.conexionbdSevilla).Tables[0].Rows[0][0]);

                if (dtsDatosUsuario.Tables[0].Rows.Count > 0)
                {
                    VariablesGlobales.NombreCompletoUsuario = dtsDatosUsuario.Tables[0].Rows[0]["NOMBRECOMPLETO"].ToString();
                    VariablesGlobales.NombreUsuario = dtsDatosUsuario.Tables[0].Rows[0]["NOMBREUSUARIO"].ToString();
                    clave_user = dtsDatosUsuario.Tables[0].Rows[0]["PASSWORD"].ToString();
                    FLG_ACTIVO = Convert.ToBoolean(dtsDatosUsuario.Tables[0].Rows[0]["DESACTIVAR"]);
                    VariablesGlobales.admin = Convert.ToBoolean(dtsDatosUsuario.Tables[0].Rows[0]["administrador"]);

                    byte[] passwordBytes = GetPasswordBytes();

                    if (VariablesGlobales.llave_publica == devuelveLlavePublica(clave_user, passwordBytes))
                    {
                        if (FLG_ACTIVO != false)
                        {
                            MessageBox.Show("Usuario deshabilitado !!!", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information
                                                                                                            , MessageBoxDefaultButton.Button1);
                            txtContrasenia.Focus();
                        }
                        else
                        {
                            this.Height = 435;
                            this.Hide();
                            frmMenu menu = new frmMenu();
                            menu.Show();
                        }
                    }
                    else
                    {
                        intentos += 1;
                        if (intentos == 3)
                        {
                            MessageBox.Show("Acceso Denegado !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                            System.Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos, verifique !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    this.txtUsuario.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el logueo: " + ex.ToString() + "", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private string devuelveLlavePublica(string clave, byte[] pass)
        {
            try
            {
                return MetodosGlobales2.Decrypt(clave, pass);
            }
            catch
            {
                MessageBox.Show("Usuario/Contraseña incorrecta !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtContrasenia.Focus();
                return null;
            }
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
    }
}
