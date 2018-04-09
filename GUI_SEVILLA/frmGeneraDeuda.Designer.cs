namespace GUI_SEVILLA
{
    partial class frmGeneraDeuda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCabeceraAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnQuitar = new MetroFramework.Controls.MetroButton();
            this.cboConcepto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new MetroFramework.Controls.MetroGrid();
            this.IDCONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarAlumno = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.dtpFechaRegistro = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gbCabeceraAlumno.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbBuscarAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCabeceraAlumno
            // 
            this.gbCabeceraAlumno.Controls.Add(this.dtpFechaRegistro);
            this.gbCabeceraAlumno.Controls.Add(this.btnAgregar);
            this.gbCabeceraAlumno.Controls.Add(this.btnLimpiar);
            this.gbCabeceraAlumno.Controls.Add(this.btnQuitar);
            this.gbCabeceraAlumno.Controls.Add(this.cboConcepto);
            this.gbCabeceraAlumno.Controls.Add(this.metroLabel6);
            this.gbCabeceraAlumno.Controls.Add(this.txtPrecio);
            this.gbCabeceraAlumno.Controls.Add(this.metroLabel2);
            this.gbCabeceraAlumno.Controls.Add(this.metroLabel8);
            this.gbCabeceraAlumno.Controls.Add(this.txtCantidad);
            this.gbCabeceraAlumno.Controls.Add(this.metroLabel7);
            this.gbCabeceraAlumno.Enabled = false;
            this.gbCabeceraAlumno.Location = new System.Drawing.Point(23, 171);
            this.gbCabeceraAlumno.Name = "gbCabeceraAlumno";
            this.gbCabeceraAlumno.Size = new System.Drawing.Size(545, 99);
            this.gbCabeceraAlumno.TabIndex = 1;
            this.gbCabeceraAlumno.TabStop = false;
            this.gbCabeceraAlumno.Text = "Cabecera deuda";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(467, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 19);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(467, 63);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 19);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(467, 38);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(72, 19);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseSelectable = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cboConcepto
            // 
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.ItemHeight = 23;
            this.cboConcepto.Location = new System.Drawing.Point(6, 53);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(240, 29);
            this.cboConcepto.TabIndex = 3;
            this.cboConcepto.UseSelectable = true;
            this.cboConcepto.SelectedIndexChanged += new System.EventHandler(this.cboConcepto_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Concepto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[] {
        "0.00"};
            this.txtPrecio.Location = new System.Drawing.Point(252, 59);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PromptText = "Ingrese nombre del grado";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(46, 23);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMark = "Ingrese nombre del grado";
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(297, 31);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.Lines = new string[] {
        "1"};
            this.txtCantidad.Location = new System.Drawing.Point(304, 59);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PromptText = "Ingrese nombre del grado";
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(39, 23);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Text = "1";
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMark = "Ingrese nombre del grado";
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(245, 31);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Precio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDetalle);
            this.groupBox4.Location = new System.Drawing.Point(23, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 159);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle deudas";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCONCEPTO,
            this.CONCEPTO,
            this.PRECIO,
            this.CANTIDAD,
            this.IMPORTE});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle.RowHeadersWidth = 30;
            this.dgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(539, 140);
            this.dgvDetalle.TabIndex = 1;
            // 
            // IDCONCEPTO
            // 
            this.IDCONCEPTO.DataPropertyName = "IDCONCEPTO";
            this.IDCONCEPTO.HeaderText = "IDCONCEPTO";
            this.IDCONCEPTO.Name = "IDCONCEPTO";
            this.IDCONCEPTO.ReadOnly = true;
            this.IDCONCEPTO.Visible = false;
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.DataPropertyName = "CONCEPTO";
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            this.CONCEPTO.ReadOnly = true;
            this.CONCEPTO.Width = 230;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle8;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRECIO.Width = 80;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.NullValue = "0";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle9;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 80;
            // 
            // IMPORTE
            // 
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle10;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // gbBuscarAlumno
            // 
            this.gbBuscarAlumno.Controls.Add(this.metroLabel1);
            this.gbBuscarAlumno.Controls.Add(this.metroLabel4);
            this.gbBuscarAlumno.Controls.Add(this.btnBuscar);
            this.gbBuscarAlumno.Controls.Add(this.txtNombres);
            this.gbBuscarAlumno.Controls.Add(this.txtFiltro);
            this.gbBuscarAlumno.Enabled = false;
            this.gbBuscarAlumno.Location = new System.Drawing.Point(23, 63);
            this.gbBuscarAlumno.Name = "gbBuscarAlumno";
            this.gbBuscarAlumno.Size = new System.Drawing.Size(545, 102);
            this.gbBuscarAlumno.TabIndex = 3;
            this.gbBuscarAlumno.TabStop = false;
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "DNI :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 34);
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
            this.txtFiltro.MaxLength = 8;
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
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(101, 443);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 35);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(232, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Grabar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(363, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(349, 53);
            this.dtpFechaRegistro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(112, 29);
            this.dtpFechaRegistro.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(360, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Fecha registro";
            // 
            // frmGeneraDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 497);
            this.Controls.Add(this.gbBuscarAlumno);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbCabeceraAlumno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneraDeuda";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Generador de deudas:::...";
            this.Load += new System.EventHandler(this.frmGeneraDeuda_Load);
            this.gbCabeceraAlumno.ResumeLayout(false);
            this.gbCabeceraAlumno.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbBuscarAlumno.ResumeLayout(false);
            this.gbBuscarAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCabeceraAlumno;
        private MetroFramework.Controls.MetroComboBox cboConcepto;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnQuitar;
        private System.Windows.Forms.GroupBox gbBuscarAlumno;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroGrid dgvDetalle;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private MetroFramework.Controls.MetroDateTime dtpFechaRegistro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}