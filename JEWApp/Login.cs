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
            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            string loginEmail = txtLoginEmail.Text;
            string loginPassword = txtLoginPassword.Text;

            lblLoginError.Text = "";
            lblLoginError.Visible = false;

            if (! String.IsNullOrWhiteSpace(loginEmail) && ! String.IsNullOrWhiteSpace(loginPassword))
            {
                StoredProcedure storedProcedure = new StoredProcedure();

                string loginResult = storedProcedure.VerifyEmpleadoLogin(loginEmail, loginPassword);

                if ("Credenciales válidas." != loginResult)
                {
                    lblLoginError.Text = loginResult;
                    lblLoginError.Left = (this.Width / 2) - (lblLoginError.Width / 2);
                    lblLoginError.Visible = true;
                }

                else
                {
                    Database db = new Database();
                    string empleadoId = db.consultaStringScalar("SELECT [id] FROM [dbo].[empleado] WHERE [correo] = '" + loginEmail + "'");

                    if (int.TryParse(empleadoId, out int id))
                    {
                        Session.sesionIniciada = true;
                        Session.empleadoId = id;
                        Session.empleadoEmail = loginEmail;

                        this.Visible = false;
                        Main mainForm = new Main(this);
                        mainForm.Show();
                    }

                    else
                    {
                        lblLoginError.Text = "Error desconocido, por favor intente de nuevo.";
                        lblLoginError.Left = (this.Width / 2) - (lblLoginError.Width / 2);
                        lblLoginError.Visible = true;
                    }
                }
            }

            else
            {
                lblLoginError.Text = "Por favor introduzca su email y contraseña.";
                lblLoginError.Left = (this.Width / 2) - (lblLoginError.Width / 2);
                lblLoginError.Visible = true;
            }

            this.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblLoginError.Visible = false;
        }
    }
}
