namespace GUI_SEVILLA
{
    partial class frmMotivoAnulacion
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
            this.lblNombreNroDocumento = new MetroFramework.Controls.MetroLabel();
            this.txtMotivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblNombreNroDocumento
            // 
            this.lblNombreNroDocumento.AutoSize = true;
            this.lblNombreNroDocumento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNombreNroDocumento.Location = new System.Drawing.Point(23, 60);
            this.lblNombreNroDocumento.Name = "lblNombreNroDocumento";
            this.lblNombreNroDocumento.Size = new System.Drawing.Size(24, 25);
            this.lblNombreNroDocumento.TabIndex = 5;
            this.lblNombreNroDocumento.Text = "...";
            // 
            // txtMotivo
            // 
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtMotivo.CustomButton.Image = null;
            this.txtMotivo.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtMotivo.CustomButton.Name = "";
            this.txtMotivo.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txtMotivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMotivo.CustomButton.TabIndex = 1;
            this.txtMotivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMotivo.CustomButton.UseSelectable = true;
            this.txtMotivo.CustomButton.Visible = false;
            this.txtMotivo.Lines = new string[0];
            this.txtMotivo.Location = new System.Drawing.Point(23, 107);
            this.txtMotivo.MaxLength = 32767;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.SelectionLength = 0;
            this.txtMotivo.SelectionStart = 0;
            this.txtMotivo.ShortcutsEnabled = true;
            this.txtMotivo.Size = new System.Drawing.Size(491, 95);
            this.txtMotivo.TabIndex = 6;
            this.txtMotivo.UseSelectable = true;
            this.txtMotivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Motivo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salirsistema;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Location = new System.Drawing.Point(358, 208);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 37);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.ingresar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.Location = new System.Drawing.Point(439, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 37);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(452, 248);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 15);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Aceptar";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(384, 248);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 15);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Salir";
            // 
            // frmMotivoAnulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 273);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblNombreNroDocumento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMotivoAnulacion";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Descripción Motivo:::...";
            this.Load += new System.EventHandler(this.frmMotivoAnulacionDocElect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombreNroDocumento;
        private MetroFramework.Controls.MetroTextBox txtMotivo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}