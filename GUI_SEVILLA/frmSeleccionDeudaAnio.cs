using DAO_SEVILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmSeleccionDeudaAnio : MetroFramework.Forms.MetroForm
    {
        public frmSeleccionDeudaAnio()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        int anio_deuda;
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtAnio.Text, out anio_deuda))
                {
                    if (!Directory.Exists(@"C:\BBVA"))
                    {
                        Directory.CreateDirectory(@"C:\BBVA");
                    }

                    DataTable TablaDatos = new DataTable();

                    TablaDatos = cn.TraerDataset("USP_DEUDA_TOTAL_MENSUAL_BANCOS", conectar.conexionbdSevilla,
                        txtAnio.Text).Tables[0];
                    
                    if (TablaDatos.Rows.Count<=0)
                    {
                        MessageBox.Show("No hay datos para mostrar.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        return;
                    }

                    int rowcount = TablaDatos.Rows.Count;

                    TextWriter sw = new StreamWriter($@"C:\BBVA\DeudaSevilla" + DateTime.Now.ToString("yyyyMMdd") + ".txt");

                    for (int i = 0; i < rowcount; i++)
                    {
                        sw.WriteLine(TablaDatos.Rows[i][0].ToString());
                    }

                    sw.Close();

                    MessageBox.Show(@"Archivo deudas Exportados correctamente a TXT en la ruta C:\BBVA", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese un Año válido.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    txtAnio.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
