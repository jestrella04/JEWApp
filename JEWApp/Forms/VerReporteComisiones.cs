using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEWApp
{
    public partial class VerReporteComisiones : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerReporteComisiones()
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
                string sqlFecha1 = fecha1.ToString("yyyy-MM-dd");
                string sqlFecha2 = fecha2.ToString("yyyy-MM-dd");

                DataTable dt = sp.SelectReporteComisiones(sqlFecha1, sqlFecha2);
                dgvReporteComisiones.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvReporteComisiones.Rows.Add(row["id_empleado"].ToString(), row["nombre_empleado"].ToString(), row["neto"].ToString(), row["comision"].ToString());
                }
            }
        }
    }
}
