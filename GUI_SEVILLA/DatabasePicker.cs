using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    class DatabasePicker
    {
        private string FILE_NAME = System.IO.Directory.GetParent(Application.ExecutablePath) + "\\llave\\DBSevillaKey.txt";

        public void SetConnctionString()
        {
            if (!File.Exists(FILE_NAME))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "El Archivo de configuración de la base de datos no se ha encontrado ¿ Desea restablecerlo ? ",
                    "Clave de base de datos no encontra", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.Filter = "Text|*.txt|All|*.*";
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            String Sourcefile = openFileDialog1.FileName;
                            File.Copy(Sourcefile, FILE_NAME);
                            MessageBox.Show("Clave de datos recibida", "Clave de datos");
                            SetConnctionString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: no se pudo leer el archivo del disco.Error original: " + ex.Message, "Clave de datos");
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            else
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(FILE_NAME);

                string[] lines = File.ReadAllLines(FILE_NAME); //File is in System.IO
                string primero = lines[1]; //servername
                string segundo = lines[2]; //databasename
                string tercero = lines[3]; //userid
                string cuarto = lines[4];//password               
                //"192.168.1.14";// 
                Program.Server = MetodosGlobales2.Decrypt(primero, GetPasswordBytes());
                Program.database = MetodosGlobales2.Decrypt(segundo, GetPasswordBytes());
                Program.dbUsername = MetodosGlobales2.Decrypt(tercero, GetPasswordBytes());
                Program.dbPassword = MetodosGlobales2.Decrypt(cuarto, GetPasswordBytes());
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
    }
}
