﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    public class varGlobales
    {
        public string RUTA_XML = System.Windows.Forms.Application.StartupPath.ToString() + @"\XML\";
        public string RUTA_XML_REPORTES = System.Windows.Forms.Application.StartupPath.ToString() + @"\Reportes\";
        public string RUTA_FONDO = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\";
        public String ruta1 = System.Windows.Forms.Application.StartupPath.ToString();
        public static readonly string llave_publica = "b6n6f1c6nc15";
        public static bool verificaCierre = false;

        #region Metodos para realizar el proceso de encriptacion
        private static string ByteToString(int value)
        {
            StringBuilder builder = new StringBuilder(sizeof(byte) * 8);
            BitArray[] bitArrays = BitConverter.GetBytes(value).Reverse().Select(b => new BitArray(new[] { b })).ToArray();
            foreach (bool bit in bitArrays.SelectMany(bitArray => bitArray.Cast<bool>().Reverse()))
            {
                builder.Append(bit ? '1' : '0');
            }
            return builder.ToString();
        }

        #endregion

        public DataTable ToDataTable<T>(IEnumerable<T> l_oItems)
        {
            DataTable oReturn = new DataTable(typeof(T).Name);
            object[] a_oValues;
            int i;

            PropertyInfo[] a_oProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo oProperty in a_oProperties)
            {
                oReturn.Columns.Add(oProperty.Name, BaseType(oProperty.PropertyType));
            }

            foreach (T oItem in l_oItems)
            {
                a_oValues = new object[a_oProperties.Length];

                for (i = 0; i < a_oProperties.Length; i++)
                {
                    a_oValues[i] = a_oProperties[i].GetValue(oItem, null);
                }

                oReturn.Rows.Add(a_oValues);
            }
            return oReturn;
        }

        public static Type BaseType(Type oType)
        {
            if (oType != null && oType.IsValueType &&
                oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(oType);
            }
            else
            {
                return oType;
            }
        }

        #region validaciones de Formulario
        public static void habilitarCampos(Form M, bool GIS)
        {

            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.GroupBox)))
                {
                    //if (!(ctrl.Name.ToString().Substring(0, 1) == "I") && GIS==false)
                    //{
                    if (ctrl.Controls.Count >= 2)
                    {
                        for (int j = 0; j < ctrl.Controls.Count; j++)
                        {
                            System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];

                            if (ctrl2.GetType() == typeof(System.Windows.Forms.TextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.ComboBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.CheckBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.RadioButton))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.Button))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                            if (ctrl2.GetType() == typeof(System.Windows.Forms.RadioButton))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Enabled = GIS;
                            }
                        }
                        //}
                    }
                }
            }
        }

        public static void habilitarCamposTabControl(Form M, bool GIS, int index)
        {
            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.TabControl)))
                {
                    for (int j = 0; j < ctrl.Controls.Count; j++)
                    {
                        System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];
                        if ((ctrl2.GetType() == typeof(System.Windows.Forms.TabPage)))
                        {
                            for (int k = 0; k < ctrl2.Controls.Count; k++)
                            {
                                System.Windows.Forms.Control ctrl3 = ctrl2.Controls[k];
                                if ((ctrl3.GetType() == typeof(System.Windows.Forms.GroupBox)))
                                {
                                    if (ctrl3.Controls.Count >= 2)
                                    {
                                        for (int l = 0; l < ctrl3.Controls.Count; l++)
                                        {
                                            System.Windows.Forms.Control ctrl4 = ctrl3.Controls[l];

                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.TextBox))
                                            {
                                                ctrl4.Enabled = GIS;
                                            }
                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.ComboBox))
                                            {
                                                ctrl4.Enabled = GIS;
                                            }
                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.CheckBox))
                                            {
                                                ctrl4.Enabled = GIS;
                                            }
                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.RadioButton))
                                            {
                                                ctrl4.Enabled = GIS;
                                            }
                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.Button))
                                            {
                                                ctrl4.Enabled = GIS;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }

        public static void resetearCampos(Form M)
        {
            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.GroupBox)))
                {
                    if (ctrl.Controls.Count >= 2)
                    {
                        for (int j = 0; j < ctrl.Controls.Count; j++)
                        {
                            System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];

                            if (ctrl2.GetType() == typeof(System.Windows.Forms.TextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Text = string.Empty;
                            }
                            else if (ctrl2.GetType() == typeof(System.Windows.Forms.ComboBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Text = "[seleccione]";
                            }
                            else if (ctrl2.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C")) ctrl2.Text = "";
                            }
                        }
                    }

                }
            }
        }

        public static void resetearCamposTabControl(Form M)
        {
            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.TabControl)))
                {
                    for (int j = 0; j < ctrl.Controls.Count; j++)
                    {
                        System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];
                        if ((ctrl2.GetType() == typeof(System.Windows.Forms.TabPage)))
                        {
                            for (int k = 0; k < ctrl2.Controls.Count; k++)
                            {
                                System.Windows.Forms.Control ctrl3 = ctrl2.Controls[k];
                                if ((ctrl3.GetType() == typeof(System.Windows.Forms.GroupBox)))
                                {
                                    if (ctrl3.Controls.Count >= 2)
                                    {
                                        for (int l = 0; l < ctrl3.Controls.Count; l++)
                                        {
                                            System.Windows.Forms.Control ctrl4 = ctrl3.Controls[l];

                                            if (ctrl4.GetType() == typeof(System.Windows.Forms.TextBox))
                                            {
                                                ctrl4.Text = string.Empty;
                                            }
                                            else if (ctrl4.GetType() == typeof(System.Windows.Forms.ComboBox))
                                            {
                                                ctrl4.Text = "[seleccione]";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static Control buscarTextoVacio(Form M, List<string> obviar)
        {
            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.GroupBox)))
                {
                    if (ctrl.Controls.Count >= 2)
                    {
                        for (int j = 0; j < ctrl.Controls.Count; j++)
                        {
                            System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];

                            int verifica = 0;

                            if (ctrl2.GetType() == typeof(System.Windows.Forms.TextBox))
                            {
                                if (obviar.Count > 0)
                                {
                                    foreach (var nombreControl in obviar)
                                    {
                                        if (ctrl2.Name == nombreControl)
                                        {
                                            verifica = 1;
                                        }
                                    }
                                }
                                if (verifica == 0)
                                {
                                    if (ctrl2.Text == string.Empty)
                                    {
                                        return ctrl2;
                                    }
                                }
                            }
                            else if (ctrl2.GetType() == typeof(System.Windows.Forms.ComboBox))
                            {
                                if (obviar.Count > 0)
                                {
                                    foreach (var nombreControl in obviar)
                                    {
                                        if (ctrl2.Name == nombreControl)
                                        {
                                            verifica = 1;
                                        }
                                    }
                                }
                                if (verifica == 0)
                                {
                                    if (ctrl2.Text == "[seleccione]")
                                    {
                                        return ctrl2;
                                    }
                                }
                            }

                            else if (ctrl2.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                            {
                                if (!(ctrl2.Name.Substring(ctrl2.Name.Length - 1) == "C"))
                                {
                                    if (ctrl2.Text == "  -  -  -  -  -")
                                    {
                                        return ctrl2;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return null;
        }

        public static Control buscarTextoVacioTabControl(Form M, int indice)
        {
            for (int i = 0; i < M.Controls.Count; i++)
            {
                System.Windows.Forms.Control ctrl = M.Controls[i];
                if ((ctrl.GetType() == typeof(System.Windows.Forms.TabControl)))
                {

                    for (int j = 0; j < ctrl.Controls.Count; j++)
                    {
                        if (j == indice)
                        {
                            System.Windows.Forms.Control ctrl2 = ctrl.Controls[j];
                            if ((ctrl2.GetType() == typeof(System.Windows.Forms.TabPage)))
                            {

                                for (int k = 0; k < ctrl2.Controls.Count; k++)
                                {
                                    System.Windows.Forms.Control ctrl3 = ctrl2.Controls[k];
                                    if ((ctrl3.GetType() == typeof(System.Windows.Forms.GroupBox)))
                                    {
                                        if (ctrl3.Controls.Count >= 2)
                                        {
                                            for (int l = 0; l < ctrl3.Controls.Count; l++)
                                            {
                                                System.Windows.Forms.Control ctrl4 = ctrl3.Controls[l];

                                                if (ctrl4.GetType() == typeof(System.Windows.Forms.TextBox))
                                                {
                                                    if (ctrl4.Text == string.Empty)
                                                    {
                                                        return ctrl4;
                                                    }
                                                }
                                                else if (ctrl4.GetType() == typeof(System.Windows.Forms.ComboBox))
                                                {
                                                    if (ctrl4.Text == "[seleccione]")
                                                    {
                                                        return ctrl4;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }

                }
            }
            return null;
        }
        #endregion

        public string mensajeError(int codigoError)
        {
            switch (codigoError)
            {
                case 2627:
                    return "No se puede insertar, el nombre ya se encuentra registrado, verifique o contacte con el administrador del sistema";
                case 547:
                    return "No se puede eliminar, el dato esta siendo usado en otro lado, verifique o contacte con el administrador del sistema";
                default:
                    return "Ha ocurrido un error no identificado, verifique o contacte con el administrador del sistema";
            }
        }
    }
}
