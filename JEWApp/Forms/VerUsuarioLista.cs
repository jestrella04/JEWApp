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
    public partial class VerUsuarios : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerUsuarios()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectEmpleado();

            foreach (DataRow row in dt.Rows)
            {
                dgvUsuarios.Rows.Add(row["id"].ToString(), row["nombre_rol"].ToString(), row["nombre_docid"].ToString(), row["docid"].ToString(), row["nombre_completo"].ToString(), row["telefono"].ToString(), row["correo"].ToString());
            }
        }
    }
}
