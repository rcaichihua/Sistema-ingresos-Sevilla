namespace GUI_SEVILLA
{
    partial class frmImpresion
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
            this.crvImpresion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvImpresion
            // 
            this.crvImpresion.ActiveViewIndex = -1;
            this.crvImpresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvImpresion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvImpresion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvImpresion.Location = new System.Drawing.Point(20, 60);
            this.crvImpresion.Name = "crvImpresion";
            this.crvImpresion.Size = new System.Drawing.Size(887, 432);
            this.crvImpresion.TabIndex = 0;
            this.crvImpresion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 512);
            this.Controls.Add(this.crvImpresion);
            this.Name = "frmImpresion";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "...:::Impresion:::...";
            this.Load += new System.EventHandler(this.frmImpresion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvImpresion;
    }
}