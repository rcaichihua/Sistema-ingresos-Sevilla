using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;
using MetroFramework.Controls;

namespace GUI_SEVILLA
{
    public partial class frmMantenimientoConcepto : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        public string TipoMantenimiento { get; set; }
        public int IdConcepto { get; set; }

        public frmMantenimientoConcepto()
        {
            InitializeComponent();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void frmMantenimientoConcepto_Load(object sender, EventArgs e)
        {
            LlenaCuentaContable();
            if (TipoMantenimiento=="U")
            {
                DataTable DatosConcepto = new DataTable();
                DatosConcepto = cn.EjecutarSqlDTS("SELECT IDCONCEPTO,CODCONCEPTO,DESCRIPCONCEPTO,IMPORTE_REFERENCIAL,b.id_cuenta_contable,B.codigoCuenta,a.OBSERVACIONES,A.ESTADO FROM CONCEPTO A INNER JOIN bdtesoreria.dbo.tb_cta_contable B ON A.IDCUENTACONTABLE=B.id_cuenta_contable where a.IDCONCEPTO='"+IdConcepto+"'  order by CODCONCEPTO asc", conectar.conexionbdSevilla).Tables[0];

                if (DatosConcepto.Rows.Count > 0)
                {
                    txtConcepto.Text = DatosConcepto.Rows[0][1].ToString();
                    txtNombreConcepto.Text = DatosConcepto.Rows[0][2].ToString();
                    txtImporteReferencial.Text = DatosConcepto.Rows[0][3].ToString();
                    cboCuentaContable.SelectedValue = DatosConcepto.Rows[0][4].ToString();
                    chkActivo.Checked = Convert.ToBoolean(DatosConcepto.Rows[0][7]);
                    txtObservaciones.Text = DatosConcepto.Rows[0][6].ToString();
                    txtConcepto.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, intente de nuevo..", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LlenaCuentaContable()
        {
            DataTable ListaCtaContable = new DataTable();

            ListaCtaContable = cn.EjecutarSqlDTS("select id_cuenta_contable,codigoCuenta+' - '+descripcionCuenta as descripcion from bdtesoreria.dbo.tb_cta_contable where movimiento<>0 and elementoID=1 and SUBSTRING(CODIGOCUENTA,1,2)='12' order by codigoCuenta asc", conectar.conexionbdSevilla).Tables[0];
            ////cboCuentaContable.DataSource = ListaCtaContable;
            //cboCuentaContable.DisplayMember = "descripcion";
            //cboCuentaContable.ValueMember = "id_cuenta_contable";

            List<string> list = new List<string>();
            foreach (DataRow row in ListaCtaContable.Rows)
            {
                list.Add(row.Field<string>("descripcion"));
            }
            //this.cboCuentaContable.Items.AddRange(list.ToArray<string>());
            //cboCuentaContable.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboCuentaContable.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cboCuentaContable.AutoCompleteCustomSource.AddRange(list.ToArray());

            // Cargo los datos del combobox
            //
            cboCuentaContable.DataSource = ListaCtaContable;
            cboCuentaContable.DisplayMember = "descripcion";
            cboCuentaContable.ValueMember = "id_cuenta_contable";

            //
            // cargo la lista de items para el autocomplete
            //
            cboCuentaContable.AutoCompleteCustomSource.AddRange(list.ToArray());
            cboCuentaContable.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCuentaContable.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtNombreConcepto.Text = MetodosGlobales.QuitarCaracteres(txtNombreConcepto.Text);
            txtImporteReferencial.Text = MetodosGlobales.QuitarCaracteres(txtImporteReferencial.Text);
            txtObservaciones.Text = MetodosGlobales.QuitarCaracteres(txtObservaciones.Text);

            try
            {               
                if (Validar() == true) return;

                if (TipoMantenimiento == "I")
                {
                    if (!VerificaConcepto())
                    {
                        MessageBox.Show("El codigo de concepto que intenta registrar ya existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtConcepto.Focus();
                        return;
                    }

                    if (ActualizaInsertaAlumno("USP_CONCEPTOInsert"))
                    {
                        MessageBox.Show("Concepto Ingresado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TipoMantenimiento == "U")
                {
                    if (ActualizaInsertaAlumno("USP_CONCEPTOUpdate"))
                    {
                        MessageBox.Show("Concepto actualizado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ActualizaInsertaAlumno(string procedimiento)
        {
            Boolean resultado;
            resultado = false;

            if (cn.EjecutarSP(procedimiento, conectar.conexionbdSevilla, txtConcepto.Text.Trim(), txtNombreConcepto.Text.Trim(),
                       txtImporteReferencial.Text.Trim(), cboCuentaContable.SelectedValue, chkActivo.Checked,
                       txtObservaciones.Text.Trim(), IdConcepto) > 0)
            {
                resultado = true;
            }
            return resultado;
        }

        private Boolean VerificaConcepto()
        {
            return (cn.EjecutarSqlDTS("select COUNT(*) from CONCEPTO where CODCONCEPTO = '" + txtConcepto.Text.Trim() + "'", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString() == "0");
        }

        private bool Validar()
        {
            bool rspta;

            if (txtConcepto.Text.Trim()!="")
            {
                if (txtNombreConcepto.Text.Trim()!="")
                {
                    if (txtImporteReferencial.Text!="")
                    {
                        if (this.cboCuentaContable.SelectedItem.ToString() != "")
                        {
                            rspta = false;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una cuneta contable.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboCuentaContable.Focus();
                            rspta = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el importe referencial.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtImporteReferencial.Focus();
                        rspta = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del concepto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreConcepto.Focus();
                    rspta = true;
                }
            }else
            {
                MessageBox.Show("Ingrese el concepto.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConcepto.Focus();
                rspta = true;
            }
            return rspta;
        }

        private void txtImporteReferencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            MetroTextBox textBox = (MetroTextBox)sender;
            // only allow one decimal point
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && textBox.SelectionLength == 0)
            {
                if (textBox.Text.IndexOf('.') > -1 && textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
