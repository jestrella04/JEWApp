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
        private StoredProcedure sp = new StoredProcedure();
        private FormOperations fo = new FormOperations();

        public VerFacturaLista()
        {
            InitializeComponent();
        }

        private void VerFacturaLista_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectFactura();

            foreach (DataRow row in dt.Rows)
            {
                dgvFacturaLista.Rows.Add(row["id"].ToString(), row["nombre_cliente"].ToString(), row["nombre_estado"].ToString(), row["fecha_creacion"].ToString(), row["fecha_actualizacion"].ToString(), row["descripcion"].ToString());
            }
        }
    }
}
