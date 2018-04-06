namespace GUI_SEVILLA
{
    partial class frmListadoSeccion
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
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSeccion = new MetroFramework.Controls.MetroGrid();
            this.IDSECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIONGRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LETRASECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODAULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROVACANTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIONFASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitulo.Location = new System.Drawing.Point(23, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(619, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "metroLabel1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(522, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(131, 449);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 449);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 35);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSeccion);
            this.groupBox1.Location = new System.Drawing.Point(23, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 357);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dgvSeccion
            // 
            this.dgvSeccion.AllowUserToAddRows = false;
            this.dgvSeccion.AllowUserToDeleteRows = false;
            this.dgvSeccion.AllowUserToResizeRows = false;
            this.dgvSeccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSeccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSECCION,
            this.IDGRADO,
            this.DESCRIPCIONGRADO,
            this.NIVEL,
            this.LETRASECCION,
            this.TURNO,
            this.CODAULA,
            this.NUMEROVACANTES,
            this.IDFASE,
            this.DESCRIPCIONFASE});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeccion.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeccion.EnableHeadersVisualStyles = false;
            this.dgvSeccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSeccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSeccion.Location = new System.Drawing.Point(3, 16);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.ReadOnly = true;
            this.dgvSeccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSeccion.RowHeadersWidth = 30;
            this.dgvSeccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeccion.Size = new System.Drawing.Size(595, 338);
            this.dgvSeccion.TabIndex = 0;
            // 
            // IDSECCION
            // 
            this.IDSECCION.DataPropertyName = "IDSECCION";
            this.IDSECCION.HeaderText = "IDSECCION";
            this.IDSECCION.Name = "IDSECCION";
            this.IDSECCION.ReadOnly = true;
            this.IDSECCION.Visible = false;
            // 
            // IDGRADO
            // 
            this.IDGRADO.DataPropertyName = "IDGRADO";
            this.IDGRADO.HeaderText = "IDGRADO";
            this.IDGRADO.Name = "IDGRADO";
            this.IDGRADO.ReadOnly = true;
            this.IDGRADO.Visible = false;
            this.IDGRADO.Width = 250;
            // 
            // DESCRIPCIONGRADO
            // 
            this.DESCRIPCIONGRADO.DataPropertyName = "DESCRIPCIONGRADO";
            this.DESCRIPCIONGRADO.HeaderText = "GRADO";
            this.DESCRIPCIONGRADO.Name = "DESCRIPCIONGRADO";
            this.DESCRIPCIONGRADO.ReadOnly = true;
            this.DESCRIPCIONGRADO.Width = 70;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NIVEL.DefaultCellStyle = dataGridViewCellStyle8;
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            this.NIVEL.Width = 70;
            // 
            // LETRASECCION
            // 
            this.LETRASECCION.DataPropertyName = "LETRASECCION";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.LETRASECCION.DefaultCellStyle = dataGridViewCellStyle9;
            this.LETRASECCION.HeaderText = "LETRA SECCION";
            this.LETRASECCION.Name = "LETRASECCION";
            this.LETRASECCION.ReadOnly = true;
            this.LETRASECCION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LETRASECCION.Width = 70;
            // 
            // TURNO
            // 
            this.TURNO.DataPropertyName = "TURNO";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TURNO.DefaultCellStyle = dataGridViewCellStyle10;
            this.TURNO.HeaderText = "TURNO";
            this.TURNO.Name = "TURNO";
            this.TURNO.ReadOnly = true;
            this.TURNO.Width = 70;
            // 
            // CODAULA
            // 
            this.CODAULA.DataPropertyName = "CODAULA";
            this.CODAULA.HeaderText = "CODIGO AULA";
            this.CODAULA.Name = "CODAULA";
            this.CODAULA.ReadOnly = true;
            // 
            // NUMEROVACANTES
            // 
            this.NUMEROVACANTES.DataPropertyName = "NUMEROVACANTES";
            this.NUMEROVACANTES.HeaderText = "NUMERO VACANTES";
            this.NUMEROVACANTES.Name = "NUMEROVACANTES";
            this.NUMEROVACANTES.ReadOnly = true;
            // 
            // IDFASE
            // 
            this.IDFASE.DataPropertyName = "IDFASE";
            this.IDFASE.HeaderText = "IDFASE";
            this.IDFASE.Name = "IDFASE";
            this.IDFASE.ReadOnly = true;
            this.IDFASE.Visible = false;
            // 
            // DESCRIPCIONFASE
            // 
            this.DESCRIPCIONFASE.DataPropertyName = "DESCRIPCIONFASE";
            this.DESCRIPCIONFASE.HeaderText = "FASE";
            this.DESCRIPCIONFASE.Name = "DESCRIPCIONFASE";
            this.DESCRIPCIONFASE.ReadOnly = true;
            this.DESCRIPCIONFASE.Width = 70;
            // 
            // frmListadoSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 498);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoSeccion";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Listado de secciones:::...";
            this.Load += new System.EventHandler(this.frmListadoSeccion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgvSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIONGRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LETRASECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODAULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROVACANTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIONFASE;
    }
}