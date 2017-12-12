using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEWApp
{
    public class FormOperations
    {
        public void LimpiarForm(Control.ControlCollection ctrl)
        {
            foreach (Control c in ctrl)
            {
                if (c is TextBox) c.Text = "";
            }
        }

        public void LlenarCombo(ComboBox cmb, DataTable dt)
        {
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "nombre";
        }

        public void MostrarLabelMsg(Label label, string msg, bool error = false)
        {
            label.Text = msg;

            if (error)
            {
                label.ForeColor = Color.Red;
            }

            else
            {
                label.ForeColor = Color.Green;
            }

            label.Visible = true;
        }
    }
}
