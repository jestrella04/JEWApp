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
    public partial class Main : Form
    {
        private Login loginForm;

        public Main(Login login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool sesionIniciada = Session.sesionIniciada;

            if (! sesionIniciada)
            {
                this.Close();
                loginForm.Show();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }
    }
}
