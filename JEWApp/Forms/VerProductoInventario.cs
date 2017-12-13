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
    public partial class VerProductoInventario : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerProductoInventario()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerProductoInventario_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectInventario();

            foreach (DataRow row in dt.Rows)
            {
                dgvProductoInventario.Rows.Add(row["id_producto"].ToString(), row["nombre_producto"].ToString(), row["cantidad_disponible"].ToString(), row["cantidad_minima"].ToString(), row["precio"].ToString());
            }
        }
    }
}
