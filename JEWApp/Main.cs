using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace JEWApp
{
    public partial class Main : Form
    {
        private Login loginForm;
        private StoredProcedure sp;

        public Main(Login login)
        {
            sp = new StoredProcedure();
            InitializeComponent();
            loginForm = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool sesionIniciada = Session.sesionIniciada;

            if (! sesionIniciada)
            {
                this.Close();
                loginForm.txtLoginEmail.Text = "";
                loginForm.txtLoginPassword.Text = "";
                loginForm.Show();
            }

            else
            {
                DataTable userInfo = sp.SelectEmpleado(Session.empleadoId);
                lblStatusBarLoginMessage.Text = "Bienvenido a JEWApp " + userInfo.Rows[0]["nombre_completo"] + ".";
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.sesionIniciada)
            {
                loginForm.Close();
            }
        }

        private void btnSesionCerrar_Click(object sender, EventArgs e)
        {
            Session.sesionIniciada = false;
            this.Close();
            loginForm.txtLoginEmail.Text = "";
            loginForm.txtLoginPassword.Text = "";
            loginForm.Show();
        }
    }
}
