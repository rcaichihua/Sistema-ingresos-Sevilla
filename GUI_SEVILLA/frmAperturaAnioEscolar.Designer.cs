namespace GUI_SEVILLA
{
    partial class frmAperturaAnioEscolar
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
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboFase = new MetroFramework.Controls.MetroComboBox();
            this.cboFinMes = new MetroFramework.Controls.MetroComboBox();
            this.cboInicioMes = new MetroFramework.Controls.MetroComboBox();
            this.cboAnio = new MetroFramework.Controls.MetroComboBox();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.chkAperturar = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.procesar;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerar.Location = new System.Drawing.Point(172, 229);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(102, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salirsistema;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(280, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cboFase);
            this.groupBox1.Controls.Add(this.cboFinMes);
            this.groupBox1.Controls.Add(this.cboInicioMes);
            this.groupBox1.Controls.Add(this.cboAnio);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.chkAperturar);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Observaciones :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(287, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Fase :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(287, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Hasta";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Desde";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Año apertura :";
            // 
            // cboFase
            // 
            this.cboFase.FormattingEnabled = true;
            this.cboFase.ItemHeight = 23;
            this.cboFase.Location = new System.Drawing.Point(334, 18);
            this.cboFase.Name = "cboFase";
            this.cboFase.Size = new System.Drawing.Size(158, 29);
            this.cboFase.TabIndex = 31;
            this.cboFase.UseSelectable = true;
            // 
            // cboFinMes
            // 
            this.cboFinMes.FormattingEnabled = true;
            this.cboFinMes.ItemHeight = 23;
            this.cboFinMes.Items.AddRange(new object[] {
            "1 .-ENERO",
            "2 .-FEBRERO",
            "3 .-MARZO",
            "4 .-ABRIL",
            "5 .-MAYO",
            "6 .-JUNIO",
            "7 .-JULIO",
            "8 .-AGOSTO",
            "9 .-NOVIEMBRE",
            "10.-OCTUBRE",
            "11.-NOVIEMBRE",
            "12.-DICIEMBRE"});
            this.cboFinMes.Location = new System.Drawing.Point(334, 74);
            this.cboFinMes.Name = "cboFinMes";
            this.cboFinMes.Size = new System.Drawing.Size(130, 29);
            this.cboFinMes.TabIndex = 31;
            this.cboFinMes.UseSelectable = true;
            // 
            // cboInicioMes
            // 
            this.cboInicioMes.FormattingEnabled = true;
            this.cboInicioMes.ItemHeight = 23;
            this.cboInicioMes.Items.AddRange(new object[] {
            "1 .-ENERO",
            "2 .-FEBRERO",
            "3 .-MARZO",
            "4 .-ABRIL",
            "5 .-MAYO",
            "6 .-JUNIO",
            "7 .-JULIO",
            "8 .-AGOSTO",
            "9 .-NOVIEMBRE",
            "10.-OCTUBRE",
            "11.-NOVIEMBRE",
            "12.-DICIEMBRE"});
            this.cboInicioMes.Location = new System.Drawing.Point(117, 74);
            this.cboInicioMes.Name = "cboInicioMes";
            this.cboInicioMes.Size = new System.Drawing.Size(130, 29);
            this.cboInicioMes.TabIndex = 31;
            this.cboInicioMes.UseSelectable = true;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.ItemHeight = 23;
            this.cboAnio.Location = new System.Drawing.Point(117, 18);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(130, 29);
            this.cboAnio.TabIndex = 31;
            this.cboAnio.UseSelectable = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtObservaciones.CustomButton.Image = null;
            this.txtObservaciones.CustomButton.Location = new System.Drawing.Point(339, 2);
            this.txtObservaciones.CustomButton.Name = "";
            this.txtObservaciones.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservaciones.CustomButton.TabIndex = 1;
            this.txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservaciones.CustomButton.UseSelectable = true;
            this.txtObservaciones.CustomButton.Visible = false;
            this.txtObservaciones.Lines = new string[0];
            this.txtObservaciones.Location = new System.Drawing.Point(117, 109);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.WaterMark = "Ingrese algunas observaciones adicionales";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(375, 38);
            this.txtObservaciones.TabIndex = 5;
            this.txtObservaciones.UseSelectable = true;
            this.txtObservaciones.WaterMark = "Ingrese algunas observaciones adicionales";
            this.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkAperturar
            // 
            this.chkAperturar.AutoSize = true;
            this.chkAperturar.Checked = true;
            this.chkAperturar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAperturar.Enabled = false;
            this.chkAperturar.Location = new System.Drawing.Point(117, 53);
            this.chkAperturar.Name = "chkAperturar";
            this.chkAperturar.Size = new System.Drawing.Size(73, 15);
            this.chkAperturar.TabIndex = 4;
            this.chkAperturar.Text = "Aperturar";
            this.chkAperturar.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(174, 267);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 15);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Generar Apertura";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(316, 267);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(27, 15);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Salir";
            // 
            // frmAperturaAnioEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 292);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAperturaAnioEscolar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Apertura del año escolar:::...";
            this.Load += new System.EventHandler(this.frmAperturaAnioEscolar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroCheckBox chkAperturar;
        private MetroFramework.Controls.MetroComboBox cboAnio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboFase;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboFinMes;
        private MetroFramework.Controls.MetroComboBox cboInicioMes;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}