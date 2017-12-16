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
    public partial class VerFacturaLista : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerFacturaLista()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerFacturaLista_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectFactura();

            foreach (DataRow row in dt.Rows)
            {
                dgvFacturaLista.Rows.Add(row["id"].ToString(), row["nombre_cliente"].ToString(), row["nombre_estado"].ToString(), row["fecha_creacion"].ToString(), row["fecha_actualizacion"].ToString(), row["items"].ToString(), row["neto"].ToString());
            }
        }

        private void dgvFacturaLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int facturaId = int.Parse(dgvFacturaLista[0, e.RowIndex].Value.ToString());

            Form verFacturaForm = new VerFactura(facturaId);

            verFacturaForm.MinimizeBox = false;
            verFacturaForm.MaximizeBox = false;
            verFacturaForm.WindowState = FormWindowState.Maximized;
            verFacturaForm.Show();
        }
    }
}
