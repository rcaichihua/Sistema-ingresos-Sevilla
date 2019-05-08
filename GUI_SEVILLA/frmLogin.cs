using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;

namespace GUI_SEVILLA
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnIngresar, "Ingresar al sistema");
            this.ttMensaje.SetToolTip(this.btnSalir, "Cerrar la ventana");
        }
        CNegocio cn = new CNegocio();
        private int intentos;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string con_are = "sblmlan";
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

                //cn.TraerServidorSGI();
                //cn.TraerServidorSUNATFE();
                //cn.TraerServidorTesoreria();
                //cn.TraerServidorTesoreria();
                //string srv, string bd, string us, string pw
                //MessageBox.Show(Program.Server+" / "+ Program.database +" / "+ Program.dbUsername+"/"+Program.dbPassword);
                cn.TraerServidorSevilla(Program.Server, Program.database, Program.dbUsername, Program.dbPassword);
                LlenarAnio();
                CargarFase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la base de datos, contacte con sistemas o intente de nuevo. " + ex.Message + ""
                    , VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LlenarAnio()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                cboAnio.DataSource = cn.EjecutarSqlDTS("exec USP_ANIOESCOLARSelectAll", conectar.conexionbdSevilla).Tables[0];
                cboAnio.DisplayMember = "ANIO";
                cboAnio.ValueMember = "IDANIO";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void CargarFase()
        {
            try
            {
                cboFase.DataSource = cn.EjecutarSqlDTS("select A.IDFASE,B.DESCRIPCIONFASE from APERTURAANIOESCOLAR A INNER JOIN FASE B ON A.IDFASE=B.IDFASE where A.IDANIO=" + cboAnio.SelectedValue+"", conectar.conexionbdSevilla).Tables[0];
                cboFase.DisplayMember = "DESCRIPCIONFASE";
                cboFase.ValueMember = "IDFASE";
            }
            catch (Exception)
            {

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataSet dtsDatosUsuario = new DataSet();
            DataTable dtAnios = new DataTable();
            VariablesGlobales.NombreMensajes = "...::: SISTEMA SEVILLA :::...";

            string clave_user = null;

            try
            {
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

                if (dtsDatosUsuario.Tables[0].Rows.Count > 0)
                {
                    byte[] passwordBytes = GetPasswordBytes();

                    VariablesGlobales.FechaActual = cn.EjecutarSqlDTS("select CONVERT(VARCHAR(8),getdate(),112)", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString();
                    clave_user = dtsDatosUsuario.Tables[0].Rows[0]["PASSWORD"].ToString();
                    FLG_ACTIVO = Convert.ToBoolean(dtsDatosUsuario.Tables[0].Rows[0]["DESACTIVAR"]);
                    VariablesGlobales.AnioFiscal = Convert.ToInt32(VariablesGlobales.FechaActual.Substring(0, 4));

                    if (txtContrasenia.Text == MetodosGlobales2.Decrypt(clave_user, passwordBytes))
                    {
                        if (FLG_ACTIVO != false)
                        {
                            MessageBox.Show("Usuario deshabilitado !!!", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information
                                                                                                            , MessageBoxDefaultButton.Button1);
                            txtContrasenia.Focus();
                        }
                        else
                        {
                            dtAnios = cn.EjecutarSqlDTS("select ANIO,DESCRIPANIO,B.IDFASE,C.DESCRIPCIONFASE from ANIOESCOLAR A INNER JOIN APERTURAANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN  FASE C ON B.IDFASE=C.IDFASE WHERE ESTADO=1", conectar.conexionbdSevilla).Tables[0];

                            VariablesGlobales.NombreCompletoUsuario = dtsDatosUsuario.Tables[0].Rows[0]["NOMBRECOMPLETO"].ToString();
                            VariablesGlobales.NombreUsuario = dtsDatosUsuario.Tables[0].Rows[0]["NOMBREUSUARIO"].ToString();
                            VariablesGlobales.AnioEscolarLogueado = Convert.ToInt32(cboAnio.Text);
                            VariablesGlobales.AnioFaseEscolarLogueado = cboFase.Text;
                            VariablesGlobales.admin = Convert.ToBoolean(dtsDatosUsuario.Tables[0].Rows[0]["administrador"]);
                            VariablesGlobales.AnioEscolarAperturado = Convert.ToInt32(dtAnios.Rows[0][0]);
                            VariablesGlobales.AnioFaseEscolarAperturado = dtAnios.Rows[0][3].ToString();
                            VariablesGlobales.NombreAnioActual = dtAnios.Rows[0][1].ToString();

                            this.Height = 435;
                            this.Hide();
                            frmMenu menu = new frmMenu();
                            menu.lblUsuario.Text = VariablesGlobales.NombreCompletoUsuario;
                            menu.lblAnioEscolarLogueado.Text = cboAnio.Text +" - FASE "+ cboFase.Text;
                            menu.lblAnioEscolarAperturado.Text = VariablesGlobales.AnioEscolarAperturado.ToString()+" - FASE "+VariablesGlobales.AnioFaseEscolarAperturado;
                            menu.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrectos, verifique !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
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
                MessageBox.Show("Error. "+ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
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

            if (VariablesGlobales.configuracion.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(MetodosGlobales.ConvertToSecureString(VariablesGlobales.configuracion));
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

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFase();
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtContrasenia.Focus();
            }
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Purple;
        }
    }
}
