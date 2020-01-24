namespace GUI_SEVILLA
{
    partial class frmEstadoCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEncabezado = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBuscar = new MetroFramework.Controls.MetroCheckBox();
            this.rbMatriculaBaja = new MetroFramework.Controls.MetroRadioButton();
            this.rbMatriculaActiva = new MetroFramework.Controls.MetroRadioButton();
            this.rbOtrasDeudas = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEstadoCuenta = new MetroFramework.Controls.MetroGrid();
            this.IDCTACTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDALUMNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOABREV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAVENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTOPAGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTODEUDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIASRETRASO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboAnio = new MetroFramework.Controls.MetroComboBox();
            this.rbTodos = new MetroFramework.Controls.MetroRadioButton();
            this.rbAcuenta = new MetroFramework.Controls.MetroRadioButton();
            this.rbAnulado = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rbCancelado = new MetroFramework.Controls.MetroRadioButton();
            this.rbPendiente = new MetroFramework.Controls.MetroRadioButton();
            this.btnDeuda = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnImprimirTotal = new MetroFramework.Controls.MetroButton();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCuenta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEncabezado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEncabezado.Location = new System.Drawing.Point(23, 60);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(808, 31);
            this.lblEncabezado.TabIndex = 16;
            this.lblEncabezado.Text = "metroLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBuscar);
            this.groupBox1.Controls.Add(this.rbMatriculaBaja);
            this.groupBox1.Controls.Add(this.rbMatriculaActiva);
            this.groupBox1.Controls.Add(this.rbOtrasDeudas);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkBuscar
            // 
            this.chkBuscar.AutoSize = true;
            this.chkBuscar.Location = new System.Drawing.Point(84, 12);
            this.chkBuscar.Name = "chkBuscar";
            this.chkBuscar.Size = new System.Drawing.Size(75, 15);
            this.chkBuscar.TabIndex = 20;
            this.chkBuscar.Text = "&Busqueda";
            this.chkBuscar.UseSelectable = true;
            // 
            // rbMatriculaBaja
            // 
            this.rbMatriculaBaja.AutoSize = true;
            this.rbMatriculaBaja.Location = new System.Drawing.Point(281, 54);
            this.rbMatriculaBaja.Name = "rbMatriculaBaja";
            this.rbMatriculaBaja.Size = new System.Drawing.Size(114, 15);
            this.rbMatriculaBaja.TabIndex = 7;
            this.rbMatriculaBaja.Text = "Matrícula de Baja";
            this.rbMatriculaBaja.UseSelectable = true;
            this.rbMatriculaBaja.CheckedChanged += new System.EventHandler(this.rbMatriculaBaja_CheckedChanged);
            // 
            // rbMatriculaActiva
            // 
            this.rbMatriculaActiva.AutoSize = true;
            this.rbMatriculaActiva.Checked = true;
            this.rbMatriculaActiva.Location = new System.Drawing.Point(281, 12);
            this.rbMatriculaActiva.Name = "rbMatriculaActiva";
            this.rbMatriculaActiva.Size = new System.Drawing.Size(107, 15);
            this.rbMatriculaActiva.TabIndex = 7;
            this.rbMatriculaActiva.TabStop = true;
            this.rbMatriculaActiva.Text = "Matrícula activa";
            this.rbMatriculaActiva.UseSelectable = true;
            this.rbMatriculaActiva.CheckedChanged += new System.EventHandler(this.rbMatriculaActiva_CheckedChanged);
            // 
            // rbOtrasDeudas
            // 
            this.rbOtrasDeudas.AutoSize = true;
            this.rbOtrasDeudas.Location = new System.Drawing.Point(281, 33);
            this.rbOtrasDeudas.Name = "rbOtrasDeudas";
            this.rbOtrasDeudas.Size = new System.Drawing.Size(92, 15);
            this.rbOtrasDeudas.TabIndex = 7;
            this.rbOtrasDeudas.Text = "Otras deudas";
            this.rbOtrasDeudas.UseSelectable = true;
            this.rbOtrasDeudas.CheckedChanged += new System.EventHandler(this.rbOtrasDeudas_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(223, 54);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 15);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Buscar";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nombres :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Nº Doc :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.buscar2;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Location = new System.Drawing.Point(216, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.Lines = new string[0];
            this.txtNombres.Location = new System.Drawing.Point(84, 73);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PromptText = "Nombre completo del alumno";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.Size = new System.Drawing.Size(296, 23);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.UseSelectable = true;
            this.txtNombres.WaterMark = "Nombre completo del alumno";
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(84, 30);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Ingrese Nº de Doc...";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(126, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Ingrese Nº de Doc...";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEstadoCuenta);
            this.groupBox2.Location = new System.Drawing.Point(23, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 315);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // dgvEstadoCuenta
            // 
            this.dgvEstadoCuenta.AllowUserToAddRows = false;
            this.dgvEstadoCuenta.AllowUserToDeleteRows = false;
            this.dgvEstadoCuenta.AllowUserToResizeRows = false;
            this.dgvEstadoCuenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEstadoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadoCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEstadoCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCTACTE,
            this.IDALUMNO,
            this.ANIO,
            this.MES,
            this.CONCEPTO,
            this.IMPORTE,
            this.ESTADO,
            this.ESTADOABREV,
            this.FECHAVENCIMIENTO,
            this.MONTOPAGADO,
            this.MONTODEUDA,
            this.DIASRETRASO});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoCuenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadoCuenta.EnableHeadersVisualStyles = false;
            this.dgvEstadoCuenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEstadoCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEstadoCuenta.Location = new System.Drawing.Point(3, 16);
            this.dgvEstadoCuenta.Name = "dgvEstadoCuenta";
            this.dgvEstadoCuenta.ReadOnly = true;
            this.dgvEstadoCuenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoCuenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEstadoCuenta.RowHeadersWidth = 28;
            this.dgvEstadoCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEstadoCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoCuenta.Size = new System.Drawing.Size(872, 296);
            this.dgvEstadoCuenta.TabIndex = 0;
            // 
            // IDCTACTE
            // 
            this.IDCTACTE.DataPropertyName = "IDCTACTE";
            this.IDCTACTE.HeaderText = "IDCTACTE";
            this.IDCTACTE.Name = "IDCTACTE";
            this.IDCTACTE.ReadOnly = true;
            this.IDCTACTE.Visible = false;
            // 
            // IDALUMNO
            // 
            this.IDALUMNO.DataPropertyName = "IDALUMNO";
            this.IDALUMNO.HeaderText = "IDALUMNO";
            this.IDALUMNO.Name = "IDALUMNO";
            this.IDALUMNO.ReadOnly = true;
            this.IDALUMNO.Visible = false;
            // 
            // ANIO
            // 
            this.ANIO.DataPropertyName = "ANIO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ANIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.ANIO.HeaderText = "ANIO";
            this.ANIO.Name = "ANIO";
            this.ANIO.ReadOnly = true;
            this.ANIO.Width = 80;
            // 
            // MES
            // 
            this.MES.DataPropertyName = "MES";
            this.MES.HeaderText = "MES";
            this.MES.Name = "MES";
            this.MES.ReadOnly = true;
            this.MES.Visible = false;
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.DataPropertyName = "CONCEPTO";
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            this.CONCEPTO.ReadOnly = true;
            this.CONCEPTO.Width = 200;
            // 
            // IMPORTE
            // 
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMPORTE.HeaderText = "IMPORTE INICIAL";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // ESTADOABREV
            // 
            this.ESTADOABREV.HeaderText = "ESTADOABREV";
            this.ESTADOABREV.Name = "ESTADOABREV";
            this.ESTADOABREV.ReadOnly = true;
            this.ESTADOABREV.Visible = false;
            // 
            // FECHAVENCIMIENTO
            // 
            this.FECHAVENCIMIENTO.DataPropertyName = "FECHAVENCIMIENTO";
            this.FECHAVENCIMIENTO.HeaderText = "FECHA DE VENCIMIENTO";
            this.FECHAVENCIMIENTO.Name = "FECHAVENCIMIENTO";
            this.FECHAVENCIMIENTO.ReadOnly = true;
            // 
            // MONTOPAGADO
            // 
            this.MONTOPAGADO.DataPropertyName = "MONTOPAGADO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.MONTOPAGADO.DefaultCellStyle = dataGridViewCellStyle4;
            this.MONTOPAGADO.HeaderText = "IMPORTE PAGADO";
            this.MONTOPAGADO.Name = "MONTOPAGADO";
            this.MONTOPAGADO.ReadOnly = true;
            // 
            // MONTODEUDA
            // 
            this.MONTODEUDA.DataPropertyName = "MONTODEUDA";
            this.MONTODEUDA.HeaderText = "IMPORTE A PAGAR";
            this.MONTODEUDA.Name = "MONTODEUDA";
            this.MONTODEUDA.ReadOnly = true;
            this.MONTODEUDA.Width = 80;
            // 
            // DIASRETRASO
            // 
            this.DIASRETRASO.DataPropertyName = "DIASRETRASO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DIASRETRASO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DIASRETRASO.HeaderText = "DIAS DE RETRASO";
            this.DIASRETRASO.Name = "DIASRETRASO";
            this.DIASRETRASO.ReadOnly = true;
            this.DIASRETRASO.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.cboAnio);
            this.groupBox3.Controls.Add(this.rbTodos);
            this.groupBox3.Controls.Add(this.rbAcuenta);
            this.groupBox3.Controls.Add(this.rbAnulado);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.rbCancelado);
            this.groupBox3.Controls.Add(this.rbPendiente);
            this.groupBox3.Controls.Add(this.btnDeuda);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnImprimirTotal);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Location = new System.Drawing.Point(430, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 102);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(6, 56);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 15);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Año escolar";
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.ItemHeight = 23;
            this.cboAnio.Location = new System.Drawing.Point(6, 24);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(98, 29);
            this.cboAnio.TabIndex = 9;
            this.cboAnio.UseSelectable = true;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(323, 79);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(54, 15);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseSelectable = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbAcuenta
            // 
            this.rbAcuenta.AutoSize = true;
            this.rbAcuenta.Location = new System.Drawing.Point(247, 79);
            this.rbAcuenta.Name = "rbAcuenta";
            this.rbAcuenta.Size = new System.Drawing.Size(70, 15);
            this.rbAcuenta.TabIndex = 6;
            this.rbAcuenta.Text = "A cuenta";
            this.rbAcuenta.UseSelectable = true;
            this.rbAcuenta.CheckedChanged += new System.EventHandler(this.rbAcuenta_CheckedChanged);
            // 
            // rbAnulado
            // 
            this.rbAnulado.AutoSize = true;
            this.rbAnulado.Location = new System.Drawing.Point(173, 79);
            this.rbAnulado.Name = "rbAnulado";
            this.rbAnulado.Size = new System.Drawing.Size(68, 15);
            this.rbAnulado.TabIndex = 6;
            this.rbAnulado.Text = "Anulado";
            this.rbAnulado.UseSelectable = true;
            this.rbAnulado.CheckedChanged += new System.EventHandler(this.rbAnulado_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(209, 57);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 15);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Deuda por Año";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(419, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(27, 15);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Salir";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(311, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 15);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Deuda por mes";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(112, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 15);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Ver rep individual";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(88, 79);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(79, 15);
            this.rbCancelado.TabIndex = 6;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseSelectable = true;
            this.rbCancelado.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Checked = true;
            this.rbPendiente.Location = new System.Drawing.Point(6, 79);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(76, 15);
            this.rbPendiente.TabIndex = 6;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseSelectable = true;
            this.rbPendiente.CheckedChanged += new System.EventHandler(this.rbPendiente_CheckedChanged);
            // 
            // btnDeuda
            // 
            this.btnDeuda.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.registrogrado;
            this.btnDeuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeuda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeuda.Location = new System.Drawing.Point(209, 16);
            this.btnDeuda.Name = "btnDeuda";
            this.btnDeuda.Size = new System.Drawing.Size(87, 38);
            this.btnDeuda.TabIndex = 1;
            this.btnDeuda.UseSelectable = true;
            this.btnDeuda.Click += new System.EventHandler(this.btnDeuda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(401, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimirTotal
            // 
            this.btnImprimirTotal.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.deudaTotal;
            this.btnImprimirTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirTotal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnImprimirTotal.Location = new System.Drawing.Point(302, 15);
            this.btnImprimirTotal.Name = "btnImprimirTotal";
            this.btnImprimirTotal.Size = new System.Drawing.Size(93, 38);
            this.btnImprimirTotal.TabIndex = 0;
            this.btnImprimirTotal.UseSelectable = true;
            this.btnImprimirTotal.Click += new System.EventHandler(this.btnImprimirTotal_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.reporteindi;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnImprimir.Location = new System.Drawing.Point(110, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 38);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEncabezado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstadoCuenta";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Estado de cuenta:::...";
            this.Load += new System.EventHandler(this.frmEstadoCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCuenta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblEncabezado;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid dgvEstadoCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private MetroFramework.Controls.MetroRadioButton rbCancelado;
        private MetroFramework.Controls.MetroRadioButton rbPendiente;
        private MetroFramework.Controls.MetroRadioButton rbTodos;
        private MetroFramework.Controls.MetroRadioButton rbAnulado;
        private MetroFramework.Controls.MetroRadioButton rbAcuenta;
        private MetroFramework.Controls.MetroButton btnImprimirTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCTACTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDALUMNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOABREV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAVENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTOPAGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTODEUDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASRETRASO;
        private MetroFramework.Controls.MetroRadioButton rbOtrasDeudas;
        private MetroFramework.Controls.MetroRadioButton rbMatriculaBaja;
        private MetroFramework.Controls.MetroRadioButton rbMatriculaActiva;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboAnio;
        private MetroFramework.Controls.MetroCheckBox chkBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnDeuda;
    }
}