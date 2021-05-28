using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string rutaLecturaArchivos;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Drawing.Image img = System.Drawing.Image.FromFile(@"D:\BBVA\Convertion estructura BBVA\GUI_BBVA_TXT\Uploads\logobn.png", true);

            //Convertir_Imagen_Bytes(img);
            this.Close();
        }
        CNegocio cn = new CNegocio();

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                label10.Text = @"C:\BBVA\DeudaSevilla" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                cboMoneda.SelectedIndex = 0;
                cboTipoFacturacion.SelectedIndex = 0;
                txtNombreArchivo.Text = ObtieneNombreArchivo();
                AsignaRutaLectura();
                txtVersion.Text = cn.TraerDataset("USP_GENERACION_VERSION_BANCO", conectar.conexionbdSevilla,dtpFechaFacturacion.Value.ToString("yyyyMMdd")).Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AsignaRutaLectura()
        {
            if (cboMoneda.Text == "USD")
            {
                rutaLecturaArchivos = @"C:\BBVA\DeudaSevilla" + DateTime.Now.ToString("yyyyMMdd")+".txt";
            }
            else if (cboMoneda.Text == "PEN")
            {
                rutaLecturaArchivos = @"C:\BBVA\DeudaSevilla" + DateTime.Now.ToString("yyyyMMdd")+".txt";
            }

            lblArchivo.Text = rutaLecturaArchivos;
        }

        private string ObtieneNombreArchivo()
        {
            return "INSTITUTO_SEVILLA_SBLM_" + cboMoneda.Text + "_" + FechaFormatoAAAAMMDD(dtpFechaFacturacion.Value.ToShortDateString()) + ".TXT";
        }
        private string FechaFormatoAAAAMMDD(string fecha)
        {
            string fechaFacturacion = "";
            string anio = "";
            string mes = "";
            string dia = "";

            fechaFacturacion = dtpFechaFacturacion.Value.ToString("dd/MM/yyyy");
            anio = fechaFacturacion.Substring(6, 4);
            mes = fechaFacturacion.Substring(3, 2);
            dia = fechaFacturacion.Substring(0, 2);

            fecha = anio + mes + dia;

            return fecha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            int Tamanocabecera = 0;
            string[] A = new string[10] { "Ä", "Á", "À", "á", "à", "Ã", "ã", "â", "Â", "ä" };
            string[] E = new string[9] { "Ë", "É", "È", "é", "è", "ê", "Ê", "â", "ë" };
            string[] I = new string[8] { "í", "Ì", "Í", "Ï", "ì", "î", "Î", "ï" };
            string[] O = new string[11] { "õ", "Õ", "ò", "ó", "ó", "Ó", "Ò", "Ô", "ô", "ö", "Ö" };
            string[] U = new string[8] { "û", "ù", "Ù", "ú", "Ú", "Ü", "Û", "ü" };
            string[] N = new string[3] { "±", "Ñ", "ñ"};
            string[] Y = new string[3] { "ÿ", "ý", "Ý" };
            string[] D = new string[2] { "Ð.", "Ð" };
            string[] ESPACIO = new string[33] { "\"\"", ";", ",", "+", "!", "#", "$", "%", "/", "(", "\\", "¡", "¿", "'", "`", "~", "[", "}", "]", "<", ">", "_", ")", "{", "^", ":", "|", "¬", "=", "?", "°", "º", "´" };

            string fechaFacturacion = "";
            int cuenta;
            cuenta = 0;
            fechaFacturacion = dtpFechaFacturacion.Value.ToString("dd/MM/yyyy");

            try
            {
                //Inicio generacion de cabecera de archivo primera fila
                string cabecera = @"01" + txtRuc.Text.Trim().ToString() + txtNroClase.Text.Trim().ToString() + cboMoneda.Text.ToString()
                    + FechaFormatoAAAAMMDD(fechaFacturacion) + txtVersion.Text.Trim() + "       " + cboTipoFacturacion.Text.Trim();
                StringBuilder DetalleSb = new StringBuilder();
                cabecera = cabecera.Trim();                           

                for (int i = 1; i < 323; i++)
                {
                    cabecera = cabecera + " ";
                }
                Tamanocabecera = cabecera.Length;

                if (Tamanocabecera != 360)
                {
                    MessageBox.Show("La cabecera no cumple con el tamaño de 360 caracteres, verificar!!");
                    return;
                }

                DetalleSb.AppendLine(cabecera);

                using (StreamReader lector = new StreamReader(rutaLecturaArchivos, System.Text.Encoding.UTF8, false))
                {
                    decimal sumaMaximo = 0;
                    decimal sumaMinimo = 0;
                    int tamanoNombreCliente = 0;//30
                    int tamanoCodigo = 0;//48
                    int tamanoFechaVencimiento = 0;//8
                    int tamanoFechaBloqueo = 0;//8
                    int tamanoPeriodoFacturado = 0;//2
                    int tamanoImporteMaximo = 0;//15
                    int tamanoImporteMinimo = 0;//15
                    int tamanoInformacionAdicional = 0;//32
                    int tamanoVacio = 0;//72
                    int contador = 0;
                    
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        int tamanoLinea = 0;
                        string lineaNueva = "";
                        string lineaNueva2 = "";
                        string detalle = "";
                        Char delimiter = '*';

                        if (!String.IsNullOrEmpty(linea))
                        {
                            //linea = "ARENAZA AVILES VIRGINIA*01-0174-001*MES: 03-2016-MATIAS MAESTRO Nro.114*31/03/2016*31/12/2050*63.45*63.45";
                            //contador++;

                            tamanoLinea = linea.Length;

                            for (int i = 0; i < tamanoLinea; i++)
                            {
                                lineaNueva = linea.Substring(i, 1);

                                for (int a = 0; a < A.Length; a++)
                                {
                                    if (A[a].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"A";
                                    }
                                }
                                for (int e_ = 0; e_ < E.Length; e_++)
                                {
                                    if (E[e_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"E";
                                    }
                                }
                                for (int i_ = 0; i_ < I.Length; i_++)
                                {
                                    if (I[i_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"I";
                                    }
                                }
                                for (int o_ = 0; o_ < O.Length; o_++)
                                {
                                    if (O[o_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"O";
                                    }
                                }
                                for (int u_ = 0; u_ < U.Length; u_++)
                                {
                                    if (U[u_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"U";
                                    }
                                }
                                for (int n_ = 0; n_ < N.Length; n_++)
                                {
                                    if (N[n_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"N";
                                    }
                                }
                                for (int y_ = 0; y_ < Y.Length; y_++)
                                {
                                    if (Y[y_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"Y";
                                    }
                                }
                                for (int d_ = 0; d_ < D.Length; d_++)
                                {
                                    if (D[d_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @"D";
                                    }
                                }
                                for (int espa_ = 0; espa_ < ESPACIO.Length; espa_++)
                                {
                                    if (ESPACIO[espa_].ToString() == lineaNueva)
                                    {
                                        lineaNueva = @" ";
                                    }
                                }
                                lineaNueva2 = lineaNueva2 + lineaNueva;
                            }

                            String[] substrings = lineaNueva2.Split(delimiter);

                            if (substrings[0].Length > 30)
                            {
                                substrings[0] = substrings[0].Substring(0, substrings[2].Length > 30 ? 30 : substrings[2].Length);
                            }

                            substrings[0] = substrings[0];
                            tamanoNombreCliente = substrings[0].Trim().Length; //30

                            substrings[1] = substrings[1].Replace("-","").Trim();
                            substrings[2] = substrings[2].Substring(0, 3) + substrings[2].Substring(4, substrings[2].Length-4);
                            substrings[2] = substrings[2].Replace("-", " ").Replace("."," ");
                            tamanoCodigo = (substrings[1].ToString().Replace("-","").Trim().ToString() + substrings[2].Substring(0, substrings[2].Length>39 ? 39 : substrings[2].Length).Trim()).Length;//48

                            substrings[1] = substrings[1].ToString().Replace("-", "").Trim().ToString() + substrings[2].Substring(0, substrings[2].Length > 39 ? 39 : substrings[2].Length).Trim();

                            substrings[1] = substrings[1].Replace(".", " ").Replace("-", "");
                            substrings[1] = substrings[1].Substring(0,8)+ substrings[1].Substring(8, 11) + " " +substrings[1].Substring(20, substrings[1].Length-20);

                            tamanoCodigo = substrings[1].Length;

                            tamanoFechaVencimiento = (substrings[3] = substrings[3].Substring(6, 4) + substrings[3].Substring(3, 2) + substrings[3].Substring(0, 2)).Length;//8
                            tamanoFechaBloqueo = (substrings[4] = substrings[4].Substring(6, 4) + substrings[4].Substring(3, 2) + substrings[4].Substring(0, 2)).Length;//8
                            tamanoPeriodoFacturado = 2;//substrings[2].Substring(5, 2).Trim().Length;//2
                            sumaMaximo = sumaMaximo + Convert.ToDecimal(substrings[6]);
                            sumaMinimo = sumaMinimo + Convert.ToDecimal(substrings[5]);
                            tamanoImporteMaximo = RellenaMonto(substrings[5].Trim(),15).Length;//15
                            tamanoImporteMinimo = RellenaMonto(substrings[6].Trim(),15).Length;//15

                            tamanoInformacionAdicional = 32;

                            tamanoVacio = 52;

                            contador = contador + 1;

                            if (tamanoNombreCliente <= 30)
                            {
                                tamanoNombreCliente = 30 - tamanoNombreCliente;
                                substrings[0] = substrings[0].Trim();

                                for (int i = 1; i <= tamanoNombreCliente; i++)
                                {
                                    substrings[0] = substrings[0] + " ";
                                }
                                
                                substrings[0] = substrings[0].Replace(".", " ");
                            }
                            if (tamanoCodigo <= 48)
                            {
                                substrings[1] = substrings[1].ToString().Replace("-", "").Trim();

                                tamanoCodigo = substrings[1].Length;

                                tamanoCodigo = 48 - tamanoCodigo;

                                for (int i = 1; i <= tamanoCodigo; i++)
                                {
                                    substrings[1] = substrings[1] + " ";
                                }
                            }
                            if (tamanoFechaVencimiento != 8)
                            {
                                MessageBox.Show("Error en el tamano de la de la fecha de vencimiento. Fila ->" + contador);
                                return;
                            }
                            else
                            {
                                substrings[3] = substrings[3];
                            }
                            if (tamanoFechaBloqueo != 8)
                            {
                                MessageBox.Show("Error en el tamano de la de la fecha de vencimiento. Fila ->" + contador);
                                return;
                            }
                            else
                            {
                                substrings[4] = substrings[4];
                            }
                            if (tamanoPeriodoFacturado != 2)
                            {
                                MessageBox.Show("Error en el tamano del periodo. Fila ->" + contador);
                                return;
                            }
                            else
                            {
                                substrings[2] = "00";//substrings[2].Substring(5, 2).Trim();
                            }
                            if (tamanoImporteMaximo != 15)
                            {
                                MessageBox.Show("Error en el tamano del importe maximo. Fila ->" + contador);
                                return;
                            }
                            else
                            {
                                substrings[5] = RellenaMonto(DoFormat(Convert.ToDecimal(substrings[5])).ToString().Trim(), 15);
                            }

                            if (tamanoImporteMinimo != 15)
                            {
                                MessageBox.Show("Error en el tamano del importe minimo. Fila ->" + contador);
                                return;
                            }
                            else
                            {
                                substrings[6] = RellenaMonto(DoFormat(Convert.ToDecimal(substrings[6])).ToString().Trim(),15);
                            }

                            string informaAdiiconal = "";

                            for (int i = 0; i < tamanoInformacionAdicional; i++)
                            {
                                informaAdiiconal = informaAdiiconal + "0";
                            }

                            string CodSc1 = "00";
                            string ValorCodSc1 = "00000000000000";

                            string CodSc2 = "00";
                            string ValorCodSc2 = "00000000000000";

                            string CodSc3 = "00";
                            string ValorCodSc3 = "00000000000000";

                            string CodSc4 = "00";
                            string ValorCodSc4 = "00000000000000";

                            string CodSc5 = "00";
                            string ValorCodSc5 = "00000000000000";

                            string CodSc6 = "00";
                            string ValorCodSc6 = "00000000000000";

                            string CodSc7 = "00";
                            string ValorCodSc7 = "00000000000000";

                            string CodSc8 = "00";
                            string ValorCodSc8 = "00000000000000";


                            string Vacio = "00000000000000000000";

                            for (int i = 0; i < tamanoVacio; i++)
                            {
                                Vacio = Vacio + " ";
                            }

                            detalle = "02" + substrings[0].ToString() + substrings[1].ToString() + substrings[3].ToString()
                                + substrings[4].ToString() + substrings[2].ToString() + substrings[6].ToString() + substrings[5].ToString()
                                + informaAdiiconal.ToString() + CodSc1.ToString() + ValorCodSc1.ToString() + CodSc2.ToString() + ValorCodSc2.ToString()
                                + CodSc3.ToString() + ValorCodSc3.ToString() + CodSc4.ToString() + ValorCodSc4.ToString()
                                + CodSc5.ToString() + ValorCodSc5.ToString() + CodSc6.ToString() + ValorCodSc6.ToString()
                                + CodSc7.ToString() + ValorCodSc7.ToString() + CodSc8.ToString() + ValorCodSc8.ToString() + Vacio.ToString();

                            if (detalle.Length != 360)
                            {
                                MessageBox.Show("hay un error en el tamaño de la fila, debe ser de tamaño 360 caracteres pero tiene " + detalle.Length + " Fila-> " + contador);
                                return;
                            }
                           
                            DetalleSb.AppendLine(detalle);
                            cuenta = cuenta + 1;
                        }
                    }

                    string pie = @"03" + contador.ToString("000000000") + RellenaMonto(DoFormat(Convert.ToDecimal(sumaMaximo)).ToString(), 18)
                        + RellenaMonto(DoFormat(Convert.ToDecimal(sumaMinimo)).ToString(), 18) + "000000000000000000";

                    pie = pie.Trim();

                    for (int i = 0; i < 295; i++)
                    {
                        pie = pie + " ";
                    }

                    DetalleSb.AppendLine(pie);

                    using (StreamWriter outfile = new StreamWriter(mydocpath + @"\"+txtNombreArchivo.Text.Trim()))
                    {
                        outfile.Write(DetalleSb.ToString());
                    }

                    cn.EjecutarSP("USP_INSERTA_VERSION", conectar.conexionbdSevilla,dtpFechaFacturacion.Value.ToString("yyyyMMdd"));

                    btnActualizaVersion_Click(sender,e);

                    MessageBox.Show("Se genero el archivo correctamente -> " + mydocpath + @"\" + txtNombreArchivo.Text.Trim(),"BBVA",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }//FIN USING StreamReader
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fila :"+cuenta +" " + ex.Message,"BBVA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static string DoFormat(decimal myNumber)
        {
            return string.Format("{0:0.00}", myNumber);
        }

        private string RellenaMonto(string monto,int longitud)
        {
            monto = monto.Replace(".", "");
            int tamanoMonto = longitud - monto.Length;

            for (int i = 1; i <= tamanoMonto; i++)
            {
                monto = "0" + monto;
            }

            return monto;
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtNombreArchivo.Text=  ObtieneNombreArchivo();
            AsignaRutaLectura();
            if (cboMoneda.Text=="USD")
            {
                txtNroClase.Text = "100";
            }
            else
            {
                txtNroClase.Text = "400";
            }
        }

        private void dtpFechaFacturacion_ValueChanged(object sender, EventArgs e)
        {
            txtNombreArchivo.Text = ObtieneNombreArchivo();
            lblArchivo.Text = @"C:\BBVA\DeudaSevilla" + dtpFechaFacturacion.Value.ToString("yyyyMMdd") + ".txt";
            label10.Text = @"C:\BBVA\DeudaSevilla" + dtpFechaFacturacion.Value.ToString("yyyyMMdd") + ".txt";
        }

        private void btnActualizaVersion_Click(object sender, EventArgs e)
        {
            try
            {
                txtVersion.Text = cn.TraerDataset("USP_GENERACION_VERSION_BANCO", conectar.conexionbdSevilla, dtpFechaFacturacion.Value.ToString("yyyyMMdd")).Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
