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
            this.DIASRETRASO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new MetroFramework.Controls.MetroRadioButton();
            this.rbAcuenta = new MetroFramework.Controls.MetroRadioButton();
            this.rbAnulado = new MetroFramework.Controls.MetroRadioButton();
            this.rbCancelado = new MetroFramework.Controls.MetroRadioButton();
            this.rbPendiente = new MetroFramework.Controls.MetroRadioButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.chkBaja = new MetroFramework.Controls.MetroCheckBox();
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nombres :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "DNI :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(261, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
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
            this.txtNombres.Location = new System.Drawing.Point(90, 63);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(90, 34);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Ingrese el DNI para el filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(165, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Ingrese el DNI para el filtro";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEstadoCuenta);
            this.groupBox2.Location = new System.Drawing.Point(23, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 375);
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
            this.dgvEstadoCuenta.Size = new System.Drawing.Size(802, 356);
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
            this.IMPORTE.HeaderText = "MONTO A PAGAR";
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
            this.groupBox3.Controls.Add(this.chkBaja);
            this.groupBox3.Controls.Add(this.rbTodos);
            this.groupBox3.Controls.Add(this.rbAcuenta);
            this.groupBox3.Controls.Add(this.rbAnulado);
            this.groupBox3.Controls.Add(this.rbCancelado);
            this.groupBox3.Controls.Add(this.rbPendiente);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Location = new System.Drawing.Point(430, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 102);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(323, 71);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 15);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseSelectable = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbAcuenta
            // 
            this.rbAcuenta.AutoSize = true;
            this.rbAcuenta.Location = new System.Drawing.Point(247, 71);
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
            this.rbAnulado.Location = new System.Drawing.Point(173, 71);
            this.rbAnulado.Name = "rbAnulado";
            this.rbAnulado.Size = new System.Drawing.Size(68, 15);
            this.rbAnulado.TabIndex = 6;
            this.rbAnulado.Text = "Anulado";
            this.rbAnulado.UseSelectable = true;
            this.rbAnulado.CheckedChanged += new System.EventHandler(this.rbAnulado_CheckedChanged);
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(88, 71);
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
            this.rbPendiente.Location = new System.Drawing.Point(6, 71);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(76, 15);
            this.rbPendiente.TabIndex = 6;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseSelectable = true;
            this.rbPendiente.CheckedChanged += new System.EventHandler(this.rbPendiente_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(253, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnImprimir.Location = new System.Drawing.Point(122, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(125, 38);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseSelectable = true;
            // 
            // chkBaja
            // 
            this.chkBaja.Location = new System.Drawing.Point(6, 22);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(104, 43);
            this.chkBaja.TabIndex = 7;
            this.chkBaja.Text = "Matrículas \r\nde Baja";
            this.chkBaja.UseSelectable = true;
            // 
            // frmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 600);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASRETRASO;
        private MetroFramework.Controls.MetroCheckBox chkBaja;
    }
}