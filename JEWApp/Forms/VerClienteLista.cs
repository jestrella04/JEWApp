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
    public partial class VerCliente : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerCliente()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectCliente();

            foreach (DataRow row in dt.Rows)
            {
                dgvClienteLista.Rows.Add(row["id"].ToString(), row["nombre_tipo"].ToString(), row["nombre_docid"].ToString(), row["docid"].ToString(), row["nombre_completo"].ToString(), row["telefono"].ToString(), row["correo"].ToString(), row["direccion"].ToString());
            }
        }
    }
}
