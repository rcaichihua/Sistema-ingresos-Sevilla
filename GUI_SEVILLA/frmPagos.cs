﻿using BL_SEVILLA;
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
    public partial class frmPagos : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        DataTable cabeceraRecibo;
        DataTable detalleRecibo;
        DataTable modalidadesPago;

        public frmPagos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnNuevo,"Nuevo pago");
            this.ttMensaje.SetToolTip(this.btnSalir, "Cerrar la ventana");
            this.ttMensaje.SetToolTip(this.btnSalir, "Guardar pago");
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (lblNuevo.Text == "Nuevo")
            {
                Limpiar("Cancelar", true);
                btnGuardar.Enabled = true;
                cboFormaPago.SelectedIndex = 0;
                cboTipoDocumento.SelectedIndex = 0;
                txtDatos.Focus();
                txtNumeroDocumento.Text = cn.EjecutarSqlDTS("SELECT RIGHT('00000000'+CONVERT(VARCHAR,CORRELATIVO+1),8) AS NRORECIBO FROM CORRELATIVO WHERE ESTADO=1 AND TIPO='RECIBO'", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString();
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
                }
                btnNuevo.BackgroundImage = Properties.Resources.nuevo1_;
            }
        }

        private void Limpiar(string NombreBoton, bool estado)
        {
            lblNuevo.Text = NombreBoton;
            txtNombres.Clear();
            txtGrado.Clear();
            txtNivel.Clear();
            txtSeccion.Clear();
            txtTurno.Clear();
            txtAnioEscolar.Clear();
            txtFase.Clear();
            txtGlosa.Clear();
            cboEntidadBancaria.SelectedIndex = 0;
            txtNroOperacion.Clear();
            dtpFechaDeposito.Value = DateTime.Now;
            txtNumeroDocumento.Text = "00000000";
            cboPension.DataSource = null;
            txtSaldo.Text = "0.00";
            txtAcuenta.Text = "0.00";
            txtMora.Text = "0.00";
            txtDatos.Clear();
            txtTotal.Text = "0.00";
            txtimporte.Text = "0.00";
            chkConceptosOtrosAnios.Checked = false;
            groupBox1.Enabled = estado;
            groupBox2.Enabled = estado;
            groupBox3.Enabled = estado;
            groupBox4.Enabled = estado;
            groupBox5.Enabled = estado;
            groupBox6.Enabled = estado;
            this.dgvDetallePago.Rows.Clear();
            this.dgvDetallePago.Refresh();
            btnGuardar.Enabled = false;
        }

        private void Limpiar2()
        {
            txtNombres.Clear();
            txtGrado.Clear();
            txtNivel.Clear();
            txtSeccion.Clear();
            txtTurno.Clear();
            txtAnioEscolar.Clear();
            txtFase.Clear();
            cboEntidadBancaria.SelectedIndex = 0;
            txtNroOperacion.Clear();
            dtpFechaDeposito.Value = DateTime.Now;
            txtNumeroDocumento.Text = "00000000";
            cboPension.DataSource = null;
            txtSaldo.Text = "0.00";
            txtAcuenta.Text = "0.00";
            txtMora.Text = "0.00";
            //txtDatos.Clear();
            txtTotal.Text = "0.00";
            txtimporte.Text = "0.00";
            this.dgvDetallePago.Rows.Clear();
            this.dgvDetallePago.Refresh();
            txtNumeroDocumento.Text = cn.EjecutarSqlDTS("SELECT RIGHT('00000000'+CONVERT(VARCHAR,CORRELATIVO+1),8) AS NRORECIBO FROM CORRELATIVO WHERE ESTADO=1 AND TIPO='RECIBO'", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string QuitarCaracteres(string cadena)
        {
            string lineaNueva = "";
            string lineaNueva2 = "";
            int tamanoLinea = 0;
            string[] ESPACIO = new string[37] { "\"\"", ";", ",", "+", "!", "#", "$", "%", "/", "(", "\\", "¡", "¿", "'", "`", "~", "[", "}", "]", "<", ">", "_", ")", "{", "^", ":", "|", "¬", "=", "?", "°", "º", "´", "&", "º", "-", "*" };

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int64 dni;
            DataTable dtDatosAlumno = new DataTable();
            DataTable dtPagos = new DataTable();

            txtDatos.Text = MetodosGlobales.QuitarCaracteres(txtDatos.Text.Trim());

            if (txtDatos.Text != string.Empty)
            {
                Limpiar2();

                if (chkBuscar.Checked)
                {
                    frmBuscarAlumno win = new frmBuscarAlumno();
                    win.CriterioBusqueda = txtDatos.Text.Trim();
                    win.Buscar = true;
                    win.ShowDialog();

                    if (win.Doc_busqueda == null) return;

                    txtDatos.Text = win.Doc_busqueda;
                }

                String proc = "";
                String proc2 = "";

                if (chkConceptosOtrosAnios.Checked)
                {
                    proc = "USP_ALUMNOSearchForPayOtrosConceptos_2";
                    proc2 = "USP_MATRICULAAlumnoSearchPayOtrosConceptos_2";
                }
                else
                {
                    proc = "USP_ALUMNOSearchForPay_2";
                    proc2 = "USP_MATRICULAAlumnoSearchPay_2";
                }
                dtDatosAlumno = cn.TraerDataset(proc, conectar.conexionbdSevilla, txtDatos.Text.Trim(),
                    VariablesGlobales.AnioEscolarLogueado, VariablesGlobales.AnioFaseEscolarLogueado, 1).Tables[0];

                if (dtDatosAlumno.Rows.Count > 0)
                {
                    txtNombres.Text = dtDatosAlumno.Rows[0][2].ToString();
                    txtGrado.Text = dtDatosAlumno.Rows[0][3].ToString();
                    txtNivel.Text = dtDatosAlumno.Rows[0][4].ToString();
                    txtSeccion.Text = dtDatosAlumno.Rows[0][5].ToString();
                    txtTurno.Text = dtDatosAlumno.Rows[0][6].ToString();
                    txtAnioEscolar.Text = dtDatosAlumno.Rows[0][7].ToString();
                    txtFase.Text = dtDatosAlumno.Rows[0][8].ToString();
                    lblIdMatricula.Text = dtDatosAlumno.Rows[0][0].ToString();

                    dtPagos = cn.TraerDataset(proc2, conectar.conexionbdSevilla, dtDatosAlumno.Rows[0][1].ToString(),
                        dtDatosAlumno.Rows[0][7].ToString(), dtDatosAlumno.Rows[0][8].ToString(), dtDatosAlumno.Rows[0][0].ToString()).Tables[0];

                    if (dtPagos.Rows.Count > 0)
                    {
                        cboPension.DataSource = dtPagos;
                        cboPension.DisplayMember = "CONCEPTO";
                        cboPension.ValueMember = "IDCTACTE";
                    }
                    else
                    {
                        MessageBox.Show("El Nº de documento ingresado no tiene deudas registradas en el periodo " +
                            VariablesGlobales.AnioEscolarLogueado + " - " + VariablesGlobales.AnioFaseEscolarLogueado, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        groupBox6.Enabled = false;
                        txtDatos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El Nº de documento ingresado no ha sido encontrado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDatos.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un criterio para la búsqueda.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDatos.Focus();
            }

        }


        private void frmPagos_Load(object sender, EventArgs e)
        {
            cboFormaPago.SelectedIndex = 0;
            cargarEntidadFinanciera();
            crearTablaTemporal();
        }

        private void crearTablaTemporal()
        {
            modalidadesPago = new DataTable();

            //modalidadesPago.Clear();

            modalidadesPago.Columns.Add("cod_mod_pago", typeof(string));
            modalidadesPago.Columns.Add("desc_mod_Pago", typeof(string));
            modalidadesPago.Columns.Add("concep_cod", typeof(string));
            modalidadesPago.Columns.Add("FechaDeposito", typeof(DateTime));
            modalidadesPago.Columns.Add("cod_entidad_financ", typeof(string));
            modalidadesPago.Columns.Add("nombre_entidad", typeof(string));
            modalidadesPago.Columns.Add("cuenta_bancaria_id", typeof(string));
            modalidadesPago.Columns.Add("numero_cuenta", typeof(string));
            modalidadesPago.Columns.Add("importe_voucher_pago", typeof(decimal));
            modalidadesPago.Columns.Add("TipoCambio", typeof(decimal));
            modalidadesPago.Columns.Add("importe_cambio", typeof(decimal));
            modalidadesPago.Columns.Add("NumeroDocumento_Voucher_cheque_pago", typeof(string));
            modalidadesPago.Columns.Add("ObservacionPago", typeof(string));
        }

        private void LimpiarTablaModalidad()
        {
            if (modalidadesPago.Rows.Count > 0)
            {
                for (int i = modalidadesPago.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = modalidadesPago.Rows[i];
                    dr.Delete();
                }
                modalidadesPago.AcceptChanges();
            }
        }

        private bool ValidarTotalesMayor()
        {
            decimal total = 0.00m;

            foreach (DataRow item in modalidadesPago.Rows)
            {
                total = total + Convert.ToDecimal(item["importe_cambio"].ToString() == "" ? "0" : item["importe_cambio"].ToString());
            }

            total = total + Convert.ToDecimal(txtimporte.Text);

            return (total > Convert.ToDecimal(txtTotal.Text));
        }

        private bool ValidarTotalesMenor()
        {
            decimal total = 0.00m;

            foreach (DataRow item in modalidadesPago.Rows)
            {
                total = total + Convert.ToDecimal(item["importe_cambio"].ToString() == "" ? "0" : item["importe_cambio"].ToString());
            }

            total = total + Convert.ToDecimal(txtimporte.Text);

            return (total < Convert.ToDecimal(txtTotal.Text));
        }

        private void cargarEntidadFinanciera()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("USP_ENTIDADFINANCIERASelectAll", conectar.conexionbdSevilla).Tables[0];
                cboEntidadBancaria.DataSource = dt;
                cboEntidadBancaria.DisplayMember = "nombre_entidad";
                cboEntidadBancaria.ValueMember = "cod_entidad_financ";
            }
            catch (Exception)
            {
                //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesGlobales.NombreMensajes,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio;

            if (cboPension.SelectedIndex >= 0)
            {
                if (decimal.TryParse(txtAcuenta.Text, out precio))
                {
                    if (Convert.ToDecimal(txtAcuenta.Text) > 0.00m)
                    {
                        foreach (DataGridViewRow rows in this.dgvDetallePago.Rows)
                        {
                            if (rows.Cells[0].Value.ToString() == cboPension.SelectedValue.ToString())
                            {
                                MessageBox.Show("El pago " + cboPension.Text + " ya fue ingresado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        if (Convert.ToDecimal(txtAcuenta.Text)>Convert.ToDecimal(txtSaldo.Text))
                        {
                            MessageBox.Show("El pago a cuenta no puede ser mayor al saldo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtAcuenta.Focus();
                            return;
                        }

                        this.dgvDetallePago.Rows.Add(cboPension.SelectedValue,0, cboPension.Text,
                            Convert.ToDecimal(chkFraccionamiento.Checked ? "0" : txtMora.Text).ToString("#,#.00#;(#,#.00#)"), 
                            Convert.ToDecimal(txtAcuenta.Text).ToString("#,#.00#;(#,#.00#)"),
                            Convert.ToDecimal(txtAcuenta.Text) < Convert.ToDecimal(txtSaldo.Text) ? "ACUENTA" : 
                            (Convert.ToDecimal(txtAcuenta.Text) == Convert.ToDecimal(txtSaldo.Text) ? "CANCELADO" : ""),
                            (Convert.ToDecimal(txtAcuenta.Text) + Convert.ToDecimal(chkFraccionamiento.Checked ? "0" : txtMora.Text)).ToString("#,#.00#;(#,#.00#)"));
                        
                        txtAcuenta.Text = "0.00";
                        txtMora.Text = "0.00";
                        chkFraccionamiento.Checked = false;
                        SumaDetalle();
                    }
                    else
                    {
                        MessageBox.Show("A cuenta tiene que ser mayor a cero (0.00)", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtAcuenta.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor valido para el pago a cuenta.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAcuenta.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un concepto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPension.Focus();
            }
        }

        private void SumaDetalle()
        {
            decimal Total;
            Total = 0.00M;

            foreach (DataGridViewRow rows in this.dgvDetallePago.Rows)
            {
                Total = Total + Convert.ToDecimal(rows.Cells[6].Value);
            }

            txtTotal.Text = Total.ToString("###,###.00");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.dgvDetallePago.Rows.Count <= 0) return;

            dgvDetallePago.Rows.Remove(dgvDetallePago.CurrentRow);

            SumaDetalle();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDetallePago.Rows.Clear();
        }

        private void cboPension_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCtaResultado = new DataTable();

            try
            {
                dtCtaResultado = cn.EjecutarSqlDTS("select A.IMPORTE - (SELECT isnull(SUM(RD.IMPORTETOTAL),0.00) FROM RECIBO RE " +
                    "INNER JOIN RECIBODETALLE RD ON RE.IDRECIBO=RD.IDRECIBO WHERE RD.IDCTACTE=" + cboPension.SelectedValue +
                    " AND RE.ESTADO=1) , " +
                    " CASE WHEN A.IDCONCEPTO = 1 THEN (SELECT CR1.IMPORTE FROM CONCEPTO_RANGO CR1 WHERE ID=9)*(CASE WHEN DATEDIFF(DAY,A.FECHAVENCIMIENTO," +
                    " GETDATE()) < 0 THEN 0 ELSE DATEDIFF(DAY, A.FECHAVENCIMIENTO, GETDATE()) END) ELSE 0.00 END AS MORA" +
                    " from CUENTACORRIENTE A where IDCTACTE=" + cboPension.SelectedValue + "",
                    conectar.conexionbdSevilla).Tables[0];

                txtSaldo.Text = Convert.ToDecimal(dtCtaResultado.Rows[0][0]).ToString("#,#.00#;(#,#.00#)");
                txtMora.Text = Convert.ToDecimal(dtCtaResultado.Rows[0][1]).ToString("#,#.00#;(#,#.00#)");
                txtAcuenta.Text = txtSaldo.Text;
            }
            catch (Exception)
            {

            }
        }

        private void cboEntidadBancaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = new DataTable();
                try
                {
                    dt = cn.TraerDataset("USP_CUENTABANCARIASelectAll", conectar.conexionbdSevilla, cboEntidadBancaria.SelectedValue.ToString()== "System.Data.DataRowView" ? "0": cboEntidadBancaria.SelectedValue).Tables[0];
                    cboNroCuenta.Refresh();
                    cboNroCuenta.DataSource = dt;
                    cboNroCuenta.DisplayMember = "numero_cuenta";
                    cboNroCuenta.ValueMember = "cuenta_bancaria_id";

                    if (cboEntidadBancaria.Text == "DE LA NACION")
                    {
                        cboNroCuenta.SelectedValue = 85;
                    }
                    if (cboEntidadBancaria.Text == "BBVA CONTINENTAL")
                    {
                        cboNroCuenta.SelectedValue = 125;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal importe;

            if (lblIdMatricula.Text!="0")
            {
                if (cboEntidadBancaria.SelectedIndex>0)
                {
                    if (cboNroCuenta.SelectedIndex > 0)
                    {
                        if (txtNroOperacion.Text.Trim()!="")
                        {
                            if(dgvDetallePago.Rows.Count>0)
                            {
                                if (decimal.TryParse(txtimporte.Text,out importe))
                                {
                                    decimal totalVouchers;

                                    totalVouchers = 0.00m;

                                    foreach (DataRow row in modalidadesPago.Rows)
                                    {
                                        totalVouchers = totalVouchers + Convert.ToDecimal(row.ItemArray[10]);
                                    }

                                    if (totalVouchers==0.00m)
                                    {
                                        totalVouchers = Convert.ToDecimal(txtimporte.Text);
                                    }
                                    else
                                    {
                                        totalVouchers = Convert.ToDecimal(txtimporte.Text) + totalVouchers;
                                    }

                                    if (Convert.ToDecimal(txtimporte.Text)>0 &&
                                        totalVouchers == Convert.ToDecimal(txtTotal.Text))
                                    {
                                        string message = "Esta seguro de registrar el recibo de pago.?";
                                        string caption = VariablesGlobales.NombreMensajes;
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                        DialogResult result;

                                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                                        if (result == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            DataSet resultado;
                                            resultado  = new DataSet();
                                            resultado = cn.TraerDataset("USP_RECIBOBuscaNroOperacion", conectar.conexionbdSevilla, 
                                                txtNroOperacion.Text.Trim(), cboEntidadBancaria.SelectedValue, dtpFechaDeposito.Value.ToString("yyyyMMdd"));
                                            if (resultado.Tables[0].Rows.Count>0)
                                            {
                                                MessageBox.Show("El voucher que intenta registrar ya fue asignado a otro recibo.", VariablesGlobales.NombreMensajes,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                                return;
                                            }
                                            resultado = new DataSet();
                                            ArmarTablasCabeceraDetalle();
                                            resultado = cn.IngresaRecibo("USP_RECIBOIngreso", cabeceraRecibo, detalleRecibo, modalidadesPago,
                                                VariablesGlobales.AnioEscolarLogueado,VariablesGlobales.AnioFaseEscolarLogueado,
                                                conectar.conexionbdSevilla);

                                            int idReciboCabecera = 0;

                                            idReciboCabecera = Convert.ToInt32(resultado.Tables[0].Rows[0][0].ToString().Trim());

                                            if (idReciboCabecera == 0)
                                            {
                                                MessageBox.Show("Ocurrio un error al guardar la información, intente de nuevo o contacte con sistemas.", VariablesGlobales.NombreMensajes,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                            }
                                            else
                                            {
                                                MessageBox.Show("El recibo fue ingresado con exito.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Limpiar("Nuevo", false);
                                                btnNuevo.BackgroundImage = Properties.Resources.nuevo1_;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El importe del banco debe ser mayor a cero e igual al importe total del recibo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un importe valido.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtimporte.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese al menos un concepto a pagar.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboPension.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese el número de operación..", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNroOperacion.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un numero de cuenta.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboNroCuenta.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una entidad bancaria.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboEntidadBancaria.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ArmarTablasCabeceraDetalle()
        {
            cabeceraRecibo = new DataTable();
            detalleRecibo = new DataTable();

            cabeceraRecibo.Clear();
            detalleRecibo.Clear();

            cabeceraRecibo.Columns.Add("IDMATRICULA", typeof(int));
            cabeceraRecibo.Columns.Add("MODALIDADPAGO", typeof(string));
            cabeceraRecibo.Columns.Add("IDBANCO", typeof(int));
            cabeceraRecibo.Columns.Add("IDNROCUENTA", typeof(int));
            cabeceraRecibo.Columns.Add("NROVOUCHER", typeof(string));
            cabeceraRecibo.Columns.Add("IMPORTEVOUCHER", typeof(Decimal));
            cabeceraRecibo.Columns.Add("FECHAVOUCHER", typeof(DateTime));
            cabeceraRecibo.Columns.Add("NUMERORECIBO", typeof(string));
            cabeceraRecibo.Columns.Add("FECHARECIBO", typeof(DateTime));
            cabeceraRecibo.Columns.Add("INTERES", typeof(Decimal));
            cabeceraRecibo.Columns.Add("DESCUENTO", typeof(string));
            cabeceraRecibo.Columns.Add("IMPORTERECIBO", typeof(Decimal));
            cabeceraRecibo.Columns.Add("ESTADO", typeof(bool));
            cabeceraRecibo.Columns.Add("GLOSA", typeof(string));
            cabeceraRecibo.Columns.Add("USUCREA", typeof(string));
            cabeceraRecibo.Columns.Add("PCCREA", typeof(string));

            detalleRecibo.Columns.Add("IDCTACTE", typeof(int));
            detalleRecibo.Columns.Add("NROITEM", typeof(int));
            detalleRecibo.Columns.Add("IDCONCEPTO", typeof(int));
            detalleRecibo.Columns.Add("PENSION", typeof(string));
            detalleRecibo.Columns.Add("IMPORTE", typeof(Decimal));
            detalleRecibo.Columns.Add("IMPORTEMORA", typeof(Decimal));
            detalleRecibo.Columns.Add("ESTADOPAGO", typeof(String));
            

            DataRow _filaCabecera = cabeceraRecibo.NewRow();

            _filaCabecera["IDMATRICULA"] = lblIdMatricula.Text;
            _filaCabecera["MODALIDADPAGO"] = cboFormaPago.Text;
            _filaCabecera["IDBANCO"] = cboEntidadBancaria.SelectedValue;
            _filaCabecera["IDNROCUENTA"] = cboNroCuenta.SelectedValue;
            _filaCabecera["NROVOUCHER"] = txtNroOperacion.Text.Trim();
            _filaCabecera["IMPORTEVOUCHER"] = txtimporte.Text;
            _filaCabecera["FECHAVOUCHER"] = dtpFechaDeposito.Value;
            _filaCabecera["NUMERORECIBO"] = txtSerie.Text + "-" + txtNumeroDocumento.Text;
            _filaCabecera["FECHARECIBO"] = dtpFechaRecibo.Value;
            _filaCabecera["INTERES"] = 0.00M;
            _filaCabecera["DESCUENTO"] = 0.00M;
            _filaCabecera["IMPORTERECIBO"] = txtTotal.Text;
            _filaCabecera["ESTADO"] = true;
            _filaCabecera["GLOSA"] = txtGlosa.Text.Trim()=="" ? null:txtGlosa.Text;
            _filaCabecera["USUCREA"] = VariablesGlobales.NombreUsuario;
            _filaCabecera["PCCREA"] = VariablesGlobales.UserHostIp;

            cabeceraRecibo.Rows.Add(_filaCabecera);

            int y = 0;

            if (dgvDetallePago.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetallePago.Rows)
                {
                    DataRow _filaDetalle = detalleRecibo.NewRow();

                    _filaDetalle["IDCTACTE"] = row.Cells[0].Value;
                    _filaDetalle["NROITEM"] = y+1;
                    _filaDetalle["IDCONCEPTO"] = row.Cells[1].Value;
                    _filaDetalle["PENSION"] = row.Cells[2].Value;
                    _filaDetalle["IMPORTEMORA"] = row.Cells[3].Value;
                    _filaDetalle["IMPORTE"] = row.Cells[4].Value;
                    _filaDetalle["ESTADOPAGO"] = row.Cells[5].Value;
                    y = y + 1;
                    detalleRecibo.Rows.Add(_filaDetalle);
                }
            }
        }

        private void txtDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnBuscar_Click(sender,e);
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaPago.Text=="RECIBO")
            {
                cboEntidadBancaria.SelectedValue = 0;
                cboNroCuenta.SelectedValue = 0;
                cboEntidadBancaria.Enabled = false;
                cboNroCuenta.Enabled = false;
            }
            else
            {
                cboEntidadBancaria.SelectedValue = 0;
                cboNroCuenta.SelectedValue = 0;
                cboEntidadBancaria.Enabled = true;
                cboNroCuenta.Enabled = true;
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            frmAgregarModalidadPago win = new frmAgregarModalidadPago();
            win.dtModalidadPago = modalidadesPago;
            win.ImportePago = Convert.ToDecimal(txtimporte.Text);
            win.ImporteDocumento = Convert.ToDecimal(txtTotal.Text);
            modalidadesPago = win.dtModalidadPago;
            win.ShowDialog();
        }
    }
}
