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

namespace GUI_SEVILLA
{
    public partial class frmMotivoAnulacion : MetroFramework.Forms.MetroForm
    {
        public int Id_Comprobante_Anular { get; set; }
        public string NroDocumento { get; set; }
        public string TipoDocu { get; set; }

        CNegocio cn = new CNegocio();

        public frmMotivoAnulacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivo.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Ingrese el motivo de anulación.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMotivo.Focus();
                return;
            }

            if (txtMotivo.Text.Trim().Length <= 15)
            {
                MessageBox.Show("Debe ingresar un motivo más descriptivo, para ello, le pedimos ingresar un mínimo de 15 caracteres.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMotivo.Focus();
                return;
            }          

            string message = "¿Está seguro de proceder con la anulación del documento?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, VariablesGlobales.NombreMensajes, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (Convert.ToInt32(cn.TraerDataset("USP_RECIBOANULA", conectar.conexionbdSevilla, Id_Comprobante_Anular,VariablesGlobales.NombreUsuario,
                    VariablesGlobales.UserHostIp, txtMotivo.Text.Trim()).Tables[0].Rows[0][0]) > 0)
                {
                    MessageBox.Show("Documento Anulado correctamente",VariablesGlobales.NombreMensajes,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un Error, intente de nuevo o contacte con sistemas.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmMotivoAnulacionDocElect_Load(object sender, EventArgs e)
        {
            lblNombreNroDocumento.Text = TipoDocu+ " Nº " + NroDocumento;
        }
    }
}
