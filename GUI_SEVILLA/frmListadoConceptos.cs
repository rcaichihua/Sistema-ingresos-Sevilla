using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmListadoConceptos : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public frmListadoConceptos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConceptos_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            dgvConceptos.DataSource = cn.EjecutarSqlDTS("SELECT IDCONCEPTO,CODCONCEPTO,DESCRIPCONCEPTO,IMPORTE_REFERENCIAL,B.codigoCuenta,a.OBSERVACIONES,A.ESTADO FROM CONCEPTO A INNER JOIN bdtesoreria.dbo.tb_cta_contable B ON A.IDCUENTACONTABLE=B.id_cuenta_contable order by CODCONCEPTO asc", conectar.conexionbdSevilla).Tables[0];
            dgvConceptos.Refresh();
        }
        private void AnularAutocompletadoColumnas()
        {
            this.dgvConceptos.AutoGenerateColumns = false;
            this.dgvConceptos.AutoGenerateColumns = false;
            this.dgvConceptos.AutoGenerateColumns = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMantenimientoConcepto winMante = new frmMantenimientoConcepto();
            winMante.TipoMantenimiento = "I";
            winMante.IdConcepto = 0;
            winMante.ShowDialog();
            LlenarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvConceptos.Rows.Count <= 0) return;

            if (dgvConceptos.CurrentRow is null) return;

            int indexModAlumno = 0;
            indexModAlumno = dgvConceptos.CurrentRow.Index;

            frmMantenimientoConcepto winMante = new frmMantenimientoConcepto();
            winMante.TipoMantenimiento = "U";
            winMante.IdConcepto  = Convert.ToInt32(dgvConceptos.Rows[indexModAlumno].Cells["IDCONCEPTO"].Value);
            winMante.ShowDialog();
            LlenarGrilla();
        }
    }
}
