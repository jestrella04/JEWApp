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
    public partial class VerRol : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerRol()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerRol_Load(object sender, EventArgs e)
        {
            DataTable dt = sp.SelectRol();

            foreach (DataRow row in dt.Rows)
            {
                dgvRoleLista.Rows.Add(row["id"].ToString(), row["nombre"].ToString(), row["descripcion"].ToString());
            }
        }
    }
}
