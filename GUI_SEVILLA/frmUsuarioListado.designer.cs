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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.ADMIN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowHeadersWidth = 28;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(723, 453);
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
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.dgvUsuarios);
            this.ultraGroupBox1.Location = new System.Drawing.Point(23, 63);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(729, 456);
            this.ultraGroupBox1.TabIndex = 1;
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
            // btnCerrar
            // 
            this.btnCerrar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            this.btnCerrar.Location = new System.Drawing.Point(650, 525);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmUsuarioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 558);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioListado";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "...:::Listado de Usuarios:::...";
            this.Load += new System.EventHandler(this.frmUsuarioListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvUsuarios;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private Infragistics.Win.Misc.UltraButton btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECOMPLETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREUSUARIO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CAMBIAPASSWORD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DESACTIVARCAMBIOPASSWORD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PASSWORDNOCADUCA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DESACTIVAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ADMIN;
    }
}