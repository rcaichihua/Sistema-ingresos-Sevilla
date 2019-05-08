namespace GUI_SEVILLA
{
    partial class frmPagosListado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListadoRecibos = new MetroFramework.Controls.MetroGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.rbTodos = new MetroFramework.Controls.MetroRadioButton();
            this.rbAnulado = new MetroFramework.Controls.MetroRadioButton();
            this.rbActivos = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new MetroFramework.Controls.MetroDateTime();
            this.dtpDesde = new MetroFramework.Controls.MetroDateTime();
            this.txtNroRecibo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblEncabezado = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btnVerRecibo = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnAnularRecibo = new MetroFramework.Controls.MetroButton();
            this.btnDetalle = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSoles = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblCantidadRegistros = new MetroFramework.Controls.MetroLabel();
            this.IDRECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERORECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHARECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODALIDADPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_ENTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTERECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoRecibos
            // 
            this.dgvListadoRecibos.AllowUserToAddRows = false;
            this.dgvListadoRecibos.AllowUserToDeleteRows = false;
            this.dgvListadoRecibos.AllowUserToResizeRows = false;
            this.dgvListadoRecibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoRecibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoRecibos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListadoRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvListadoRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRECIBO,
            this.TIPO,
            this.NUMERORECIBO,
            this.FECHARECIBO,
            this.NOMBRES,
            this.IDMATRICULA,
            this.MODALIDADPAGO,
            this.NOMBRE_ENTIDAD,
            this.IMPORTERECIBO,
            this.ESTADO});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoRecibos.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvListadoRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoRecibos.EnableHeadersVisualStyles = false;
            this.dgvListadoRecibos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListadoRecibos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoRecibos.Location = new System.Drawing.Point(3, 16);
            this.dgvListadoRecibos.Name = "dgvListadoRecibos";
            this.dgvListadoRecibos.ReadOnly = true;
            this.dgvListadoRecibos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvListadoRecibos.RowHeadersWidth = 20;
            this.dgvListadoRecibos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoRecibos.Size = new System.Drawing.Size(787, 298);
            this.dgvListadoRecibos.TabIndex = 1;
            this.dgvListadoRecibos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListadoRecibos_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Label3);
            this.groupBox3.Controls.Add(this.Label4);
            this.groupBox3.Controls.Add(this.rbTodos);
            this.groupBox3.Controls.Add(this.rbAnulado);
            this.groupBox3.Controls.Add(this.rbActivos);
            this.groupBox3.Location = new System.Drawing.Point(600, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 77);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado de los recibos";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LightCoral;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.Location = new System.Drawing.Point(91, 38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 17);
            this.Label3.TabIndex = 85;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Location = new System.Drawing.Point(91, 19);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 17);
            this.Label4.TabIndex = 86;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(137, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 15);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseSelectable = true;
            // 
            // rbAnulado
            // 
            this.rbAnulado.AutoSize = true;
            this.rbAnulado.Location = new System.Drawing.Point(6, 40);
            this.rbAnulado.Name = "rbAnulado";
            this.rbAnulado.Size = new System.Drawing.Size(73, 15);
            this.rbAnulado.TabIndex = 6;
            this.rbAnulado.Text = "Anulados";
            this.rbAnulado.UseSelectable = true;
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Checked = true;
            this.rbActivos.Location = new System.Drawing.Point(6, 19);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(62, 15);
            this.rbActivos.TabIndex = 6;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.txtNroRecibo);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(438, 35);
            this.dtpHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(111, 29);
            this.dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(321, 35);
            this.dtpDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(111, 29);
            this.dtpDesde.TabIndex = 7;
            // 
            // txtNroRecibo
            // 
            this.txtNroRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNroRecibo.CustomButton.Image = null;
            this.txtNroRecibo.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtNroRecibo.CustomButton.Name = "";
            this.txtNroRecibo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroRecibo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroRecibo.CustomButton.TabIndex = 1;
            this.txtNroRecibo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroRecibo.CustomButton.UseSelectable = true;
            this.txtNroRecibo.CustomButton.Visible = false;
            this.txtNroRecibo.Lines = new string[0];
            this.txtNroRecibo.Location = new System.Drawing.Point(6, 35);
            this.txtNroRecibo.MaxLength = 32767;
            this.txtNroRecibo.Name = "txtNroRecibo";
            this.txtNroRecibo.PasswordChar = '\0';
            this.txtNroRecibo.WaterMark = "Ingrese Nº recibo";
            this.txtNroRecibo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroRecibo.SelectedText = "";
            this.txtNroRecibo.SelectionLength = 0;
            this.txtNroRecibo.SelectionStart = 0;
            this.txtNroRecibo.ShortcutsEnabled = true;
            this.txtNroRecibo.Size = new System.Drawing.Size(107, 23);
            this.txtNroRecibo.TabIndex = 0;
            this.txtNroRecibo.UseSelectable = true;
            this.txtNroRecibo.WaterMark = "Ingrese Nº recibo";
            this.txtNroRecibo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroRecibo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(438, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Hasta";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(325, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Desde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Nº Recibo";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.Lines = new string[0];
            this.txtNombres.Location = new System.Drawing.Point(119, 35);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.WaterMark = "Ingrese nombres para el filtro";
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.Size = new System.Drawing.Size(196, 23);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.UseSelectable = true;
            this.txtNombres.WaterMark = "Ingrese nombres para el filtro";
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(119, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nombres";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEncabezado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEncabezado.Location = new System.Drawing.Point(23, 60);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(808, 31);
            this.lblEncabezado.TabIndex = 21;
            this.lblEncabezado.Text = ": : : : RECIBOS EMITIDOS : : : : ";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.Location = new System.Drawing.Point(810, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListadoRecibos);
            this.groupBox2.Location = new System.Drawing.Point(23, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 317);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnSalir);
            this.GBOpciones.Controls.Add(this.btnDetalle);
            this.GBOpciones.Controls.Add(this.btnAnularRecibo);
            this.GBOpciones.Controls.Add(this.btnVerRecibo);
            this.GBOpciones.Controls.Add(this.metroLabel8);
            this.GBOpciones.Controls.Add(this.metroLabel7);
            this.GBOpciones.Controls.Add(this.metroLabel6);
            this.GBOpciones.Controls.Add(this.metroLabel5);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(822, 177);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(85, 317);
            this.GBOpciones.TabIndex = 98;
            this.GBOpciones.TabStop = false;
            // 
            // btnVerRecibo
            // 
            this.btnVerRecibo.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.verrecibo;
            this.btnVerRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerRecibo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVerRecibo.Location = new System.Drawing.Point(6, 16);
            this.btnVerRecibo.Name = "btnVerRecibo";
            this.btnVerRecibo.Size = new System.Drawing.Size(61, 42);
            this.btnVerRecibo.TabIndex = 1;
            this.btnVerRecibo.UseSelectable = true;
            this.btnVerRecibo.Click += new System.EventHandler(this.btnVerRecibo_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(6, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 15);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Ver Recibo";
            // 
            // btnAnularRecibo
            // 
            this.btnAnularRecibo.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.anular;
            this.btnAnularRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnularRecibo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAnularRecibo.Location = new System.Drawing.Point(6, 79);
            this.btnAnularRecibo.Name = "btnAnularRecibo";
            this.btnAnularRecibo.Size = new System.Drawing.Size(61, 42);
            this.btnAnularRecibo.TabIndex = 1;
            this.btnAnularRecibo.UseSelectable = true;
            this.btnAnularRecibo.Click += new System.EventHandler(this.btnAnularRecibo_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.verdetalle;
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetalle.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDetalle.Location = new System.Drawing.Point(6, 146);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(61, 42);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.UseSelectable = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(8, 246);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 42);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(5, 124);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 15);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Anular Recibo";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(8, 191);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 15);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Ver detalle";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(26, 291);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(27, 15);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Salir";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(835, 148);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 15);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Buscar";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(511, 511);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(147, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "TOTAL IMPORTE SOLES";
            // 
            // lblTotalSoles
            // 
            this.lblTotalSoles.AutoSize = true;
            this.lblTotalSoles.Location = new System.Drawing.Point(737, 511);
            this.lblTotalSoles.Name = "lblTotalSoles";
            this.lblTotalSoles.Size = new System.Drawing.Size(33, 19);
            this.lblTotalSoles.TabIndex = 6;
            this.lblTotalSoles.Text = "0.00";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 511);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(223, 19);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Número total de pagos encontrados";
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(267, 511);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(16, 19);
            this.lblCantidadRegistros.TabIndex = 6;
            this.lblCantidadRegistros.Text = "0";
            // 
            // IDRECIBO
            // 
            this.IDRECIBO.DataPropertyName = "IDRECIBO";
            this.IDRECIBO.HeaderText = "IDRECIBO";
            this.IDRECIBO.Name = "IDRECIBO";
            this.IDRECIBO.ReadOnly = true;
            this.IDRECIBO.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle29;
            this.TIPO.HeaderText = "DOCUMENTO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 80;
            // 
            // NUMERORECIBO
            // 
            this.NUMERORECIBO.DataPropertyName = "NUMERORECIBO";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NUMERORECIBO.DefaultCellStyle = dataGridViewCellStyle30;
            this.NUMERORECIBO.HeaderText = "NUMERO RECIBO";
            this.NUMERORECIBO.Name = "NUMERORECIBO";
            this.NUMERORECIBO.ReadOnly = true;
            this.NUMERORECIBO.Width = 110;
            // 
            // FECHARECIBO
            // 
            this.FECHARECIBO.DataPropertyName = "FECHARECIBO";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHARECIBO.DefaultCellStyle = dataGridViewCellStyle31;
            this.FECHARECIBO.HeaderText = "FECHA RECIBO";
            this.FECHARECIBO.Name = "FECHARECIBO";
            this.FECHARECIBO.ReadOnly = true;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "ALUMNA";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 250;
            // 
            // IDMATRICULA
            // 
            this.IDMATRICULA.DataPropertyName = "IDMATRICULA";
            this.IDMATRICULA.HeaderText = "IDMATRICULA";
            this.IDMATRICULA.Name = "IDMATRICULA";
            this.IDMATRICULA.ReadOnly = true;
            this.IDMATRICULA.Visible = false;
            // 
            // MODALIDADPAGO
            // 
            this.MODALIDADPAGO.DataPropertyName = "MODALIDADPAGO";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODALIDADPAGO.DefaultCellStyle = dataGridViewCellStyle32;
            this.MODALIDADPAGO.HeaderText = "MODALIDADPAGO";
            this.MODALIDADPAGO.Name = "MODALIDADPAGO";
            this.MODALIDADPAGO.ReadOnly = true;
            this.MODALIDADPAGO.Visible = false;
            // 
            // NOMBRE_ENTIDAD
            // 
            this.NOMBRE_ENTIDAD.DataPropertyName = "NOMBRE_ENTIDAD";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOMBRE_ENTIDAD.DefaultCellStyle = dataGridViewCellStyle33;
            this.NOMBRE_ENTIDAD.HeaderText = "BANCO";
            this.NOMBRE_ENTIDAD.Name = "NOMBRE_ENTIDAD";
            this.NOMBRE_ENTIDAD.ReadOnly = true;
            // 
            // IMPORTERECIBO
            // 
            this.IMPORTERECIBO.DataPropertyName = "IMPORTERECIBO";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N2";
            this.IMPORTERECIBO.DefaultCellStyle = dataGridViewCellStyle34;
            this.IMPORTERECIBO.HeaderText = "IMPORTE";
            this.IMPORTERECIBO.Name = "IMPORTERECIBO";
            this.IMPORTERECIBO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // frmPagosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 550);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.lblTotalSoles);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.MaximizeBox = false;
            this.Name = "frmPagosListado";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Listado de recibos:::...";
            this.Load += new System.EventHandler(this.frmPagosListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GBOpciones.ResumeLayout(false);
            this.GBOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvListadoRecibos;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton rbTodos;
        private MetroFramework.Controls.MetroRadioButton rbAnulado;
        private MetroFramework.Controls.MetroRadioButton rbActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroTextBox txtNroRecibo;
        private MetroFramework.Controls.MetroLabel lblEncabezado;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtpHasta;
        private MetroFramework.Controls.MetroDateTime dtpDesde;
        private MetroFramework.Controls.MetroButton btnBuscar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox GBOpciones;
        private MetroFramework.Controls.MetroButton btnVerRecibo;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnDetalle;
        private MetroFramework.Controls.MetroButton btnAnularRecibo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblTotalSoles;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblCantidadRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERORECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHARECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODALIDADPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ENTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTERECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}