using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEWApp.Forms
{
    public partial class VerReporteCumpleanos : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerReporteCumpleanos()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaIni = dtpInicio.Value;
            DateTime fechaFin = dtpFin.Value;

            if (DateTime.TryParse(fechaIni.ToString(), out DateTime fecha1) && DateTime.TryParse(fechaFin.ToString(), out DateTime fecha2))
            {
                DataTable dt = sp.SelectReporteComisiones(fecha1, fecha2);

                foreach (DataRow row in dt.Rows)
                {
                    dgvReporteCumpleanos.Rows.Add(row["id"].ToString(), row["nombre_tipo"].ToString(), row["nombre_cliente"].ToString(), row["mes"].ToString(), row["nac_dia"].ToString());
                }
            }
        }
    }
}
