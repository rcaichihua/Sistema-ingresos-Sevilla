﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public static class MetodosGlobales
    {
        public static SecureString ConvertToSecureString(this string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            unsafe
            {
                fixed (char* passwordChars = password)
                {
                    var securePassword = new SecureString(passwordChars, password.Length);
                    securePassword.MakeReadOnly();
                    return securePassword;
                }
            }
        }

        public static DataTable ToDataTable<T>(this List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);


                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static bool VerificaAnioEscolar(CNegocio cNegocio)
        {
            bool respta = true;

            DataTable dtAnioValido = new DataTable();
            dtAnioValido = cNegocio.EjecutarSqlDTS("select count(*) as cantidad from ANIOESCOLAR A INNER JOIN APERTURAANIOESCOLAR B ON A.IDANIO=B.IDANIO INNER JOIN FASE C ON C.IDFASE=B.IDFASE WHERE b.ESTADO=1 AND A.ANIO=" + VariablesGlobales.AnioEscolarLogueado + " AND C.DESCRIPCIONFASE='" + VariablesGlobales.AnioFaseEscolarLogueado + "'", conectar.conexionbdSevilla).Tables[0];
               
            if (dtAnioValido.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("No se puede agregar ni modificar los años escolares ya cerrados.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                respta = false;
            }
            return respta;
        }

        public static string QuitarCaracteres(string cadena)
        {
            string lineaNueva = "";
            string lineaNueva2 = "";
            int tamanoLinea = 0;
            string[] ESPACIO = new string[37] { "\"\"", ";", ",", "+", "!", "#", "$", "%", "/", "(", "\\", "¡", "¿", "'", "`", "~", "[", "}", "]", "<", ">", "_", ")", "{", "^", ":", "|", "¬", "=", "?", "°", "º", "´", "&", "º", "-" ,"*"};

            tamanoLinea = cadena.Length;

            for (int i = 0; i < tamanoLinea; i++)
            {
                lineaNueva = cadena.Substring(i, 1);
                for (int espa_ = 0; espa_ < ESPACIO.Length; espa_++)
                {
                    if (ESPACIO[espa_].ToString() == lineaNueva)
                    {
                        lineaNueva = @"";
                    }
                }
                lineaNueva2 = lineaNueva2 + lineaNueva;
            }
            return lineaNueva2;
        }

        public static string NombreMes(int mes)
        {
            string mesNombre;

            switch (mes)
            {
                case 1 : mesNombre = "Enero"; break;
                case 2: mesNombre = "Febrero"; break;
                case 3: mesNombre = "Marzo"; break;
                case 4: mesNombre = "Abril"; break;
                case 5: mesNombre = "Mayo"; break;
                case 6: mesNombre = "Junio"; break;
                case 7: mesNombre = "Julio"; break;
                case 8: mesNombre = "Agosto"; break;
                case 9: mesNombre = "Setiembre"; break;
                case 10: mesNombre = "Octubre"; break;
                case 11: mesNombre = "Noviembre"; break;
                case 12: mesNombre = "Diciembre"; break;

                default: mesNombre = "No definido";
                    break;
            }
            return mesNombre;
        }
    }
}
