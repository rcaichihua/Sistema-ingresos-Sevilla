namespace GUI_SEVILLA
{
    partial class frmUsuarioListado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new MetroFramework.Controls.MetroGrid();
            this.IDUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECOMPLETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMBIAPASSWORD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DESACTIVARCAMBIOPASSWORD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PASSWORDNOCADUCA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DESACTIVAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ADMIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRASENIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUSUARIO,
            this.NOMBRECOMPLETO,
            this.NRODOCUMENTO,
            this.NOMBREUSUARIO,
            this.CAMBIAPASSWORD,
            this.DESACTIVARCAMBIOPASSWORD,
            this.PASSWORDNOCADUCA,
            this.DESACTIVAR,
            this.ADMIN,
            this.CONTRASENIA});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 16);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarios.RowHeadersWidth = 28;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(742, 344);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_CellMouseClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // IDUSUARIO
            // 
            this.IDUSUARIO.DataPropertyName = "IDUSUARIO";
            this.IDUSUARIO.HeaderText = "IDUSUARIO";
            this.IDUSUARIO.Name = "IDUSUARIO";
            this.IDUSUARIO.ReadOnly = true;
            this.IDUSUARIO.Visible = false;
            // 
            // NOMBRECOMPLETO
            // 
            this.NOMBRECOMPLETO.DataPropertyName = "NOMBRECOMPLETO";
            this.NOMBRECOMPLETO.HeaderText = "NOMBRES DE USUARIO";
            this.NOMBRECOMPLETO.Name = "NOMBRECOMPLETO";
            this.NOMBRECOMPLETO.ReadOnly = true;
            this.NOMBRECOMPLETO.Width = 250;
            // 
            // NRODOCUMENTO
            // 
            this.NRODOCUMENTO.DataPropertyName = "NRODOCUMENTO";
            this.NRODOCUMENTO.HeaderText = "NRO DE DOCUMENTO";
            this.NRODOCUMENTO.Name = "NRODOCUMENTO";
            this.NRODOCUMENTO.ReadOnly = true;
            this.NRODOCUMENTO.Width = 140;
            // 
            // NOMBREUSUARIO
            // 
            this.NOMBREUSUARIO.DataPropertyName = "NOMBREUSUARIO";
            this.NOMBREUSUARIO.HeaderText = "NOMBRE DE USUARIO";
            this.NOMBREUSUARIO.Name = "NOMBREUSUARIO";
            this.NOMBREUSUARIO.ReadOnly = true;
            this.NOMBREUSUARIO.Width = 150;
            // 
            // CAMBIAPASSWORD
            // 
            this.CAMBIAPASSWORD.DataPropertyName = "CAMBIAPASSWORD";
            this.CAMBIAPASSWORD.FalseValue = "0";
            this.CAMBIAPASSWORD.HeaderText = "CAMBIAPASSWORD";
            this.CAMBIAPASSWORD.IndeterminateValue = "0";
            this.CAMBIAPASSWORD.Name = "CAMBIAPASSWORD";
            this.CAMBIAPASSWORD.ReadOnly = true;
            this.CAMBIAPASSWORD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAMBIAPASSWORD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAMBIAPASSWORD.TrueValue = "1";
            this.CAMBIAPASSWORD.Visible = false;
            // 
            // DESACTIVARCAMBIOPASSWORD
            // 
            this.DESACTIVARCAMBIOPASSWORD.DataPropertyName = "DESACTIVARCAMBIOPASSWORD";
            this.DESACTIVARCAMBIOPASSWORD.FalseValue = "0";
            this.DESACTIVARCAMBIOPASSWORD.HeaderText = "DESACTIVARCAMBIOPASSWORD";
            this.DESACTIVARCAMBIOPASSWORD.IndeterminateValue = "0";
            this.DESACTIVARCAMBIOPASSWORD.Name = "DESACTIVARCAMBIOPASSWORD";
            this.DESACTIVARCAMBIOPASSWORD.ReadOnly = true;
            this.DESACTIVARCAMBIOPASSWORD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESACTIVARCAMBIOPASSWORD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DESACTIVARCAMBIOPASSWORD.TrueValue = "1";
            this.DESACTIVARCAMBIOPASSWORD.Visible = false;
            // 
            // PASSWORDNOCADUCA
            // 
            this.PASSWORDNOCADUCA.DataPropertyName = "PASSWORDNOCADUCA";
            this.PASSWORDNOCADUCA.FalseValue = "0";
            this.PASSWORDNOCADUCA.HeaderText = "PASSWORDNOCADUCA";
            this.PASSWORDNOCADUCA.IndeterminateValue = "0";
            this.PASSWORDNOCADUCA.Name = "PASSWORDNOCADUCA";
            this.PASSWORDNOCADUCA.ReadOnly = true;
            this.PASSWORDNOCADUCA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PASSWORDNOCADUCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PASSWORDNOCADUCA.TrueValue = "1";
            this.PASSWORDNOCADUCA.Visible = false;
            // 
            // DESACTIVAR
            // 
            this.DESACTIVAR.DataPropertyName = "DESACTIVAR";
            this.DESACTIVAR.FalseValue = "0";
            this.DESACTIVAR.HeaderText = "INACTIVO?";
            this.DESACTIVAR.IndeterminateValue = "0";
            this.DESACTIVAR.Name = "DESACTIVAR";
            this.DESACTIVAR.ReadOnly = true;
            this.DESACTIVAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESACTIVAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DESACTIVAR.TrueValue = "1";
            this.DESACTIVAR.Width = 80;
            // 
            // ADMIN
            // 
            this.ADMIN.DataPropertyName = "administrador";
            this.ADMIN.HeaderText = "ADMIN";
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.ReadOnly = true;
            this.ADMIN.Width = 70;
            // 
            // CONTRASENIA
            // 
            this.CONTRASENIA.DataPropertyName = "PASSWORD";
            this.CONTRASENIA.HeaderText = "CONTRASENIA";
            this.CONTRASENIA.Name = "CONTRASENIA";
            this.CONTRASENIA.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshabilitarToolStripMenuItem,
            this.restablecerContraseñaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.eliminarToolStripMenuItem,
            this.propiedadesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 98);
            // 
            // deshabilitarToolStripMenuItem
            // 
            this.deshabilitarToolStripMenuItem.Name = "deshabilitarToolStripMenuItem";
            this.deshabilitarToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.deshabilitarToolStripMenuItem.Text = "&Deshabilitar cuenta de Usuario";
            this.deshabilitarToolStripMenuItem.Click += new System.EventHandler(this.deshabilitarToolStripMenuItem_Click);
            // 
            // restablecerContraseñaToolStripMenuItem
            // 
            this.restablecerContraseñaToolStripMenuItem.Name = "restablecerContraseñaToolStripMenuItem";
            this.restablecerContraseñaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.restablecerContraseñaToolStripMenuItem.Text = "&Restablecer contraseña";
            this.restablecerContraseñaToolStripMenuItem.Click += new System.EventHandler(this.restablecerContraseñaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.propiedadesToolStripMenuItem.Text = "&Propiedades";
            this.propiedadesToolStripMenuItem.Click += new System.EventHandler(this.propiedadesToolStripMenuItem_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::GUI_SEVILLA.Properties.Resources.salirsistema;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(696, 432);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 35);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 363);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(720, 470);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(27, 15);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Salir";
            // 
            // frmUsuarioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioListado";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Listado de Usuarios:::...";
            this.Load += new System.EventHandler(this.frmUsuarioListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvUsuarios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECOMPLETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREUSUARIO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CAMBIAPASSWORD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DESACTIVARCAMBIOPASSWORD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PASSWORDNOCADUCA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DESACTIVAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ADMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRASENIA;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}