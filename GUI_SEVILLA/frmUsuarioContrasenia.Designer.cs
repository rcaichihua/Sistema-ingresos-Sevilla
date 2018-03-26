namespace GUI_SEVILLA
{
    partial class frmUsuarioContrasenia
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtContraseniaRepite = new MetroFramework.Controls.MetroTextBox();
            this.txtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.metroLabel3);
            this.ultraGroupBox1.Controls.Add(this.metroLabel2);
            this.ultraGroupBox1.Controls.Add(this.txtContraseniaRepite);
            this.ultraGroupBox1.Controls.Add(this.txtContrasenia);
            this.ultraGroupBox1.Location = new System.Drawing.Point(23, 63);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(342, 102);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Inicio de Sesión";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Repita Contraseña";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Contraseña";
            // 
            // txtContraseniaRepite
            // 
            // 
            // 
            // 
            this.txtContraseniaRepite.CustomButton.Image = null;
            this.txtContraseniaRepite.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtContraseniaRepite.CustomButton.Name = "";
            this.txtContraseniaRepite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContraseniaRepite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContraseniaRepite.CustomButton.TabIndex = 1;
            this.txtContraseniaRepite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContraseniaRepite.CustomButton.UseSelectable = true;
            this.txtContraseniaRepite.CustomButton.Visible = false;
            this.txtContraseniaRepite.Lines = new string[0];
            this.txtContraseniaRepite.Location = new System.Drawing.Point(139, 60);
            this.txtContraseniaRepite.MaxLength = 32767;
            this.txtContraseniaRepite.Name = "txtContraseniaRepite";
            this.txtContraseniaRepite.PasswordChar = '*';
            this.txtContraseniaRepite.PromptText = "Ingrese Contraseña Nuevamente";
            this.txtContraseniaRepite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseniaRepite.SelectedText = "";
            this.txtContraseniaRepite.SelectionLength = 0;
            this.txtContraseniaRepite.SelectionStart = 0;
            this.txtContraseniaRepite.ShortcutsEnabled = true;
            this.txtContraseniaRepite.Size = new System.Drawing.Size(197, 23);
            this.txtContraseniaRepite.TabIndex = 1;
            this.txtContraseniaRepite.UseSelectable = true;
            this.txtContraseniaRepite.WaterMark = "Ingrese Contraseña Nuevamente";
            this.txtContraseniaRepite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContraseniaRepite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContrasenia
            // 
            // 
            // 
            // 
            this.txtContrasenia.CustomButton.Image = null;
            this.txtContrasenia.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtContrasenia.CustomButton.Name = "";
            this.txtContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasenia.CustomButton.TabIndex = 1;
            this.txtContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasenia.CustomButton.UseSelectable = true;
            this.txtContrasenia.CustomButton.Visible = false;
            this.txtContrasenia.Lines = new string[0];
            this.txtContrasenia.Location = new System.Drawing.Point(139, 31);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.PromptText = "Ingrese Contraseña";
            this.txtContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.ShortcutsEnabled = true;
            this.txtContrasenia.Size = new System.Drawing.Size(197, 23);
            this.txtContrasenia.TabIndex = 0;
            this.txtContrasenia.UseSelectable = true;
            this.txtContrasenia.WaterMark = "Ingrese Contraseña";
            this.txtContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(194, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(113, 171);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "&Aceptar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmUsuarioContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(384, 207);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioContrasenia";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Actualizar Contraseña:::...";
            this.Load += new System.EventHandler(this.frmUsuarioContrasenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtContraseniaRepite;
        private MetroFramework.Controls.MetroTextBox txtContrasenia;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnActualizar;
    }
}