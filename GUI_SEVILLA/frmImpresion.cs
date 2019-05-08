using BL_SEVILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_SEVILLA
{
    public partial class frmImpresion : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();
        public int TipoReporte { get; set; }
        public DataTable MiTabla { get; set; }

        public frmImpresion()
        {
            InitializeComponent();
        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            if (TipoReporte==1)
            {
                Reportes.rptEstadoCuentaPersonal rptRecibo = new Reportes.rptEstadoCuentaPersonal();
                rptRecibo.SetDataSource(MiTabla);
                crvImpresion.ReportSource = rptRecibo;
            }
            else if (TipoReporte == 2)
            {
                Reportes.rptAlumnosTotales rptAlumnos = new Reportes.rptAlumnosTotales();
                rptAlumnos.SetDataSource(MiTabla);
                crvImpresion.ReportSource = rptAlumnos;
            }
            else if (TipoReporte == 3)
            {
                Reportes.rptListadoAlumnosMatriculados rptAlumnosMat = new Reportes.rptListadoAlumnosMatriculados();
                rptAlumnosMat.SetDataSource(MiTabla);
                crvImpresion.ReportSource = rptAlumnosMat;
            }
            else if (TipoReporte == 4)
            {
                Reportes.rptDeudaTotalAlumnos rptDeudaTotal = new Reportes.rptDeudaTotalAlumnos();
                rptDeudaTotal.SetDataSource(MiTabla);
                crvImpresion.ReportSource = rptDeudaTotal;
            }
            else if (TipoReporte == 5)
            {
                Reportes.rptReciboCaja rptReciboCaja = new Reportes.rptReciboCaja();
                rptReciboCaja.SetDataSource(MiTabla);
                crvImpresion.ReportSource = rptReciboCaja;
            }
        }
    }
}
