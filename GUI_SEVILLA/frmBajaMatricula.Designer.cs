namespace GUI_SEVILLA
{
    partial class frmBajaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajaMatricula));
            this.cboMotivoBaja = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaRegistro = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gbBuscarAlumno = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBaja = new MetroFramework.Controls.MetroButton();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.rbTodos = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPensiones = new MetroFramework.Controls.MetroRadioButton();
            this.rbOtros = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gbBuscarAlumno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMotivoBaja
            // 
            this.cboMotivoBaja.FormattingEnabled = true;
            this.cboMotivoBaja.ItemHeight = 23;
            this.cboMotivoBaja.Location = new System.Drawing.Point(14, 38);
            this.cboMotivoBaja.Name = "cboMotivoBaja";
            this.cboMotivoBaja.Size = new System.Drawing.Size(257, 29);
            this.cboMotivoBaja.TabIndex = 5;
            this.cboMotivoBaja.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Motivo";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(277, 38);
            this.dtpFechaRegistro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(135, 29);
            this.dtpFechaRegistro.TabIndex = 9;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(277, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Fecha registro";
            // 
            // gbBuscarAlumno
            // 
            this.gbBuscarAlumno.Controls.Add(this.groupBox1);
            this.gbBuscarAlumno.Controls.Add(this.metroLabel3);
            this.gbBuscarAlumno.Controls.Add(this.metroLabel1);
            this.gbBuscarAlumno.Controls.Add(this.txtObservaciones);
            this.gbBuscarAlumno.Controls.Add(this.metroLabel6);
            this.gbBuscarAlumno.Controls.Add(this.cboMotivoBaja);
            this.gbBuscarAlumno.Controls.Add(this.dtpFechaRegistro);
            this.gbBuscarAlumno.Controls.Add(this.metroLabel2);
            this.gbBuscarAlumno.Location = new System.Drawing.Point(23, 63);
            this.gbBuscarAlumno.Name = "gbBuscarAlumno";
            this.gbBuscarAlumno.Size = new System.Drawing.Size(447, 319);
            this.gbBuscarAlumno.TabIndex = 10;
            this.gbBuscarAlumno.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(191, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Descripción del motivo de baja";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(151, 392);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(90, 35);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "&Dar de baja";
            this.btnBaja.UseSelectable = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtObservaciones.CustomButton.Image = null;
            this.txtObservaciones.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtObservaciones.CustomButton.Name = "";
            this.txtObservaciones.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservaciones.CustomButton.TabIndex = 1;
            this.txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservaciones.CustomButton.UseSelectable = true;
            this.txtObservaciones.CustomButton.Visible = false;
            this.txtObservaciones.Lines = new string[0];
            this.txtObservaciones.Location = new System.Drawing.Point(14, 168);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.PromptText = "Detalle el motivo de baja si es necesario";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(398, 58);
            this.txtObservaciones.TabIndex = 18;
            this.txtObservaciones.UseSelectable = true;
            this.txtObservaciones.WaterMark = "Detalle el motivo de baja si es necesario";
            this.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(247, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 29);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 15);
            this.rbTodos.TabIndex = 19;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOtros);
            this.groupBox1.Controls.Add(this.rbPensiones);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(14, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el tipo de anulación";
            // 
            // rbPensiones
            // 
            this.rbPensiones.AutoSize = true;
            this.rbPensiones.Location = new System.Drawing.Point(102, 29);
            this.rbPensiones.Name = "rbPensiones";
            this.rbPensiones.Size = new System.Drawing.Size(102, 15);
            this.rbPensiones.TabIndex = 19;
            this.rbPensiones.Text = "Solo Pensiones";
            this.rbPensiones.UseSelectable = true;
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(245, 29);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(110, 15);
            this.rbOtros.TabIndex = 19;
            this.rbOtros.Text = "Otros conceptos";
            this.rbOtros.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(14, 229);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(398, 83);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = resources.GetString("metroLabel3.Text");
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBajaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 441);
            this.Controls.Add(this.gbBuscarAlumno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaja);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBajaMatricula";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Motivo baja:::...";
            this.Load += new System.EventHandler(this.frmBajaMatricula_Load);
            this.gbBuscarAlumno.ResumeLayout(false);
            this.gbBuscarAlumno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboMotivoBaja;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtpFechaRegistro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox gbBuscarAlumno;
        private MetroFramework.Controls.MetroButton btnBaja;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbOtros;
        private MetroFramework.Controls.MetroRadioButton rbPensiones;
        private MetroFramework.Controls.MetroRadioButton rbTodos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}