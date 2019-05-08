namespace GUI_SEVILLA
{
    partial class frmBuscaSeccion
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
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.dgvSeccion = new MetroFramework.Controls.MetroGrid();
            this.IDSECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROVACANTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salirsistema;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(475, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSECCION,
            this.GRADO,
            this.NIVEL,
            this.SECCION,
            this.TURNO,
            this.NUMEROVACANTES,
            this.ANIO,
            this.FASE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeccion.EnableHeadersVisualStyles = false;
            this.dgvSeccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSeccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSeccion.Location = new System.Drawing.Point(3, 16);
            this.dgvSeccion.Name = "dgvSeccion";
            this.dgvSeccion.ReadOnly = true;
            this.dgvSeccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSeccion.RowHeadersWidth = 30;
            this.dgvSeccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeccion.Size = new System.Drawing.Size(548, 338);
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
            // GRADO
            // 
            this.GRADO.DataPropertyName = "GRADO";
            this.GRADO.HeaderText = "GRADO";
            this.GRADO.Name = "GRADO";
            this.GRADO.ReadOnly = true;
            this.GRADO.Width = 70;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NIVEL.DefaultCellStyle = dataGridViewCellStyle2;
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            this.NIVEL.Width = 70;
            // 
            // SECCION
            // 
            this.SECCION.DataPropertyName = "SECCION";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SECCION.DefaultCellStyle = dataGridViewCellStyle3;
            this.SECCION.HeaderText = "SECCION";
            this.SECCION.Name = "SECCION";
            this.SECCION.ReadOnly = true;
            this.SECCION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SECCION.Width = 70;
            // 
            // TURNO
            // 
            this.TURNO.DataPropertyName = "TURNO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TURNO.DefaultCellStyle = dataGridViewCellStyle4;
            this.TURNO.HeaderText = "TURNO";
            this.TURNO.Name = "TURNO";
            this.TURNO.ReadOnly = true;
            this.TURNO.Width = 70;
            // 
            // NUMEROVACANTES
            // 
            this.NUMEROVACANTES.DataPropertyName = "NUMEROVACANTES";
            this.NUMEROVACANTES.HeaderText = "NUMERO VACANTES";
            this.NUMEROVACANTES.Name = "NUMEROVACANTES";
            this.NUMEROVACANTES.ReadOnly = true;
            this.NUMEROVACANTES.Width = 70;
            // 
            // ANIO
            // 
            this.ANIO.DataPropertyName = "ANIO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ANIO.DefaultCellStyle = dataGridViewCellStyle5;
            this.ANIO.HeaderText = "ANIO";
            this.ANIO.Name = "ANIO";
            this.ANIO.ReadOnly = true;
            this.ANIO.Width = 80;
            // 
            // FASE
            // 
            this.FASE.DataPropertyName = "FASE";
            this.FASE.HeaderText = "FASE";
            this.FASE.Name = "FASE";
            this.FASE.ReadOnly = true;
            this.FASE.Width = 80;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.agregar_;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(23, 426);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSeccion);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 357);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.Location = new System.Drawing.Point(512, 466);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(27, 15);
            this.metroLabel15.TabIndex = 35;
            this.metroLabel15.Text = "Salir";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(34, 464);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 15);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Agregar";
            // 
            // frmBuscaSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 501);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaSeccion";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Búsqueda de secciones:::...";
            this.Load += new System.EventHandler(this.frmBuscaSeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroGrid dgvSeccion;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROVACANTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FASE;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}