namespace GUI_SEVILLA
{
    partial class frmMantenimientoConcepto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtConcepto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtImporteReferencial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreConcepto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.cboCuentaContable = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtImporteReferencial);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtNombreConcepto);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.cboCuentaContable);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 154);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Observaciones  :";
            // 
            // txtConcepto
            // 
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtConcepto.CustomButton.Image = null;
            this.txtConcepto.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConcepto.CustomButton.Name = "";
            this.txtConcepto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConcepto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConcepto.CustomButton.TabIndex = 1;
            this.txtConcepto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConcepto.CustomButton.UseSelectable = true;
            this.txtConcepto.CustomButton.Visible = false;
            this.txtConcepto.Lines = new string[0];
            this.txtConcepto.Location = new System.Drawing.Point(148, 19);
            this.txtConcepto.MaxLength = 8;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.PasswordChar = '\0';
            this.txtConcepto.WaterMark = "Codigo Concepto";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConcepto.SelectedText = "";
            this.txtConcepto.SelectionLength = 0;
            this.txtConcepto.SelectionStart = 0;
            this.txtConcepto.ShortcutsEnabled = true;
            this.txtConcepto.Size = new System.Drawing.Size(118, 23);
            this.txtConcepto.TabIndex = 0;
            this.txtConcepto.UseSelectable = true;
            this.txtConcepto.WaterMark = "Codigo Concepto";
            this.txtConcepto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConcepto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress_1);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Cuenta Contable :";
            // 
            // txtImporteReferencial
            // 
            this.txtImporteReferencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtImporteReferencial.CustomButton.Image = null;
            this.txtImporteReferencial.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtImporteReferencial.CustomButton.Name = "";
            this.txtImporteReferencial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImporteReferencial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImporteReferencial.CustomButton.TabIndex = 1;
            this.txtImporteReferencial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImporteReferencial.CustomButton.UseSelectable = true;
            this.txtImporteReferencial.CustomButton.Visible = false;
            this.txtImporteReferencial.Lines = new string[0];
            this.txtImporteReferencial.Location = new System.Drawing.Point(148, 77);
            this.txtImporteReferencial.MaxLength = 32767;
            this.txtImporteReferencial.Name = "txtImporteReferencial";
            this.txtImporteReferencial.PasswordChar = '\0';
            this.txtImporteReferencial.WaterMark = "Ingrese Importe referencial";
            this.txtImporteReferencial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImporteReferencial.SelectedText = "";
            this.txtImporteReferencial.SelectionLength = 0;
            this.txtImporteReferencial.SelectionStart = 0;
            this.txtImporteReferencial.ShortcutsEnabled = true;
            this.txtImporteReferencial.Size = new System.Drawing.Size(202, 23);
            this.txtImporteReferencial.TabIndex = 2;
            this.txtImporteReferencial.UseSelectable = true;
            this.txtImporteReferencial.WaterMark = "Ingrese Importe referencial";
            this.txtImporteReferencial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImporteReferencial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtImporteReferencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteReferencial_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Importe referencial :";
            // 
            // txtNombreConcepto
            // 
            this.txtNombreConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombreConcepto.CustomButton.Image = null;
            this.txtNombreConcepto.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtNombreConcepto.CustomButton.Name = "";
            this.txtNombreConcepto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreConcepto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreConcepto.CustomButton.TabIndex = 1;
            this.txtNombreConcepto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreConcepto.CustomButton.UseSelectable = true;
            this.txtNombreConcepto.CustomButton.Visible = false;
            this.txtNombreConcepto.Lines = new string[0];
            this.txtNombreConcepto.Location = new System.Drawing.Point(148, 48);
            this.txtNombreConcepto.MaxLength = 32767;
            this.txtNombreConcepto.Name = "txtNombreConcepto";
            this.txtNombreConcepto.PasswordChar = '\0';
            this.txtNombreConcepto.WaterMark = "Ingrese nombre del concepto";
            this.txtNombreConcepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreConcepto.SelectedText = "";
            this.txtNombreConcepto.SelectionLength = 0;
            this.txtNombreConcepto.SelectionStart = 0;
            this.txtNombreConcepto.ShortcutsEnabled = true;
            this.txtNombreConcepto.Size = new System.Drawing.Size(202, 23);
            this.txtNombreConcepto.TabIndex = 1;
            this.txtNombreConcepto.UseSelectable = true;
            this.txtNombreConcepto.WaterMark = "Ingrese nombre del concepto";
            this.txtNombreConcepto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreConcepto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nombre Concepto :";
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
            this.txtObservaciones.Location = new System.Drawing.Point(148, 154);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "CODIGO :";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(148, 133);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 15);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseSelectable = true;
            // 
            // cboCuentaContable
            // 
            this.cboCuentaContable.FormattingEnabled = true;
            this.cboCuentaContable.Location = new System.Drawing.Point(148, 106);
            this.cboCuentaContable.Name = "cboCuentaContable";
            this.cboCuentaContable.Size = new System.Drawing.Size(375, 21);
            this.cboCuentaContable.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Location = new System.Drawing.Point(196, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salirsistema;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(304, 279);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(341, 317);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(27, 15);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Salir";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(222, 317);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 15);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Guardar";
            // 
            // frmMantenimientoConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 347);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoConcepto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Mantenimiento de Conceptos:::...";
            this.Load += new System.EventHandler(this.frmMantenimientoConcepto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtImporteReferencial;
        private MetroFramework.Controls.MetroTextBox txtNombreConcepto;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboCuentaContable;
        private MetroFramework.Controls.MetroTextBox txtConcepto;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}