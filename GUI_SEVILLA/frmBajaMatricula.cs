using BL_SEVILLA;
using DAO_SEVILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    public partial class frmBajaMatricula : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public int IdMatricula { get; set; }

        public frmBajaMatricula()
        {
            InitializeComponent();
        }

        private void frmBajaMatricula_Load(object sender, EventArgs e)
        {
            CargarMotivos();
        }

        private void CargarMotivos()
        {
            cboMotivoBaja.DataSource = cn.TraerDataset("USP_MOTIVOBAJASelectAll",conectar.conexionbdSevilla).Tables[0];
            cboMotivoBaja.DisplayMember = "DESCRIPCIONMOTIVOBAJA";
            cboMotivoBaja.ValueMember = "IDMOTIVOBAJA";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro de dar de baja las deudas?" + Environment.NewLine + 
                Environment.NewLine + 
                "Una vez realizado la baja ya no se podra anular la transacción." + Environment.NewLine +
                "Anulado por el motivo de " + cboMotivoBaja.Text+"." + Environment.NewLine +
                "Se anularan las cuentas pendientes con fecha de vencimiento mayores o igual al "+ dtpFechaRegistro.Value.ToShortDateString() +Environment.NewLine+
                Environment.NewLine +
                "Si quiere seguir con la baja presione el boton de confirmación.";
            string caption = VariablesGlobales.NombreMensajes;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (cn.TraerDataset("USP_MATRICULADarDeBaja",conectar.conexionbdSevilla,IdMatricula,cboMotivoBaja.SelectedValue,
                    dtpFechaRegistro.Value,txtObservaciones.Text,VariablesGlobales.NombreUsuario,
                    VariablesGlobales.UserHostIp,(rbTodos.Checked ? "TO" : (rbPensiones.Checked ? "PE" : "OC"))).Tables[0].Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Se dio de baja correctamente la matrícula.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la baja de la matrícula.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
