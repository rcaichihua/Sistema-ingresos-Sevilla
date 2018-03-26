namespace GUI_SEVILLA
{
    partial class frmUsuario
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
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txtConfirmaContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.chkDeshabilitausuario = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.chkContraseniaCaduca = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtNombreUsuario = new MetroFramework.Controls.MetroTextBox();
            this.chkUsuarioNoCambiaContrasenia = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtDocIdentidad = new MetroFramework.Controls.MetroTextBox();
            this.chkAdmin = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkCambiarContraseniaInicioSesion = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtApellidosNombres = new MetroFramework.Controls.MetroTextBox();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btnAceptar = new Infragistics.Win.Misc.UltraButton();
            this.btnCancelar = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.txtConfirmaContrasenia);
            this.ultraGroupBox1.Controls.Add(this.chkDeshabilitausuario);
            this.ultraGroupBox1.Controls.Add(this.txtContrasenia);
            this.ultraGroupBox1.Controls.Add(this.chkContraseniaCaduca);
            this.ultraGroupBox1.Controls.Add(this.txtNombreUsuario);
            this.ultraGroupBox1.Controls.Add(this.chkUsuarioNoCambiaContrasenia);
            this.ultraGroupBox1.Controls.Add(this.txtDocIdentidad);
            this.ultraGroupBox1.Controls.Add(this.chkAdmin);
            this.ultraGroupBox1.Controls.Add(this.chkCambiarContraseniaInicioSesion);
            this.ultraGroupBox1.Controls.Add(this.txtApellidosNombres);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel5);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel4);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel3);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel2);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox1.Location = new System.Drawing.Point(23, 63);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(444, 313);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Datos de Usuario";
            // 
            // txtConfirmaContrasenia
            // 
            this.txtConfirmaContrasenia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtConfirmaContrasenia.CustomButton.Image = null;
            this.txtConfirmaContrasenia.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtConfirmaContrasenia.CustomButton.Name = "";
            this.txtConfirmaContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmaContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmaContrasenia.CustomButton.TabIndex = 1;
            this.txtConfirmaContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmaContrasenia.CustomButton.UseSelectable = true;
            this.txtConfirmaContrasenia.CustomButton.Visible = false;
            this.txtConfirmaContrasenia.Lines = new string[0];
            this.txtConfirmaContrasenia.Location = new System.Drawing.Point(148, 143);
            this.txtConfirmaContrasenia.MaxLength = 32767;
            this.txtConfirmaContrasenia.Name = "txtConfirmaContrasenia";
            this.txtConfirmaContrasenia.PasswordChar = '*';
            this.txtConfirmaContrasenia.PromptText = "Ingrese Contraseña Nuevamente";
            this.txtConfirmaContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmaContrasenia.SelectedText = "";
            this.txtConfirmaContrasenia.SelectionLength = 0;
            this.txtConfirmaContrasenia.SelectionStart = 0;
            this.txtConfirmaContrasenia.ShortcutsEnabled = true;
            this.txtConfirmaContrasenia.Size = new System.Drawing.Size(285, 23);
            this.txtConfirmaContrasenia.TabIndex = 4;
            this.txtConfirmaContrasenia.UseSelectable = true;
            this.txtConfirmaContrasenia.WaterMark = "Ingrese Contraseña Nuevamente";
            this.txtConfirmaContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmaContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkDeshabilitausuario
            // 
            this.chkDeshabilitausuario.Location = new System.Drawing.Point(30, 282);
            this.chkDeshabilitausuario.Name = "chkDeshabilitausuario";
            this.chkDeshabilitausuario.Size = new System.Drawing.Size(396, 20);
            this.chkDeshabilitausuario.TabIndex = 8;
            this.chkDeshabilitausuario.Text = "Deshabilitar cuenta de usuario.";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtContrasenia.CustomButton.Image = null;
            this.txtContrasenia.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtContrasenia.CustomButton.Name = "";
            this.txtContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasenia.CustomButton.TabIndex = 1;
            this.txtContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasenia.CustomButton.UseSelectable = true;
            this.txtContrasenia.CustomButton.Visible = false;
            this.txtContrasenia.Lines = new string[0];
            this.txtContrasenia.Location = new System.Drawing.Point(148, 114);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.PromptText = "Ingrese Contraseña";
            this.txtContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.ShortcutsEnabled = true;
            this.txtContrasenia.Size = new System.Drawing.Size(285, 23);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.UseSelectable = true;
            this.txtContrasenia.WaterMark = "Ingrese Contraseña";
            this.txtContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkContraseniaCaduca
            // 
            this.chkContraseniaCaduca.Location = new System.Drawing.Point(30, 256);
            this.chkContraseniaCaduca.Name = "chkContraseniaCaduca";
            this.chkContraseniaCaduca.Size = new System.Drawing.Size(396, 20);
            this.chkContraseniaCaduca.TabIndex = 7;
            this.chkContraseniaCaduca.Text = "La contraseña nunca caduca.";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombreUsuario.CustomButton.Image = null;
            this.txtNombreUsuario.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtNombreUsuario.CustomButton.Name = "";
            this.txtNombreUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreUsuario.CustomButton.TabIndex = 1;
            this.txtNombreUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreUsuario.CustomButton.UseSelectable = true;
            this.txtNombreUsuario.CustomButton.Visible = false;
            this.txtNombreUsuario.Lines = new string[0];
            this.txtNombreUsuario.Location = new System.Drawing.Point(148, 85);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PromptText = "Ingrese Nombre de Usuario";
            this.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.ShortcutsEnabled = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(285, 23);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.UseSelectable = true;
            this.txtNombreUsuario.WaterMark = "Ingrese Nombre de Usuario";
            this.txtNombreUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkUsuarioNoCambiaContrasenia
            // 
            this.chkUsuarioNoCambiaContrasenia.Location = new System.Drawing.Point(30, 230);
            this.chkUsuarioNoCambiaContrasenia.Name = "chkUsuarioNoCambiaContrasenia";
            this.chkUsuarioNoCambiaContrasenia.Size = new System.Drawing.Size(396, 20);
            this.chkUsuarioNoCambiaContrasenia.TabIndex = 6;
            this.chkUsuarioNoCambiaContrasenia.Text = "El usuario no puede cambiar tu contraseña.";
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDocIdentidad.CustomButton.Image = null;
            this.txtDocIdentidad.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtDocIdentidad.CustomButton.Name = "";
            this.txtDocIdentidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocIdentidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocIdentidad.CustomButton.TabIndex = 1;
            this.txtDocIdentidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocIdentidad.CustomButton.UseSelectable = true;
            this.txtDocIdentidad.CustomButton.Visible = false;
            this.txtDocIdentidad.Lines = new string[0];
            this.txtDocIdentidad.Location = new System.Drawing.Point(148, 56);
            this.txtDocIdentidad.MaxLength = 32767;
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.PasswordChar = '\0';
            this.txtDocIdentidad.PromptText = "Ingrese Documento de Identidad";
            this.txtDocIdentidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocIdentidad.SelectedText = "";
            this.txtDocIdentidad.SelectionLength = 0;
            this.txtDocIdentidad.SelectionStart = 0;
            this.txtDocIdentidad.ShortcutsEnabled = true;
            this.txtDocIdentidad.Size = new System.Drawing.Size(285, 23);
            this.txtDocIdentidad.TabIndex = 1;
            this.txtDocIdentidad.UseSelectable = true;
            this.txtDocIdentidad.WaterMark = "Ingrese Documento de Identidad";
            this.txtDocIdentidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocIdentidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkAdmin
            // 
            this.chkAdmin.Location = new System.Drawing.Point(30, 178);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(396, 20);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "Administrador?";
            // 
            // chkCambiarContraseniaInicioSesion
            // 
            this.chkCambiarContraseniaInicioSesion.Location = new System.Drawing.Point(30, 204);
            this.chkCambiarContraseniaInicioSesion.Name = "chkCambiarContraseniaInicioSesion";
            this.chkCambiarContraseniaInicioSesion.Size = new System.Drawing.Size(396, 20);
            this.chkCambiarContraseniaInicioSesion.TabIndex = 5;
            this.chkCambiarContraseniaInicioSesion.Text = "El usuario debe cambiar la contraseña en el siguiente inicio de sesión.";
            // 
            // txtApellidosNombres
            // 
            this.txtApellidosNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtApellidosNombres.CustomButton.Image = null;
            this.txtApellidosNombres.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtApellidosNombres.CustomButton.Name = "";
            this.txtApellidosNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidosNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidosNombres.CustomButton.TabIndex = 1;
            this.txtApellidosNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidosNombres.CustomButton.UseSelectable = true;
            this.txtApellidosNombres.CustomButton.Visible = false;
            this.txtApellidosNombres.Lines = new string[0];
            this.txtApellidosNombres.Location = new System.Drawing.Point(148, 27);
            this.txtApellidosNombres.MaxLength = 32767;
            this.txtApellidosNombres.Name = "txtApellidosNombres";
            this.txtApellidosNombres.PasswordChar = '\0';
            this.txtApellidosNombres.PromptText = "Ingrese Apellidos y Nombres";
            this.txtApellidosNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidosNombres.SelectedText = "";
            this.txtApellidosNombres.SelectionLength = 0;
            this.txtApellidosNombres.SelectionStart = 0;
            this.txtApellidosNombres.ShortcutsEnabled = true;
            this.txtApellidosNombres.Size = new System.Drawing.Size(285, 23);
            this.txtApellidosNombres.TabIndex = 0;
            this.txtApellidosNombres.UseSelectable = true;
            this.txtApellidosNombres.WaterMark = "Ingrese Apellidos y Nombres";
            this.txtApellidosNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidosNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.AutoSize = true;
            this.ultraLabel5.Location = new System.Drawing.Point(30, 152);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(112, 14);
            this.ultraLabel5.TabIndex = 1;
            this.ultraLabel5.Text = "Confirma Contraseña";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.AutoSize = true;
            this.ultraLabel4.Location = new System.Drawing.Point(79, 123);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(63, 14);
            this.ultraLabel4.TabIndex = 1;
            this.ultraLabel4.Text = "Contraseña";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(40, 94);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(102, 14);
            this.ultraLabel3.TabIndex = 1;
            this.ultraLabel3.Text = "Nombre de Usuario";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(49, 65);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(93, 14);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Doc. de Identidad";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(34, 36);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(108, 14);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Apellidos y Nombres";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            this.btnAceptar.Location = new System.Drawing.Point(163, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 29);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            this.btnCancelar.Location = new System.Drawing.Point(244, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(488, 423);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Mantenimiento de Usuarios:::...";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkDeshabilitausuario;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkContraseniaCaduca;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsuarioNoCambiaContrasenia;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkCambiarContraseniaInicioSesion;
        private Infragistics.Win.Misc.UltraButton btnAceptar;
        private Infragistics.Win.Misc.UltraButton btnCancelar;
        private MetroFramework.Controls.MetroTextBox txtApellidosNombres;
        private MetroFramework.Controls.MetroTextBox txtDocIdentidad;
        private MetroFramework.Controls.MetroTextBox txtNombreUsuario;
        private MetroFramework.Controls.MetroTextBox txtContrasenia;
        private MetroFramework.Controls.MetroTextBox txtConfirmaContrasenia;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkAdmin;
    }
}