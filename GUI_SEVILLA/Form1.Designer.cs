namespace GUI_SEVILLA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtNroClase = new System.Windows.Forms.TextBox();
            this.dtpFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.cboTipoFacturacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizaVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE DEL ARCHIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC EMPRESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NRO CLASE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FECHA FACTURACION(***)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MONEDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "VERSION(**)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TIPO DE FACTURACION(*)";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(177, 13);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(389, 20);
            this.txtNombreArchivo.TabIndex = 2;
            this.txtNombreArchivo.Text = "BENEFICIENCIA_DE_LIMA_PEN_20170518.TXT";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(177, 39);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(166, 20);
            this.txtRuc.TabIndex = 2;
            this.txtRuc.Text = "20135604551";
            // 
            // txtNroClase
            // 
            this.txtNroClase.Location = new System.Drawing.Point(177, 65);
            this.txtNroClase.Name = "txtNroClase";
            this.txtNroClase.ReadOnly = true;
            this.txtNroClase.Size = new System.Drawing.Size(71, 20);
            this.txtNroClase.TabIndex = 2;
            this.txtNroClase.Text = "400";
            // 
            // dtpFechaFacturacion
            // 
            this.dtpFechaFacturacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFacturacion.Location = new System.Drawing.Point(177, 91);
            this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            this.dtpFechaFacturacion.Size = new System.Drawing.Size(113, 20);
            this.dtpFechaFacturacion.TabIndex = 3;
            this.dtpFechaFacturacion.ValueChanged += new System.EventHandler(this.dtpFechaFacturacion_ValueChanged);
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Items.AddRange(new object[] {
            "PEN"});
            this.cboMoneda.Location = new System.Drawing.Point(177, 117);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(113, 21);
            this.cboMoneda.TabIndex = 4;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(177, 144);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(71, 20);
            this.txtVersion.TabIndex = 2;
            this.txtVersion.Text = "000";
            // 
            // cboTipoFacturacion
            // 
            this.cboTipoFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFacturacion.FormattingEnabled = true;
            this.cboTipoFacturacion.Items.AddRange(new object[] {
            "T",
            "P",
            "E"});
            this.cboTipoFacturacion.Location = new System.Drawing.Point(177, 170);
            this.cboTipoFacturacion.Name = "cboTipoFacturacion";
            this.cboTipoFacturacion.Size = new System.Drawing.Size(113, 21);
            this.cboTipoFacturacion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ruta destino Archivos: Mis Documentos.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ruta de Lectura Archivos : C\\BBVA\\";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(341, 117);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(41, 13);
            this.lblArchivo.TabIndex = 6;
            this.lblArchivo.Text = "label10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Archivo Soles: DeudaSevilla.TXT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 104);
            this.label12.TabIndex = 6;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnActualizaVersion);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblArchivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboTipoFacturacion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboMoneda);
            this.groupBox1.Controls.Add(this.txtNombreArchivo);
            this.groupBox1.Controls.Add(this.dtpFechaFacturacion);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.txtNroClase);
            this.groupBox1.Location = new System.Drawing.Point(23, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 357);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnActualizaVersion
            // 
            this.btnActualizaVersion.Image = global::GUI_SEVILLA.Properties.Resources.actualizarusuario;
            this.btnActualizaVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizaVersion.Location = new System.Drawing.Point(254, 140);
            this.btnActualizaVersion.Name = "btnActualizaVersion";
            this.btnActualizaVersion.Size = new System.Drawing.Size(128, 27);
            this.btnActualizaVersion.TabIndex = 0;
            this.btnActualizaVersion.Text = "&Actualiza Version";
            this.btnActualizaVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaVersion.UseVisualStyleBackColor = true;
            this.btnActualizaVersion.Click += new System.EventHandler(this.btnActualizaVersion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 436);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Generación de Archivo TXT para el BBVA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtNroClase;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturacion;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.ComboBox cboTipoFacturacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizaVersion;
    }
}

