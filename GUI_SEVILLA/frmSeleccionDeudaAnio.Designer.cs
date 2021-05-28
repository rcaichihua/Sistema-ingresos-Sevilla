namespace GUI_SEVILLA
{
    partial class frmSeleccionDeudaAnio
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtAnio = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Navy;
            this.btnProcesar.Image = global::GUI_SEVILLA.Properties.Resources.procesar;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcesar.Location = new System.Drawing.Point(111, 20);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(182, 50);
            this.btnProcesar.TabIndex = 125;
            this.btnProcesar.Text = "Generar archivo Deuda";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(6, 26);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(93, 19);
            this.metroLabel21.TabIndex = 124;
            this.metroLabel21.Text = "Año de deuda";
            // 
            // txtAnio
            // 
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtAnio.CustomButton.Image = null;
            this.txtAnio.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtAnio.CustomButton.Name = "";
            this.txtAnio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnio.CustomButton.TabIndex = 1;
            this.txtAnio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnio.CustomButton.UseSelectable = true;
            this.txtAnio.CustomButton.Visible = false;
            this.txtAnio.Lines = new string[0];
            this.txtAnio.Location = new System.Drawing.Point(6, 47);
            this.txtAnio.MaxLength = 32767;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.PasswordChar = '\0';
            this.txtAnio.PromptText = "Año deuda";
            this.txtAnio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnio.SelectedText = "";
            this.txtAnio.SelectionLength = 0;
            this.txtAnio.SelectionStart = 0;
            this.txtAnio.ShortcutsEnabled = true;
            this.txtAnio.Size = new System.Drawing.Size(97, 23);
            this.txtAnio.TabIndex = 123;
            this.txtAnio.UseSelectable = true;
            this.txtAnio.WaterMark = "Año deuda";
            this.txtAnio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.metroLabel21);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 84);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_SEVILLA.Properties.Resources.salir_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(303, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 50);
            this.btnSalir.TabIndex = 126;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmSeleccionDeudaAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 157);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSeleccionDeudaAnio";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Selección año de deuda:::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnProcesar;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtAnio;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnSalir;
    }
}