using DAO_SEVILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using System.Reflection;
using System.Resources;

namespace GUI_SEVILLA
{
    public partial class frmGeneraDeuda : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        public int IdAlumno { get; set; }
        public int? IdMatricula { get; set; }

        public frmGeneraDeuda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (lblNuevo.Text == "Nuevo")
            {
                Limpiar("Cancelar", true);
                btnGuardar.Enabled = true;

                btnNuevo.BackgroundImage = Properties.Resources.cancelar;
            }
            else if (lblNuevo.Text == "Cancelar")
            {
                string message = "Esta seguro de cancelar?" + Environment.NewLine +
                    "Si hay datos ingresados se van a perder.";
                string caption = VariablesGlobales.NombreMensajes;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Limpiar("Nuevo", false);
                    btnGuardar.Enabled = false;
                }
                btnNuevo.BackgroundImage = Properties.Resources.nuevo1_;
            }
        }

        private void Limpiar(string NombreBoton, bool estado)
        {
            lblNuevo.Text = NombreBoton;
            this.gbBuscarAlumno.Enabled = estado;
            this.gbCabeceraAlumno.Enabled = estado;
            this.dgvDetalle.Rows.Clear();
            this.dgvDetalle.Refresh();
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.00";
            cboConcepto.SelectedIndex = 0;
            txtFiltro.Clear();
            txtNombres.Clear();
            txtFiltro.Focus();
            IdMatricula = 0;
            IdAlumno = 0;
        }

        private void frmGeneraDeuda_Load(object sender, EventArgs e)
        {
            LlenarConceptos();
            this.ttMensaje.SetToolTip(this.btnAgregar, "Agrega un registro");
            this.ttMensaje.SetToolTip(this.btnLimpiar, "Eliminar todos los registros agregados");
            this.ttMensaje.SetToolTip(this.btnQuitar, "Eliminar un registro seleccionado");
        }

        private void LlenarConceptos()
        {
            cboConcepto.DataSource = cn.TraerDataset("USP_CONCEPTOLista", conectar.conexionbdSevilla).Tables[0];
            cboConcepto.DisplayMember = "DESCRIPCONCEPTO";
            cboConcepto.ValueMember = "IDCONCEPTO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtDatosAlumno = new DataTable();
            try
            {
                if (txtFiltro.Text.Trim() != "")
                {
                    dtDatosAlumno = cn.TraerDataset("USP_ALUMNOSearchMatriculados", conectar.conexionbdSevilla, txtFiltro.Text.Trim(),
                        VariablesGlobales.AnioEscolarLogueado,VariablesGlobales.AnioFaseEscolarLogueado,true,chkConceptosOtrosAnios.Checked).Tables[0];

                    if (chkConceptosOtrosAnios.Checked)
                    {
                        if (dtDatosAlumno.Rows.Count <= 0) { MessageBox.Show("El documento ingresado no existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                        
                        dtDatosAlumno = cn.TraerDataset("USP_ALUMNOSearch", conectar.conexionbdSevilla, txtFiltro.Text.Trim(),
                        VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, true).Tables[0];

                        if (dtDatosAlumno.Rows.Count <= 0)
                        {
                            MessageBox.Show("El documento ingresado no se encuentra asignado a ningun alumno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtFiltro.Focus();
                            IdAlumno = 0;
                            return;
                        }
                        txtNombres.Text = dtDatosAlumno.Rows[0][1].ToString();
                        IdAlumno = Convert.ToInt32(dtDatosAlumno.Rows[0][0]);
                        IdMatricula = 0;
                    }
                    else
                    {
                        if (dtDatosAlumno.Rows.Count <= 0)
                        {
                            MessageBox.Show("El documento ingresado no existe o no tiene asignado una matrícula.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNombres.Clear();
                            IdAlumno = 0;
                            return;
                        }
                        txtNombres.Text = dtDatosAlumno.Rows[0][2].ToString();
                        IdAlumno = Convert.ToInt32(dtDatosAlumno.Rows[0][1]);
                        IdMatricula = Convert.ToInt32(dtDatosAlumno.Rows[0][0]);
                    }                  
                }
                else
                {
                    MessageBox.Show("Ingrese el Nº de documento para la búsqueda.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFiltro.Focus();
                }
            }
            catch (Exception)
            {
            }

        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPrecio.Text = cn.TraerDataset("USP_CONCEPTOObtienePrecio", conectar.conexionbdSevilla, cboConcepto.SelectedValue).Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio;
            int cantidad;

            if (cboConcepto.SelectedIndex >= 0)
            {
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    if (int.TryParse(txtCantidad.Text, out cantidad))
                    {
                        if (Convert.ToInt32(txtCantidad.Text) > 0)
                        {
                            if (Convert.ToDecimal(txtPrecio.Text) > 0.00m)
                            {
                                foreach (DataGridViewRow rows in dgvDetalle.Rows)
                                {
                                    if (rows.Cells[0].Value.ToString() == cboConcepto.SelectedValue.ToString())
                                    {
                                        MessageBox.Show("El concepto "+ cboConcepto.Text + " ya fue ingresado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                                }
                                this.dgvDetalle.Rows.Add(cboConcepto.SelectedValue, cboConcepto.Text, txtPrecio.Text, txtCantidad.Text,
                                    Math.Round(Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text),2)).ToString("#,#.00#;(#,#.00#)");
                            }
                            else
                            {
                                MessageBox.Show("Precio tiene que ser mayor a cero (0.00)", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtPrecio.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cantidad tiene que ser mayor a cero.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCantidad.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor valido para la cantidad.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCantidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor valido para el precio.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecio.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un concepto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboConcepto.Focus();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                if (txtFiltro.Text != "")
                {
                    if (txtNombres.Text != "")
                    {
                        if (IdAlumno != 0)
                        {
                            string message = "Esta seguro de guardar la deuda?" + Environment.NewLine +
                              "Alumno : " + txtNombres.Text + Environment.NewLine +
                              "Nº de documento : " + txtFiltro.Text;
                            string caption = VariablesGlobales.NombreMensajes;
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                //VERIFICA SI EL CONCEPTO YA ESTA INGRESADO EN LA CUENTA CORRIENTE
                                //VERIFICAR EN EL CASO DE PAGO DE EXAMENES SI SE PUEDNE REPETIR EL CONCEPTO POR AÑO, EN ESE CASO PONER EL SP
                                //QUE SOLO VERIFIQUE OTROS CONCEPTOS.
                                foreach (DataGridViewRow item in dgvDetalle.Rows)
                                {
                                    if (cn.TraerDataset("USP_CUENTACORRIENTEVerificaDuplicidadConcepto",conectar.conexionbdSevilla,IdMatricula,
                                        Convert.ToInt32(item.Cells["IDCONCEPTO"].Value)).Tables[0].Rows.Count>0)
                                    {
                                        MessageBox.Show("El concepto " + item.Cells["CONCEPTO"].Value + " ya se encuentra registrado en el estado de deuda."  , VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                                }
                                foreach (DataGridViewRow item in dgvDetalle.Rows)
                                {
                                    cn.EjecutarSP("USP_CUENTACORRIENTEDeudaManual", conectar.conexionbdSevilla, IdMatricula==0 ? null:IdMatricula,
                                        Convert.ToInt32(item.Cells["IDCONCEPTO"].Value),txtPrecio.Text,dtpFechaRegistro.Value,VariablesGlobales.NombreUsuario,
                                        VariablesGlobales.UserHostIp,VariablesGlobales.AnioEscolarLogueado.ToString(),
                                        VariablesGlobales.AnioFaseEscolarLogueado,IdAlumno);                                   
                                }
                                MessageBox.Show("Concepto(s) registrado(s) correctamente.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un alumno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtFiltro.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el nombre del alumno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un documento de identidad.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFiltro.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese como mínimo un concepto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count <= 0) return;

            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
        }
    }
}
