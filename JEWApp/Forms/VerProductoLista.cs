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
    public partial class VerProductoLista : Form
    {
        private StoredProcedure sp = new StoredProcedure();
        private FormOperations fo = new FormOperations();

        public VerProductoLista()
        {
            InitializeComponent();
        }

        private void VerProductoLista_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectProducto();

            foreach (DataRow row in dt.Rows)
            {
                dgvProductoLista.Rows.Add(row["id"].ToString(), row["categoria"].ToString(), row["medida"].ToString(), row["nombre"].ToString(), row["descripcion"].ToString());
            }
        }
    }
}
