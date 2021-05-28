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
    public partial class frmAgregarModalidadPago : MetroFramework.Forms.MetroForm
    {
        public DataTable dtModalidadPago { get; set; }
        public decimal ImportePago { get; set; }
        public decimal ImporteDocumento { get; set; }

        CNegocio cn = new CNegocio();

        public frmAgregarModalidadPago()
        {
            InitializeComponent();
        }

        private void frmAgregarModalidadPago_Load(object sender, EventArgs e)
        {            
            dgvModalidadesPago.DataSource = dtModalidadPago;
            acumulado();
            cargarModalidadPago();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();

            txtImportePago.Text = (0).ToString("###,###,##0.00");
            txtTipoCambio.Text = (1).ToString("###,###,##0.00");
            txtTotalCambioDolar.Text = (0).ToString("###,###,##0.00");
            txtNumDocumento.Text = "";
            CalcularSaldo();
        }

        private void CalcularSaldo()
        {
            txtTotalDocumento.Text = ImporteDocumento.ToString("###,###,##0.00");
            txtSaldoDocumento.Text = (ImporteDocumento - Convert.ToDecimal(txtTotal.Text)).ToString("###,###,##0.00");
        }
        private void cargarModalidadPago()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_modalidad_pago", conectar.conexionbdSevilla).Tables[0];
                cboModalidadPago.DataSource = dt;
                cboModalidadPago.DisplayMember = "desc_mod_Pago";
                cboModalidadPago.ValueMember = "cod_mod_pago";
            }
            catch (Exception)
            {
            }
        }
        private void cargarEntidadFinanciera()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("USP_ENTIDADFINANCIERASelectAll", conectar.conexionbdSevilla).Tables[0];
                cboEntidadFinanciera.DataSource = dt;
                cboEntidadFinanciera.DisplayMember = "nombre_entidad";
                cboEntidadFinanciera.ValueMember = "cod_entidad_financ";
            }
            catch (Exception)
            {
            }
        }
        private void cargarCuentaBancaria()
        {
            cboCuenta.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(cboModalidadPago.SelectedValue)==1 || Convert.ToInt32(cboModalidadPago.SelectedValue) == 11 ||
            //    Convert.ToInt32(cboModalidadPago.SelectedValue) == 19 || Convert.ToInt32(cboModalidadPago.SelectedValue) == 20)
            //{
            //    MessageBox.Show("La modalidad de pago ingresa no esta permitida.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
            //                        MessageBoxIcon.Warning);
            //    return;
            //}
            if ((MessageBox.Show("¿Esta seguro de agregar una nueva modalidad de pago?", VariablesGlobales.NombreMensajes,
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                DataRow _filaModalidadPago = dtModalidadPago.NewRow();

                if (!Validar())
                {
                    return;
                }

                _filaModalidadPago["cod_mod_pago"] = cboModalidadPago.SelectedValue;
                _filaModalidadPago["desc_mod_Pago"] = cboModalidadPago.Text;
                _filaModalidadPago["concep_cod"] = "03";
                _filaModalidadPago["FechaDeposito"] = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                _filaModalidadPago["cod_entidad_financ"] = Convert.ToInt32(cboEntidadFinanciera.SelectedValue)==0 ? "": cboEntidadFinanciera.SelectedValue;
                _filaModalidadPago["Nombre_Entidad"] = Convert.ToInt32(cboEntidadFinanciera.SelectedValue) == 0 ? "" : cboEntidadFinanciera.Text;
                _filaModalidadPago["cuenta_bancaria_id"] = Convert.ToInt32(cboCuenta.SelectedValue)==0 ? "": cboCuenta.SelectedValue;
                _filaModalidadPago["numero_cuenta"] = Convert.ToInt32(cboCuenta.SelectedValue) == 0 ? "" : cboCuenta.Text;
                _filaModalidadPago["importe_voucher_pago"] = txtImportePago.Text;
                _filaModalidadPago["TipoCambio"] = txtTipoCambio.Text;
                _filaModalidadPago["importe_cambio"] = txtTotalCambioDolar.Text;
                _filaModalidadPago["NumeroDocumento_Voucher_cheque_pago"] = txtNumDocumento.Text;
                _filaModalidadPago["ObservacionPago"] = txtObservacionesPago.Text;

                dtModalidadPago.Rows.Add(_filaModalidadPago);
                dgvModalidadesPago.DataSource = dtModalidadPago;
                varGlobales.resetearCampos(this);
                acumulado();
                CalcularSaldo();
                txtImportePago.Text = "0.00";
                txtTipoCambio.Text = "1.00";
                txtTotalCambioDolar.Text = "0.00";
            }
        }

        bool Validar()
        {
            bool flag = true;
           
            if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una modalidad de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                flag = false;
                return false;
            }

            if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 19)
            {
                MessageBox.Show("Su caja no puede generar documento PENDIENTES DE COBRO.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                flag = false;
                return false;
            }

            if (Convert.ToDecimal(txtSaldoDocumento.Text) == 0.00m)
            {
                MessageBox.Show("Ya no hay saldo suficiente para agregar mas modalidades de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                flag = false;
                return false;
            }

            DataTable dtGenerico = new DataTable();
            dtGenerico = cn.EjecutarSqlDTS("select descripcionTipo from BDTESORERIA.dbo.tb_tipo_modalidad_pago where idTipo in (select idTipo from BDTESORERIA.dbo.ta_modalidad_pago where cod_mod_Pago=" + Convert.ToInt16(cboModalidadPago.SelectedValue).ToString("00") + ")", conectar.conexionbdSevilla).Tables[0];
            if (dtGenerico.Rows[0][0].ToString() == "EFECTIVO")
            {
                if ((int)cboEntidadFinanciera.SelectedValue != 0)
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        MessageBox.Show("La modalidad de pago seleccionada no tiene relacion con la entidad bancaria seleccionada.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        cboCuenta.Focus();
                        flag = false;

                    }
                    else
                    {
                        if ((int)cboCuenta.SelectedValue != 0)
                        {
                            MessageBox.Show("Ha seleccionado EFECTIVO y no puede seleccionar una cuenta bancaria.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            cboCuenta.Focus();
                            flag = false;
                        }
                        else
                        {
                            if (Convert.ToDecimal(txtImportePago.Text) != 0)
                            {
                                MessageBox.Show("Este importe de pago es para solo DEPOSITOS u otras modalidades de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                                txtImportePago.Focus();
                                flag = false;
                            }
                            else
                            {
                                if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                {
                                    MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                                else
                                {
                                    if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                    {
                                        MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                        txtTotalCambioDolar.Focus();
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (txtNumDocumento.Text.Trim() != "")
                                        {
                                            MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                            txtNumDocumento.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                            txtObservacionesPago.Focus();
                                            flag = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (lblTipoMoneda.Text != "S/.")
                    {
                        if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                        {
                            MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                            txtTipoCambio.Focus();
                            flag = false;
                        }
                        else
                        {
                            if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                            {
                                MessageBox.Show("Ingrese un importe correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                                txtImportePago.Focus();
                                flag = false;
                            }
                        }
                    }
                    else
                    {
                        if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                        {
                            MessageBox.Show("Debe ingresar el importe de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                            txtImportePago.Focus();
                            flag = false;
                        }
                        else
                        {
                            if (txtNumDocumento.Text.Trim() != "")
                            {
                                MessageBox.Show("El numero de documento de pago no debe contener valores.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                                txtNumDocumento.Focus();
                                flag = false;
                            }
                        }
                    }
                }
            }
            else if (dtGenerico.Rows[0][0].ToString() == "DEPOSITO" || dtGenerico.Rows[0][0].ToString() == "ABONO EN CUENTA" || dtGenerico.Rows[0][0].ToString() == "TRANSFERENCIA" || dtGenerico.Rows[0][0].ToString() == "CHEQUE")
            {
                if ((int)cboEntidadFinanciera.SelectedValue != 0)
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        if ((int)cboCuenta.SelectedValue != 0)
                        {
                            if (Convert.ToDecimal(txtImportePago.Text) != 0)
                            {
                                if (lblTipoMoneda.Text != "S/.")
                                {
                                    if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                                    {
                                        MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                        txtTipoCambio.Focus();
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                        {
                                            if (txtNumDocumento.Text.Trim() != "")
                                            {

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese el Número de documento.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                                txtNumDocumento.Focus();
                                                flag = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El importe total de cambio es incorrecto, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                            txtTotalCambioDolar.SelectAll();
                                            flag = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                    {
                                        MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                        txtTipoCambio.Focus();
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                        {
                                            if (txtNumDocumento.Text.Trim() != "")
                                            {

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese el Número de documento.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                                txtNumDocumento.Focus();
                                                flag = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El importe total de cambio es incorrecto, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                            txtTotalCambioDolar.Focus();
                                            flag = false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese el importe de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                                txtImportePago.Focus();
                                flag = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione el Nro de cuenta.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                            cboCuenta.Focus();
                            flag = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        cboEntidadFinanciera.Focus();
                        flag = false;
                    }
                }
                else
                {
                    if (dtGenerico.Rows[0][0].ToString() == "CHEQUE")
                    {
                        if (lblTipoMoneda.Text != "S/.")
                        {
                            if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                            {
                                MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                txtTipoCambio.Focus();
                                flag = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una entidad bancaria.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                        cboEntidadFinanciera.Focus();
                        flag = false;
                    }
                }
            }
            else if (cboModalidadPago.SelectedIndex != 0)
            {
                DataTable dtGenerico2 = new DataTable();

                dtGenerico2 = cn.EjecutarSqlDTS("select descripcionTipo from tb_tipo_modalidad_pago where idTipo in (select idTipo from ta_modalidad_pago where cod_mod_Pago=" + cboModalidadPago.SelectedValue + ")", conectar.conexionbdSevilla).Tables[0];
                if (dtGenerico2.Rows[0][0].ToString() == "EFECTIVO")
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        if ((int)cboEntidadFinanciera.SelectedValue != 0)
                        {
                            MessageBox.Show("Ha seleccionado EFECTIVO y no puede seleccionar una entidad bancaria", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            cboCuenta.Focus();
                            flag = false;

                        }
                        else
                        {
                            if ((int)cboCuenta.SelectedValue != 0)
                            {
                                MessageBox.Show("Ha seleccionado EFECTIVO y no puede seleccionar una cuenta bancaria.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                cboCuenta.Focus();
                                flag = false;
                            }
                            else
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) != 0)
                                {
                                    MessageBox.Show("Este importe de pago es para solo DEPOSITOS u otras modalidades de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                                else
                                {
                                    if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                    {
                                        MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                        txtImportePago.Focus();
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                        {
                                            MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                            txtTotalCambioDolar.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (txtNumDocumento.Text.Trim() != "")
                                            {
                                                MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                                txtNumDocumento.Focus();
                                                flag = false;
                                            }
                                            else
                                            {
                                                MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                                txtObservacionesPago.Focus();
                                                flag = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (lblTipoMoneda.Text != "S/.")
                        {
                            if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                            {
                                MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                txtTipoCambio.Focus();
                                flag = false;
                            }
                            else
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                                {
                                    MessageBox.Show("Ingrese un importe correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                            {

                            }
                            else
                            {
                                if (txtNumDocumento.Text.Trim() != "")
                                {
                                    MessageBox.Show("El numero de documento de pago no debe contener valores.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                    txtNumDocumento.Focus();
                                    flag = false;
                                }
                            }
                        }
                    }
                }
                else if (dtGenerico2.Rows[0][0].ToString() == "DEPOSITO" || dtGenerico2.Rows[0][0].ToString() == "ABONO EN CUENTA" || dtGenerico2.Rows[0][0].ToString() == "TRANSFERENCIA" || dtGenerico2.Rows[0][0].ToString() == "CHEQUE")
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        if ((int)cboEntidadFinanciera.SelectedValue != 0)
                        {
                            if ((int)cboCuenta.SelectedValue != 0)
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) != 0)
                                {
                                    if (lblTipoMoneda.Text != "S/.")
                                    {
                                        if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                                        {
                                            MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                            txtTipoCambio.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                            {
                                                if (txtNumDocumento.Text.Trim() != "")
                                                {

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese el Número de documento.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                    txtNumDocumento.Focus();
                                                    flag = false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El importe total de cambio es incorrecto, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                txtTotalCambioDolar.SelectAll();
                                                flag = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                        {
                                            MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                            txtTipoCambio.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                            {
                                                if (txtNumDocumento.Text.Trim() != "")
                                                {

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese el Número de documento.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                    txtNumDocumento.Focus();
                                                    flag = false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El importe total de cambio es incorrecto, verifique.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                txtTotalCambioDolar.Focus();
                                                flag = false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese el importe de pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione el Nro de cuenta.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                                cboCuenta.Focus();
                                flag = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                            cboEntidadFinanciera.Focus();
                            flag = false;
                        }
                    }
                    else
                    {
                        if (dtGenerico2.Rows[0][0].ToString() == "CHEQUE")
                        {
                            if (lblTipoMoneda.Text != "S/.")
                            {
                                if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                                {
                                    MessageBox.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                                    txtTipoCambio.Focus();
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una entidad bancaria.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                            cboEntidadFinanciera.Focus();
                            flag = false;
                        }
                    }
                }
            }
            return flag;
        }

        private void cboEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = new DataTable();
                try
                {
                    dt = cn.TraerDataset("USP_CUENTABANCARIASelectAll", conectar.conexionbdSevilla, cboEntidadFinanciera.SelectedValue.ToString() == "System.Data.DataRowView" ? "0" : cboEntidadFinanciera.SelectedValue).Tables[0];
                    cboCuenta.Refresh();
                    cboCuenta.DataSource = dt;
                    cboCuenta.DisplayMember = "numero_cuenta";
                    cboCuenta.ValueMember = "cuenta_bancaria_id";

                    if (cboEntidadFinanciera.Text == "DE LA NACION")
                    {
                        cboCuenta.SelectedValue = 85;
                    }
                    if (cboEntidadFinanciera.Text == "BBVA CONTINENTAL")
                    {
                        cboCuenta.SelectedValue = 125;
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesGlobales.NombreMensajes,
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {

            }
        }

        private void cboModalidadPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 0)
                {
                    cboEntidadFinanciera.SelectedValue = 0;
                }

                DataSet dsetMonedaModPago = new DataSet();
                int idModPago = Convert.ToInt32(cboModalidadPago.SelectedValue);
                txtImportePago.Text = "0.00";
                txtTipoCambio.Text = "1.00";
                txtTotalCambioDolar.Text = "0.00";
                txtNumDocumento.Clear();
                dsetMonedaModPago = cn.TraerDataset("usp_obtiene_abreviatura_moneda_modPago", conectar.conexionbdSevilla, idModPago);

                if (Convert.ToInt32(dsetMonedaModPago.Tables[0].Rows[0][0]) == 2)
                {
                    DataSet dtsValorDolar = new DataSet();

                    dtsValorDolar = cn.TraerDataset("usp_s_tb_tipoCambioDolar_valor", conectar.conexionbdSevilla);
                    if (dtsValorDolar.Tables[0].Rows.Count > 0)
                    {
                        txtTipoCambio.Text = Convert.ToDecimal(dtsValorDolar.Tables[0].Rows[0][0]).ToString("##0.000");
                        lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                    }
                    else
                    {
                        lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                        txtTipoCambio.Text = "1.000";
                    }
                }
                else
                {
                    lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                    txtTipoCambio.Text = "1.000";
                }
                cboEntidadFinanciera.SelectedValue = 0;
            }
            catch (Exception)
            {
            }
        }

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTotalCambioDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtImportePago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("¿Esta seguro de eliminar el registro seleccionado?", VariablesGlobales.NombreMensajes,
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    if (dgvModalidadesPago.RowCount > 0)
                    {
                        dgvModalidadesPago.Rows.RemoveAt(dgvModalidadesPago.CurrentRow.Index);

                        acumulado();
                    }
                    else if (dgvModalidadesPago.RowCount > 0)
                    {
                        dgvModalidadesPago.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No existe datos para eliminar", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    dgvModalidadesPago.Refresh();
                    acumulado();
                    CalcularSaldo();
                }
            }
            catch (Exception)
            {
            }
        }

        private void acumulado()
        {
            try
            {
                decimal tot = 0.00m;

                for (int i = 0; i < dgvModalidadesPago.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(dgvModalidadesPago.Rows[i].Cells[8].Value);
                }
                txtTotal.Text = (tot+ImportePago).ToString("##,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
