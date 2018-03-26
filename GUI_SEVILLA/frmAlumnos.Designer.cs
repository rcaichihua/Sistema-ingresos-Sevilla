namespace GUI_SEVILLA
{
    partial class frmAlumnos
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
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.htmlLabel12 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.htmlLabel11 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtApeMat = new MetroFramework.Controls.MetroTextBox();
            this.txtDni = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel8 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel9 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cboDepaDd = new System.Windows.Forms.ComboBox();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.cboDepaLn = new System.Windows.Forms.ComboBox();
            this.htmlLabel7 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel10 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtEdad = new MetroFramework.Controls.MetroTextBox();
            this.cboDistDd = new System.Windows.Forms.ComboBox();
            this.cboSeguro = new System.Windows.Forms.ComboBox();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.cboDistLn = new System.Windows.Forms.ComboBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cboProvLn = new System.Windows.Forms.ComboBox();
            this.txtApePat = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtMotivoBaja = new MetroFramework.Controls.MetroTextBox();
            this.cboProvDd = new System.Windows.Forms.ComboBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.Lines = new string[0];
            this.txtNombres.Location = new System.Drawing.Point(148, 106);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PromptText = "Ingrese los Nombres";
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.Size = new System.Drawing.Size(202, 23);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.UseSelectable = true;
            this.txtNombres.WaterMark = "Ingrese los Nombres";
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(194, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // htmlLabel12
            // 
            this.htmlLabel12.AutoScroll = true;
            this.htmlLabel12.AutoScrollMinSize = new System.Drawing.Size(91, 23);
            this.htmlLabel12.AutoSize = false;
            this.htmlLabel12.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel12.Location = new System.Drawing.Point(51, 375);
            this.htmlLabel12.Name = "htmlLabel12";
            this.htmlLabel12.Size = new System.Drawing.Size(91, 23);
            this.htmlLabel12.TabIndex = 30;
            this.htmlLabel12.Text = "Observaciones  :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(302, 499);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // htmlLabel11
            // 
            this.htmlLabel11.AutoScroll = true;
            this.htmlLabel11.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.htmlLabel11.AutoSize = false;
            this.htmlLabel11.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel11.Location = new System.Drawing.Point(91, 317);
            this.htmlLabel11.Name = "htmlLabel11";
            this.htmlLabel11.Size = new System.Drawing.Size(51, 23);
            this.htmlLabel11.TabIndex = 34;
            this.htmlLabel11.Text = "Seguro  :";
            // 
            // txtApeMat
            // 
            this.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtApeMat.CustomButton.Image = null;
            this.txtApeMat.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtApeMat.CustomButton.Name = "";
            this.txtApeMat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApeMat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApeMat.CustomButton.TabIndex = 1;
            this.txtApeMat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApeMat.CustomButton.UseSelectable = true;
            this.txtApeMat.CustomButton.Visible = false;
            this.txtApeMat.Lines = new string[0];
            this.txtApeMat.Location = new System.Drawing.Point(148, 77);
            this.txtApeMat.MaxLength = 32767;
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.PasswordChar = '\0';
            this.txtApeMat.PromptText = "Ingrese Apellido Materno";
            this.txtApeMat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApeMat.SelectedText = "";
            this.txtApeMat.SelectionLength = 0;
            this.txtApeMat.SelectionStart = 0;
            this.txtApeMat.ShortcutsEnabled = true;
            this.txtApeMat.Size = new System.Drawing.Size(202, 23);
            this.txtApeMat.TabIndex = 2;
            this.txtApeMat.UseSelectable = true;
            this.txtApeMat.WaterMark = "Ingrese Apellido Materno";
            this.txtApeMat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApeMat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDni.CustomButton.Image = null;
            this.txtDni.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtDni.CustomButton.Name = "";
            this.txtDni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDni.CustomButton.TabIndex = 1;
            this.txtDni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDni.CustomButton.UseSelectable = true;
            this.txtDni.CustomButton.Visible = false;
            this.txtDni.Lines = new string[0];
            this.txtDni.Location = new System.Drawing.Point(148, 19);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PromptText = "Ingrese el DNI";
            this.txtDni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDni.SelectedText = "";
            this.txtDni.SelectionLength = 0;
            this.txtDni.SelectionStart = 0;
            this.txtDni.ShortcutsEnabled = true;
            this.txtDni.Size = new System.Drawing.Size(118, 23);
            this.txtDni.TabIndex = 0;
            this.txtDni.UseSelectable = true;
            this.txtDni.WaterMark = "Ingrese el DNI";
            this.txtDni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // htmlLabel8
            // 
            this.htmlLabel8.AutoScroll = true;
            this.htmlLabel8.AutoScrollMinSize = new System.Drawing.Size(64, 23);
            this.htmlLabel8.AutoSize = false;
            this.htmlLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel8.Location = new System.Drawing.Point(78, 217);
            this.htmlLabel8.Name = "htmlLabel8";
            this.htmlLabel8.Size = new System.Drawing.Size(64, 23);
            this.htmlLabel8.TabIndex = 32;
            this.htmlLabel8.Text = "Dirección  :";
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
            this.txtObservaciones.Location = new System.Drawing.Point(148, 375);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.PromptText = "Ingrese algunas observaciones adicionales";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(375, 38);
            this.txtObservaciones.TabIndex = 17;
            this.txtObservaciones.UseSelectable = true;
            this.txtObservaciones.WaterMark = "Ingrese algunas observaciones adicionales";
            this.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel9
            // 
            this.htmlLabel9.AutoScroll = true;
            this.htmlLabel9.AutoScrollMinSize = new System.Drawing.Size(103, 23);
            this.htmlLabel9.AutoSize = false;
            this.htmlLabel9.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel9.Location = new System.Drawing.Point(39, 261);
            this.htmlLabel9.Name = "htmlLabel9";
            this.htmlLabel9.Size = new System.Drawing.Size(103, 23);
            this.htmlLabel9.TabIndex = 29;
            this.htmlLabel9.Text = "Distrito Dirección  :";
            // 
            // cboDepaDd
            // 
            this.cboDepaDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepaDd.FormattingEnabled = true;
            this.cboDepaDd.Location = new System.Drawing.Point(148, 263);
            this.cboDepaDd.Name = "cboDepaDd";
            this.cboDepaDd.Size = new System.Drawing.Size(121, 21);
            this.cboDepaDd.TabIndex = 10;
            this.cboDepaDd.SelectedIndexChanged += new System.EventHandler(this.cboDepaDd_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(148, 346);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 15);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseSelectable = true;
            // 
            // cboDepaLn
            // 
            this.cboDepaLn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepaLn.FormattingEnabled = true;
            this.cboDepaLn.Location = new System.Drawing.Point(148, 161);
            this.cboDepaLn.Name = "cboDepaLn";
            this.cboDepaLn.Size = new System.Drawing.Size(121, 21);
            this.cboDepaLn.TabIndex = 5;
            this.cboDepaLn.SelectedIndexChanged += new System.EventHandler(this.cboDepaLn_SelectedIndexChanged);
            // 
            // htmlLabel7
            // 
            this.htmlLabel7.AutoScroll = true;
            this.htmlLabel7.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.htmlLabel7.AutoSize = false;
            this.htmlLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel7.Location = new System.Drawing.Point(101, 188);
            this.htmlLabel7.Name = "htmlLabel7";
            this.htmlLabel7.Size = new System.Drawing.Size(41, 23);
            this.htmlLabel7.TabIndex = 27;
            this.htmlLabel7.Text = "Edad  :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(148, 217);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PromptText = "Ingrese Dirección";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(375, 40);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMark = "Ingrese Dirección";
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel10
            // 
            this.htmlLabel10.AutoScroll = true;
            this.htmlLabel10.AutoScrollMinSize = new System.Drawing.Size(59, 23);
            this.htmlLabel10.AutoSize = false;
            this.htmlLabel10.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel10.Location = new System.Drawing.Point(83, 290);
            this.htmlLabel10.Name = "htmlLabel10";
            this.htmlLabel10.Size = new System.Drawing.Size(59, 23);
            this.htmlLabel10.TabIndex = 21;
            this.htmlLabel10.Text = "Teléfono  :";
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEdad.CustomButton.Image = null;
            this.txtEdad.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtEdad.CustomButton.Name = "";
            this.txtEdad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdad.CustomButton.TabIndex = 1;
            this.txtEdad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdad.CustomButton.UseSelectable = true;
            this.txtEdad.CustomButton.Visible = false;
            this.txtEdad.Lines = new string[0];
            this.txtEdad.Location = new System.Drawing.Point(148, 188);
            this.txtEdad.MaxLength = 32767;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PromptText = "Edad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.ShortcutsEnabled = true;
            this.txtEdad.Size = new System.Drawing.Size(64, 23);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.UseSelectable = true;
            this.txtEdad.WaterMark = "Edad";
            this.txtEdad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdad_KeyDown);
            // 
            // cboDistDd
            // 
            this.cboDistDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistDd.FormattingEnabled = true;
            this.cboDistDd.Location = new System.Drawing.Point(402, 263);
            this.cboDistDd.Name = "cboDistDd";
            this.cboDistDd.Size = new System.Drawing.Size(121, 21);
            this.cboDistDd.TabIndex = 12;
            // 
            // cboSeguro
            // 
            this.cboSeguro.FormattingEnabled = true;
            this.cboSeguro.Location = new System.Drawing.Point(148, 319);
            this.cboSeguro.Name = "cboSeguro";
            this.cboSeguro.Size = new System.Drawing.Size(121, 21);
            this.cboSeguro.TabIndex = 14;
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(70, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(72, 161);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(70, 23);
            this.htmlLabel6.TabIndex = 26;
            this.htmlLabel6.Text = "Lugar Nac.  :";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(148, 135);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(118, 20);
            this.dtpFechaNac.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(148, 290);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PromptText = "Ingrese Teléfono";
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(202, 23);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMark = "Ingrese Teléfono";
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboDistLn
            // 
            this.cboDistLn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistLn.FormattingEnabled = true;
            this.cboDistLn.Location = new System.Drawing.Point(402, 161);
            this.cboDistLn.Name = "cboDistLn";
            this.cboDistLn.Size = new System.Drawing.Size(121, 21);
            this.cboDistLn.TabIndex = 7;
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(35, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(107, 19);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(35, 23);
            this.htmlLabel2.TabIndex = 25;
            this.htmlLabel2.Text = "DNI  :";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(73, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(69, 135);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(73, 23);
            this.htmlLabel1.TabIndex = 24;
            this.htmlLabel1.Text = "Fecha Nac.  :";
            // 
            // cboProvLn
            // 
            this.cboProvLn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvLn.FormattingEnabled = true;
            this.cboProvLn.Location = new System.Drawing.Point(275, 161);
            this.cboProvLn.Name = "cboProvLn";
            this.cboProvLn.Size = new System.Drawing.Size(121, 21);
            this.cboProvLn.TabIndex = 6;
            this.cboProvLn.SelectedIndexChanged += new System.EventHandler(this.cboProvLn_SelectedIndexChanged);
            // 
            // txtApePat
            // 
            this.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtApePat.CustomButton.Image = null;
            this.txtApePat.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtApePat.CustomButton.Name = "";
            this.txtApePat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApePat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApePat.CustomButton.TabIndex = 1;
            this.txtApePat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApePat.CustomButton.UseSelectable = true;
            this.txtApePat.CustomButton.Visible = false;
            this.txtApePat.Lines = new string[0];
            this.txtApePat.Location = new System.Drawing.Point(148, 48);
            this.txtApePat.MaxLength = 32767;
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.PasswordChar = '\0';
            this.txtApePat.PromptText = "Ingrese Apellido Paterno";
            this.txtApePat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApePat.SelectedText = "";
            this.txtApePat.SelectionLength = 0;
            this.txtApePat.SelectionStart = 0;
            this.txtApePat.ShortcutsEnabled = true;
            this.txtApePat.Size = new System.Drawing.Size(202, 23);
            this.txtApePat.TabIndex = 1;
            this.txtApePat.UseSelectable = true;
            this.txtApePat.WaterMark = "Ingrese Apellido Paterno";
            this.txtApePat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApePat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(97, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(45, 48);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(97, 23);
            this.htmlLabel3.TabIndex = 23;
            this.htmlLabel3.Text = "Apellido Paterno  :";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(61, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(81, 106);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(61, 23);
            this.htmlLabel5.TabIndex = 22;
            this.htmlLabel5.Text = "Nombres  :";
            // 
            // txtMotivoBaja
            // 
            this.txtMotivoBaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtMotivoBaja.CustomButton.Image = null;
            this.txtMotivoBaja.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtMotivoBaja.CustomButton.Name = "";
            this.txtMotivoBaja.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMotivoBaja.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMotivoBaja.CustomButton.TabIndex = 1;
            this.txtMotivoBaja.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMotivoBaja.CustomButton.UseSelectable = true;
            this.txtMotivoBaja.CustomButton.Visible = false;
            this.txtMotivoBaja.Lines = new string[0];
            this.txtMotivoBaja.Location = new System.Drawing.Point(211, 346);
            this.txtMotivoBaja.MaxLength = 32767;
            this.txtMotivoBaja.Name = "txtMotivoBaja";
            this.txtMotivoBaja.PasswordChar = '\0';
            this.txtMotivoBaja.PromptText = "Ingrese el motivo de Baja";
            this.txtMotivoBaja.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMotivoBaja.SelectedText = "";
            this.txtMotivoBaja.SelectionLength = 0;
            this.txtMotivoBaja.SelectionStart = 0;
            this.txtMotivoBaja.ShortcutsEnabled = true;
            this.txtMotivoBaja.Size = new System.Drawing.Size(312, 23);
            this.txtMotivoBaja.TabIndex = 16;
            this.txtMotivoBaja.UseSelectable = true;
            this.txtMotivoBaja.WaterMark = "Ingrese el motivo de Baja";
            this.txtMotivoBaja.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotivoBaja.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboProvDd
            // 
            this.cboProvDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvDd.FormattingEnabled = true;
            this.cboProvDd.Location = new System.Drawing.Point(275, 263);
            this.cboProvDd.Name = "cboProvDd";
            this.cboProvDd.Size = new System.Drawing.Size(121, 21);
            this.cboProvDd.TabIndex = 11;
            this.cboProvDd.SelectedIndexChanged += new System.EventHandler(this.cboProvDd_SelectedIndexChanged);
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(99, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(43, 77);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(99, 23);
            this.htmlLabel4.TabIndex = 28;
            this.htmlLabel4.Text = "Apellido Materno :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.htmlLabel4);
            this.groupBox1.Controls.Add(this.cboProvDd);
            this.groupBox1.Controls.Add(this.htmlLabel12);
            this.groupBox1.Controls.Add(this.txtMotivoBaja);
            this.groupBox1.Controls.Add(this.htmlLabel5);
            this.groupBox1.Controls.Add(this.htmlLabel11);
            this.groupBox1.Controls.Add(this.htmlLabel3);
            this.groupBox1.Controls.Add(this.txtApeMat);
            this.groupBox1.Controls.Add(this.txtApePat);
            this.groupBox1.Controls.Add(this.cboProvLn);
            this.groupBox1.Controls.Add(this.htmlLabel8);
            this.groupBox1.Controls.Add(this.htmlLabel1);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.htmlLabel2);
            this.groupBox1.Controls.Add(this.htmlLabel9);
            this.groupBox1.Controls.Add(this.cboDistLn);
            this.groupBox1.Controls.Add(this.cboDepaDd);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.cboDepaLn);
            this.groupBox1.Controls.Add(this.htmlLabel6);
            this.groupBox1.Controls.Add(this.htmlLabel7);
            this.groupBox1.Controls.Add(this.cboSeguro);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.cboDistDd);
            this.groupBox1.Controls.Add(this.htmlLabel10);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Alumnos:::...";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel12;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel11;
        private MetroFramework.Controls.MetroTextBox txtApeMat;
        private MetroFramework.Controls.MetroTextBox txtDni;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel8;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel9;
        private System.Windows.Forms.ComboBox cboDepaDd;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboDepaLn;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel7;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel10;
        private MetroFramework.Controls.MetroTextBox txtEdad;
        private System.Windows.Forms.ComboBox cboDistDd;
        private System.Windows.Forms.ComboBox cboSeguro;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private System.Windows.Forms.ComboBox cboDistLn;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.ComboBox cboProvLn;
        private MetroFramework.Controls.MetroTextBox txtApePat;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroTextBox txtMotivoBaja;
        private System.Windows.Forms.ComboBox cboProvDd;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}