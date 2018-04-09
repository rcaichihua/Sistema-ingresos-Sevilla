namespace GUI_SEVILLA
{
    partial class frmListadoAlumnosMatriculados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAlumnosMatriculados = new MetroFramework.Controls.MetroGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInactivos = new MetroFramework.Controls.MetroRadioButton();
            this.rbActivos = new MetroFramework.Controls.MetroRadioButton();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnActivar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnDarDeBaja = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.lblEncabezado = new MetroFramework.Controls.MetroLabel();
            this.IDMATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LETRASECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAREGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIOCREADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosMatriculados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAlumnosMatriculados);
            this.groupBox1.Location = new System.Drawing.Point(23, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvAlumnosMatriculados
            // 
            this.dgvAlumnosMatriculados.AllowUserToAddRows = false;
            this.dgvAlumnosMatriculados.AllowUserToDeleteRows = false;
            this.dgvAlumnosMatriculados.AllowUserToResizeRows = false;
            this.dgvAlumnosMatriculados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAlumnosMatriculados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnosMatriculados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlumnosMatriculados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnosMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnosMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosMatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMATRICULA,
            this.CODMATRICULA,
            this.DNI,
            this.NOMBRES,
            this.NIVEL,
            this.LETRASECCION,
            this.FECHAINGRESO,
            this.FECHAREGISTRO,
            this.USUARIOCREADOR,
            this.ESTADO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnosMatriculados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnosMatriculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnosMatriculados.EnableHeadersVisualStyles = false;
            this.dgvAlumnosMatriculados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAlumnosMatriculados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAlumnosMatriculados.Location = new System.Drawing.Point(3, 16);
            this.dgvAlumnosMatriculados.Name = "dgvAlumnosMatriculados";
            this.dgvAlumnosMatriculados.ReadOnly = true;
            this.dgvAlumnosMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnosMatriculados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlumnosMatriculados.RowHeadersWidth = 30;
            this.dgvAlumnosMatriculados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlumnosMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosMatriculados.Size = new System.Drawing.Size(904, 351);
            this.dgvAlumnosMatriculados.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtFiltro);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(23, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInactivos);
            this.groupBox3.Controls.Add(this.rbActivos);
            this.groupBox3.Location = new System.Drawing.Point(319, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Location = new System.Drawing.Point(28, 40);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(70, 15);
            this.rbInactivos.TabIndex = 0;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseSelectable = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.rbInactivos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Checked = true;
            this.rbActivos.Location = new System.Drawing.Point(28, 19);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(62, 15);
            this.rbActivos.TabIndex = 0;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseSelectable = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(17, 52);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Ingrese nombre o DNI para la búsqueda";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(296, 23);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Ingrese nombre o DNI para la búsqueda";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Alumno :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnActivar);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.btnDarDeBaja);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.btnNuevo);
            this.groupBox4.Location = new System.Drawing.Point(506, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 106);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(182, 61);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Enabled = false;
            this.btnActivar.Location = new System.Drawing.Point(101, 61);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 39);
            this.btnActivar.TabIndex = 0;
            this.btnActivar.Text = "&Activar";
            this.btnActivar.UseSelectable = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 61);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 39);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Location = new System.Drawing.Point(182, 17);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(75, 36);
            this.btnDarDeBaja.TabIndex = 0;
            this.btnDarDeBaja.Text = "&Dar baja";
            this.btnDarDeBaja.UseSelectable = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(101, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEncabezado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEncabezado.Location = new System.Drawing.Point(23, 60);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(740, 31);
            this.lblEncabezado.TabIndex = 14;
            this.lblEncabezado.Text = "metroLabel1";
            // 
            // IDMATRICULA
            // 
            this.IDMATRICULA.DataPropertyName = "IDMATRICULA";
            this.IDMATRICULA.HeaderText = "IDMATRICULA";
            this.IDMATRICULA.Name = "IDMATRICULA";
            this.IDMATRICULA.ReadOnly = true;
            this.IDMATRICULA.Visible = false;
            // 
            // CODMATRICULA
            // 
            this.CODMATRICULA.DataPropertyName = "CODMATRICULA";
            this.CODMATRICULA.HeaderText = "CODIGO MATRICULA";
            this.CODMATRICULA.Name = "CODMATRICULA";
            this.CODMATRICULA.ReadOnly = true;
            this.CODMATRICULA.Width = 90;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 80;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.NOMBRES.DefaultCellStyle = dataGridViewCellStyle2;
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 200;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            this.NIVEL.Width = 150;
            // 
            // LETRASECCION
            // 
            this.LETRASECCION.DataPropertyName = "LETRASECCION";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.LETRASECCION.DefaultCellStyle = dataGridViewCellStyle3;
            this.LETRASECCION.HeaderText = "SECCION";
            this.LETRASECCION.Name = "LETRASECCION";
            this.LETRASECCION.ReadOnly = true;
            this.LETRASECCION.Width = 70;
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.DataPropertyName = "FECHAINGRESO";
            this.FECHAINGRESO.HeaderText = "FECHA INGRESO";
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            this.FECHAINGRESO.ReadOnly = true;
            // 
            // FECHAREGISTRO
            // 
            this.FECHAREGISTRO.DataPropertyName = "FECHAREGISTRO";
            this.FECHAREGISTRO.HeaderText = "FECHA REGISTRO";
            this.FECHAREGISTRO.Name = "FECHAREGISTRO";
            this.FECHAREGISTRO.ReadOnly = true;
            // 
            // USUARIOCREADOR
            // 
            this.USUARIOCREADOR.DataPropertyName = "USUARIOCREADOR";
            this.USUARIOCREADOR.HeaderText = "USUARIO CREADOR";
            this.USUARIOCREADOR.Name = "USUARIOCREADOR";
            this.USUARIOCREADOR.ReadOnly = true;
            this.USUARIOCREADOR.Width = 80;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.FalseValue = "0";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.IndeterminateValue = "0";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.TrueValue = "1";
            this.ESTADO.Visible = false;
            // 
            // frmListadoAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 599);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoAlumnosMatriculados";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Lista de alumnos matriculados:::...";
            this.Load += new System.EventHandler(this.frmListadoAlumnosMatriculados_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosMatriculados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgvAlumnosMatriculados;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton rbInactivos;
        private MetroFramework.Controls.MetroRadioButton rbActivos;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnActivar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnDarDeBaja;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel lblEncabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LETRASECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAREGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIOCREADOR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ESTADO;
    }
}