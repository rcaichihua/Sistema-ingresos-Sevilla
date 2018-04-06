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
    public partial class frmAlumnos : MetroFramework.Forms.MetroForm
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        public string TipoMantenimiento { get; set; }
        public int IdAlumno { get; set; }

        DataTable dtDepaLn = new DataTable();
        DataTable dtProvLn = new DataTable();
        DataTable dtDistLn = new DataTable();

        DataTable dtDepaDd = new DataTable();
        DataTable dtProvDd = new DataTable();
        DataTable dtDistDd = new DataTable();

        DataTable dtResultadoCombos = new DataTable();

        DataTable dtDatosAlumnos;

        CNegocio cn = new CNegocio();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            CargarUbigeos();
            CargarSeguros();

            if (TipoMantenimiento == "U")
            {
                dtDatosAlumnos = new DataTable();

                dtDatosAlumnos = cn.TraerDataset("USP_ALUMNOSelectById", conectar.conexionbdSevilla, IdAlumno).Tables[0];

                if (dtDatosAlumnos.Rows.Count > 0)
                {
                    dtResultadoCombos = cn.EjecutarSqlDTS("SELECT DEPA,PROV,DIST FROM UBIGEO WHERE UBIGEO='"+ dtDatosAlumnos.Rows[0][6].ToString() + "' AND DIST<>'DIST'", conectar.conexionbdSevilla).Tables[0];
                    txtDni.Text = dtDatosAlumnos.Rows[0][1].ToString();
                    txtApePat.Text = dtDatosAlumnos.Rows[0][2].ToString();
                    txtApeMat.Text = dtDatosAlumnos.Rows[0][3].ToString();
                    txtNombres.Text = dtDatosAlumnos.Rows[0][4].ToString();
                    dtpFechaNac.Value = Convert.ToDateTime(dtDatosAlumnos.Rows[0][5]);
                    cboDepaLn.Text = dtResultadoCombos.Rows[0][0].ToString();
                    cboProvLn.Text = dtResultadoCombos.Rows[0][1].ToString();
                    cboDistLn.Text = dtResultadoCombos.Rows[0][2].ToString();
                    txtEdad.Text = dtDatosAlumnos.Rows[0][7].ToString();
                    txtDireccion.Text = dtDatosAlumnos.Rows[0][8].ToString();
                    dtResultadoCombos = cn.EjecutarSqlDTS("SELECT DEPA,PROV,DIST FROM UBIGEO WHERE UBIGEO='" + dtDatosAlumnos.Rows[0][9].ToString() + "' AND DIST<>'DIST'", conectar.conexionbdSevilla).Tables[0];
                    cboDepaDd.Text = dtResultadoCombos.Rows[0][0].ToString();
                    cboProvDd.Text = dtResultadoCombos.Rows[0][1].ToString();
                    cboDistDd.Text = dtResultadoCombos.Rows[0][2].ToString();
                    txtTelefono.Text = dtDatosAlumnos.Rows[0][10].ToString();
                    cboSeguro.SelectedValue = dtDatosAlumnos.Rows[0][11];
                    chkActivo.Checked = Convert.ToBoolean(dtDatosAlumnos.Rows[0][12]);
                    txtMotivoBaja.Text = dtDatosAlumnos.Rows[0][13].ToString();
                    txtObservaciones.Text = dtDatosAlumnos.Rows[0][14].ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo recuperar datos para la edición del alumno, vuelva a intentarlo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarSeguros()
        {
            DataTable dtSeguros = new DataTable();
            dtSeguros = cn.EjecutarSqlDTS("select IDSEGURO,DESCRIPSEGURO from TIPOSEGURO order by DESCRIPSEGURO",
                conectar.conexionbdSevilla).Tables[0];

            DataRow row1 = dtSeguros.NewRow();
            row1["IDSEGURO"] = 0;
            row1["DESCRIPSEGURO"] = "SELECCIONAR";
            dtSeguros.Rows.InsertAt(row1, 0);

            this.cboSeguro.DataSource = dtSeguros;
            this.cboSeguro.DisplayMember = "DESCRIPSEGURO";
            this.cboSeguro.ValueMember = "IDSEGURO";
            this.cboSeguro.Refresh();
        }

        private void CargarUbigeos()
        {
            try
            {
                dtDepaLn = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,1,2) as CODDEPA,DEPA from UBIGEO WHERE DEPA<>'DEPA' and substring(UBIGEO,1,2)<>'35' ORDER BY DEPA",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row = dtDepaLn.NewRow();
                row["CODDEPA"] = "00";
                row["DEPA"] = "SELECCIONAR";
                dtDepaLn.Rows.InsertAt(row, 0);

                this.cboDepaLn.DataSource = dtDepaLn;
                this.cboDepaLn.DisplayMember = "DEPA";
                this.cboDepaLn.ValueMember = "CODDEPA";
                this.cboDepaLn.Refresh();

                dtDepaDd = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,1,2) as CODDEPA,DEPA from UBIGEO WHERE DEPA<>'DEPA' and substring(UBIGEO,1,2)<>'35' ORDER BY DEPA",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row1 = dtDepaDd.NewRow();
                row1["CODDEPA"] = "00";
                row1["DEPA"] = "SELECCIONAR";
                dtDepaDd.Rows.InsertAt(row1, 0);

                this.cboDepaDd.DataSource = dtDepaDd;
                this.cboDepaDd.DisplayMember = "DEPA";
                this.cboDepaDd.ValueMember = "CODDEPA";
                this.cboDepaDd.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void cboDepaLn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtProvLn = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,3,2) as CODPROV,PROV from UBIGEO WHERE PROV<>'PROV' AND substring(UBIGEO,1,2)='" + cboDepaLn.SelectedValue + "' ORDER BY PROV",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row = dtProvLn.NewRow();
                row["CODPROV"] = "00";
                row["PROV"] = "SELECCIONAR";
                dtProvLn.Rows.InsertAt(row, 0);

                this.cboProvLn.DataSource = dtProvLn;
                this.cboProvLn.DisplayMember = "PROV";
                this.cboProvLn.ValueMember = "CODPROV";
                this.cboProvLn.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void cboDepaDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtProvDd = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,3,2) as CODPROV,PROV from UBIGEO WHERE PROV<>'PROV' AND substring(UBIGEO,1,2)='" + cboDepaDd.SelectedValue + "' ORDER BY PROV",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row = dtProvDd.NewRow();
                row["CODPROV"] = "00";
                row["PROV"] = "SELECCIONAR";
                dtProvDd.Rows.InsertAt(row, 0);

                this.cboProvDd.DataSource = dtProvDd;
                this.cboProvDd.DisplayMember = "PROV";
                this.cboProvDd.ValueMember = "CODPROV";
                this.cboProvDd.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void cboProvLn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtDistLn = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,5,2) as CODDIST,DIST from UBIGEO WHERE DIST<>'DIST' AND substring(UBIGEO,1,2)='" + cboDepaLn.SelectedValue + "' AND substring(UBIGEO,3,2)='" + cboProvLn.SelectedValue + "' ORDER BY DIST",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row = dtDistLn.NewRow();
                row["CODDIST"] = "00";
                row["DIST"] = "SELECCIONAR";
                dtDistLn.Rows.InsertAt(row, 0);

                this.cboDistLn.DataSource = dtDistLn;
                this.cboDistLn.DisplayMember = "DIST";
                this.cboDistLn.ValueMember = "CODDIST";
                this.cboDistLn.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void cboProvDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtDistDd = cn.EjecutarSqlDTS("select DISTINCT substring(UBIGEO,5,2) as CODDIST,DIST from UBIGEO WHERE DIST<>'DIST' AND substring(UBIGEO,1,2)='" + cboDepaDd.SelectedValue + "' AND substring(UBIGEO,3,2)='" + cboProvDd.SelectedValue + "' ORDER BY DIST",
                conectar.conexionbdSevilla).Tables[0];

                DataRow row = dtDistDd.NewRow();
                row["CODDIST"] = "00";
                row["DIST"] = "SELECCIONAR";
                dtDistDd.Rows.InsertAt(row, 0);

                this.cboDistDd.DataSource = dtDistDd;
                this.cboDistDd.DisplayMember = "DIST";
                this.cboDistDd.ValueMember = "CODDIST";
                this.cboDistDd.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == true) return;

                if (TipoMantenimiento == "I")
                {
                    if (!VerificaDNI())
                    {
                        MessageBox.Show("El DNI que intenta registrar ya existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDni.Focus();
                        return;
                    }

                    txtEdad.Text = Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString()).ToString();

                    if (ActualizaInsertaAlumno("USP_ALUMNOInsert"))
                    {
                        MessageBox.Show("Datos de alumno Ingresado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TipoMantenimiento == "U")
                {

                    if (dtDatosAlumnos.Rows[0][1].ToString()!=txtDni.Text.Trim())
                    {
                        if (!VerificaDNI())
                        {
                            MessageBox.Show("El DNI que intenta registrar ya existe.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDni.Focus();
                            return;
                        }
                    }

                    txtEdad.Text = Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString()).ToString();

                    if (ActualizaInsertaAlumno("USP_ALUMNOUpdate"))
                    {
                        MessageBox.Show("Datos de alumno actualizado Correctamente", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Boolean  ActualizaInsertaAlumno(string procedimiento)
        {
            Boolean resultado;
            resultado = false;

            if (cn.EjecutarSP(procedimiento, conectar.conexionbdSevilla, txtDni.Text.Trim(), txtApePat.Text.Trim(),
                       txtApeMat.Text.Trim(), txtNombres.Text.Trim(), dtpFechaNac.Value.ToString("dd/MM/yyyy").ToString(),
                       cboDepaLn.SelectedValue.ToString() + cboProvLn.SelectedValue.ToString() + cboDistLn.SelectedValue.ToString(),
                       Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString()).ToString(), txtDireccion.Text.Trim(), cboDepaDd.SelectedValue.ToString() + cboProvDd.SelectedValue.ToString() + cboDistDd.SelectedValue.ToString(),
                       txtTelefono.Text.Trim(), cboSeguro.SelectedValue.ToString(), chkActivo.Checked,
                       txtMotivoBaja.Text.Trim(), txtObservaciones.Text.Trim(), VariablesGlobales.NombreUsuario,
                       VariablesGlobales.UserHostIp, IdAlumno) > 0)
            {
                resultado = true;
            }
            return resultado;
                //MessageBox.Show("Error al ingresar, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private Boolean VerificaDNI()
        {
            return (cn.EjecutarSqlDTS("select COUNT(*) from ALUMNO where DNI = '"+txtDni.Text.Trim()+"'", conectar.conexionbdSevilla).Tables[0].Rows[0][0].ToString() == "0");
        }

        private Boolean Validar()
        {
            Boolean flag;

            if (txtDni.Text.Trim() != string.Empty)
            {
                if (txtApePat.Text.Trim() != string.Empty)
                {
                    if (txtApeMat.Text.Trim() != string.Empty)
                    {
                        if (txtNombres.Text.Trim() != string.Empty)
                        {
                            if (cboDistLn.SelectedValue.ToString() != "00")
                            {
                                if (cboDistDd.SelectedValue.ToString() != "00")
                                {
                                    if (Convert.ToInt32(cboSeguro.SelectedValue) != 0)
                                    {
                                        if (txtDireccion.Text.Trim() != string.Empty)
                                        {
                                            if (Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString())>5 && Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString()) < 19)
                                            {
                                                if (txtDni.Text.Trim().Length == 8)
                                                {
                                                    flag = false;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese un Nº de DNI válido.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    txtDni.Focus();
                                                    flag = true;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese una fecha de nacimiento válido.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                dtpFechaNac.Focus();
                                                flag = true;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese la dirección.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtDireccion.Focus();
                                            flag = true;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione el Tipo de seguro de la Alumna.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboSeguro.Focus();
                                        flag = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Distrito de la Dirección", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    cboDistDd.Focus();
                                    flag = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese lugar de Nacimiento", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboDistLn.Focus();
                                flag = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese los Nombres", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNombres.Focus();
                            flag = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Apellido Materno", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtApeMat.Focus();
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Apellido Paterno", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApePat.Focus();
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el DNI", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDni.Focus();
                flag = true;
            }
            return flag;
        }

        private void txtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtEdad.Text = Convert.ToInt32(calcularEdad(dtpFechaNac.Value.ToString("yyyyMMdd")).ToString()).ToString();
            }
        }

        private decimal calcularEdad(string fecha)
        {
            return Math.Floor(Convert.ToDecimal((Convert.ToInt32(VariablesGlobales.FechaActual) - Convert.ToInt32(fecha)) / 10000));
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
    }
}
