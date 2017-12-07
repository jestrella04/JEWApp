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

                storedProcedure.VerifyEmpleadoLogin(loginEmail, loginPassword);
            }

            else
            {
                MessageBox.Show("Por favor introduzca su email y contraseña");
            }
        }
    }
}
