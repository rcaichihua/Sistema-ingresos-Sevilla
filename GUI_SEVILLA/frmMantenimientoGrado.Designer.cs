namespace GUI_SEVILLA
{
    partial class frmMantenimientoGrado
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
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreGrado = new MetroFramework.Controls.MetroTextBox();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.lblIdAnio = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(190, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(298, 194);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdAnio);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtNombreGrado);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Observaciones  :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Nombre Grado :";
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombreGrado.CustomButton.Image = null;
            this.txtNombreGrado.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtNombreGrado.CustomButton.Name = "";
            this.txtNombreGrado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreGrado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreGrado.CustomButton.TabIndex = 1;
            this.txtNombreGrado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreGrado.CustomButton.UseSelectable = true;
            this.txtNombreGrado.CustomButton.Visible = false;
            this.txtNombreGrado.Lines = new string[0];
            this.txtNombreGrado.Location = new System.Drawing.Point(148, 19);
            this.txtNombreGrado.MaxLength = 32767;
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.PasswordChar = '\0';
            this.txtNombreGrado.WaterMark = "Ingrese nombre del grado";
            this.txtNombreGrado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreGrado.SelectedText = "";
            this.txtNombreGrado.SelectionLength = 0;
            this.txtNombreGrado.SelectionStart = 0;
            this.txtNombreGrado.ShortcutsEnabled = true;
            this.txtNombreGrado.Size = new System.Drawing.Size(202, 23);
            this.txtNombreGrado.TabIndex = 1;
            this.txtNombreGrado.UseSelectable = true;
            this.txtNombreGrado.WaterMark = "Ingrese nombre del grado";
            this.txtNombreGrado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreGrado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtObservaciones.Location = new System.Drawing.Point(148, 69);
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
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(148, 48);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 15);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseSelectable = true;
            // 
            // lblIdAnio
            // 
            this.lblIdAnio.AutoSize = true;
            this.lblIdAnio.Location = new System.Drawing.Point(386, 19);
            this.lblIdAnio.Name = "lblIdAnio";
            this.lblIdAnio.Size = new System.Drawing.Size(83, 19);
            this.lblIdAnio.TabIndex = 32;
            this.lblIdAnio.Text = "metroLabel3";
            this.lblIdAnio.Visible = false;
            // 
            // frmMantenimientoGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 249);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantenimientoGrado";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Mantenimiento Grado:::...";
            this.Load += new System.EventHandler(this.frmMantenimientoGrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtNombreGrado;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblIdAnio;
    }
}