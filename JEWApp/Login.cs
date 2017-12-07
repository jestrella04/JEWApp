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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginEmail = txtLoginEmail.Text;
            string loginPassword = txtLoginPassword.Text;

            if (! String.IsNullOrWhiteSpace(loginEmail) && ! String.IsNullOrWhiteSpace(loginPassword))
            {
                StoredProcedure storedProcedure = new StoredProcedure();

                string test = storedProcedure.VerifyEmpleadoLogin(loginEmail, loginPassword);

                // DataTableReader reader = new DataTableReader(test);

                //if (reader.HasRows)
                //{
                //MessageBox.Show(reader.GetString(0));
                MessageBox.Show(test);
                //}
            }

            else
            {
                MessageBox.Show("Por favor introduzca su email y contraseña");
            }
        }
    }
}
