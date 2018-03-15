namespace GUI_SEVILLA
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbAlumnos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbConceptos = new System.Windows.Forms.RibbonButton();
            this.rbAnioEscolar = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbCobros = new System.Windows.Forms.RibbonButton();
            this.rbMatricula = new System.Windows.Forms.RibbonButton();
            this.rbGeneracionArchivo = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbCtaCorreinte = new System.Windows.Forms.RibbonButton();
            this.rbCobrosInforme = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbCrearUsuario = new System.Windows.Forms.RibbonButton();
            this.rbActualizarUsuario = new System.Windows.Forms.RibbonButton();
            this.rbCambiarContrasenia = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.rbAcerca = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Size = new System.Drawing.Size(948, 130);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Panels.Add(this.ribbonPanel6);
            this.ribbonTab1.Text = "Instituto Sevilla";
            this.ribbonTab1.ToolTip = "Sistema de captacion de ingresos por medio de vouchers de pago";
            this.ribbonTab1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ribbonTab1.ToolTipTitle = "Aviso";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbAlumnos);
            this.ribbonPanel1.Text = "Catálogos";
            // 
            // rbAlumnos
            // 
            this.rbAlumnos.Image = global::GUI_SEVILLA.Properties.Resources.alumnos;
            this.rbAlumnos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAlumnos.SmallImage")));
            this.rbAlumnos.Text = "Alumnos";
            this.rbAlumnos.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbAlumnos.ToolTip = "Permite ver el Listado de Alumnos";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbConceptos);
            this.ribbonPanel2.Items.Add(this.rbAnioEscolar);
            this.ribbonPanel2.Text = "Configuración";
            // 
            // rbConceptos
            // 
            this.rbConceptos.Image = global::GUI_SEVILLA.Properties.Resources.conceptos;
            this.rbConceptos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbConceptos.SmallImage")));
            this.rbConceptos.Text = "Conceptos";
            // 
            // rbAnioEscolar
            // 
            this.rbAnioEscolar.Image = global::GUI_SEVILLA.Properties.Resources.anio;
            this.rbAnioEscolar.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAnioEscolar.SmallImage")));
            this.rbAnioEscolar.Text = "Año Escolar";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbCobros);
            this.ribbonPanel3.Items.Add(this.rbMatricula);
            this.ribbonPanel3.Items.Add(this.rbGeneracionArchivo);
            this.ribbonPanel3.Text = "Operaciones";
            // 
            // rbCobros
            // 
            this.rbCobros.Image = global::GUI_SEVILLA.Properties.Resources.cobros;
            this.rbCobros.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCobros.SmallImage")));
            this.rbCobros.Text = "Pagos";
            this.rbCobros.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // rbMatricula
            // 
            this.rbMatricula.Image = global::GUI_SEVILLA.Properties.Resources.matricula;
            this.rbMatricula.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbMatricula.SmallImage")));
            this.rbMatricula.Text = "Matrícula";
            this.rbMatricula.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbMatricula.ToolTip = "";
            // 
            // rbGeneracionArchivo
            // 
            this.rbGeneracionArchivo.Image = global::GUI_SEVILLA.Properties.Resources.archivo;
            this.rbGeneracionArchivo.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbGeneracionArchivo.SmallImage")));
            this.rbGeneracionArchivo.Text = "Archivo Banco";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbCtaCorreinte);
            this.ribbonPanel4.Items.Add(this.rbCobrosInforme);
            this.ribbonPanel4.Text = "Información";
            // 
            // rbCtaCorreinte
            // 
            this.rbCtaCorreinte.Image = global::GUI_SEVILLA.Properties.Resources.ctacorriente;
            this.rbCtaCorreinte.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCtaCorreinte.SmallImage")));
            this.rbCtaCorreinte.Text = "Cta Corriente";
            this.rbCtaCorreinte.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // rbCobrosInforme
            // 
            this.rbCobrosInforme.Image = global::GUI_SEVILLA.Properties.Resources.cobrosInformacion;
            this.rbCobrosInforme.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCobrosInforme.SmallImage")));
            this.rbCobrosInforme.Text = "Cobros";
            this.rbCobrosInforme.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rbCrearUsuario);
            this.ribbonPanel5.Items.Add(this.rbActualizarUsuario);
            this.ribbonPanel5.Items.Add(this.rbCambiarContrasenia);
            this.ribbonPanel5.Text = "Sistema";
            // 
            // rbCrearUsuario
            // 
            this.rbCrearUsuario.Image = global::GUI_SEVILLA.Properties.Resources.registrarUser;
            this.rbCrearUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCrearUsuario.SmallImage")));
            this.rbCrearUsuario.Text = "Crear Usuario";
            this.rbCrearUsuario.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbCrearUsuario.Click += new System.EventHandler(this.rbCrearUsuario_Click);
            // 
            // rbActualizarUsuario
            // 
            this.rbActualizarUsuario.Image = global::GUI_SEVILLA.Properties.Resources.actualizarUser;
            this.rbActualizarUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbActualizarUsuario.SmallImage")));
            this.rbActualizarUsuario.Text = "Actualizar Usuario";
            this.rbActualizarUsuario.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbActualizarUsuario.Click += new System.EventHandler(this.rbActualizarUsuario_Click);
            // 
            // rbCambiarContrasenia
            // 
            this.rbCambiarContrasenia.Image = global::GUI_SEVILLA.Properties.Resources.cambiarcontrasenia;
            this.rbCambiarContrasenia.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCambiarContrasenia.SmallImage")));
            this.rbCambiarContrasenia.Text = "Cambiar Contraseña";
            this.rbCambiarContrasenia.Click += new System.EventHandler(this.rbCambiarContrasenia_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rbAcerca);
            this.ribbonPanel6.Text = "RDCV";
            // 
            // rbAcerca
            // 
            this.rbAcerca.Image = global::GUI_SEVILLA.Properties.Resources.programador;
            this.rbAcerca.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAcerca.SmallImage")));
            this.rbAcerca.Text = "Acerca";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(948, 584);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::: S I S T E M A  D E  M A T R I C U L A :::..";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonButton rbAlumnos;
        private System.Windows.Forms.RibbonButton rbConceptos;
        private System.Windows.Forms.RibbonButton rbAnioEscolar;
        private System.Windows.Forms.RibbonButton rbCobros;
        private System.Windows.Forms.RibbonButton rbMatricula;
        private System.Windows.Forms.RibbonButton rbCtaCorreinte;
        private System.Windows.Forms.RibbonButton rbCobrosInforme;
        private System.Windows.Forms.RibbonButton rbGeneracionArchivo;
        private System.Windows.Forms.RibbonButton rbCrearUsuario;
        private System.Windows.Forms.RibbonButton rbActualizarUsuario;
        private System.Windows.Forms.RibbonButton rbCambiarContrasenia;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton rbAcerca;
    }
}