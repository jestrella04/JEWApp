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
        FormOperations fo;

        public Login()
        {
            InitializeComponent();

            fo = new FormOperations(this);
        }

        private void showLoginError(string errorMsg)
        {
            lblLoginError.Text = errorMsg;
            lblLoginError.Left = (this.Width / 2) - (lblLoginError.Width / 2);
            lblLoginError.Visible = true;
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
                StoredProcedure sp = new StoredProcedure();
                string loginResult;

                try
                {
                    loginResult = sp.VerifyEmpleadoLogin(loginEmail, loginPassword);
                }

                catch(Exception dbEx)
                {
                    loginResult = "";
                    if (!String.IsNullOrWhiteSpace(dbEx.Message)) loginResult = "Error conectando a la base de datos.";
                }

                if ("Credenciales válidas." != loginResult)
                {
                    showLoginError(loginResult);
                }

                else
                {
                    Database db = new Database();
                    string empleadoId = db.consultaStringScalar("SELECT [id] FROM [dbo].[empleado] WHERE [correo] = '" + loginEmail + "'");

                    if (int.TryParse(empleadoId, out int id))
                    {
                        var usuarioInfo = sp.SelectEmpleado(id).Rows[0];

                        Session.sesionIniciada = true;
                        Session.empleadoId = int.Parse(usuarioInfo["id"].ToString());
                        Session.empleadoEmail = usuarioInfo["correo"].ToString();
                        Session.empleadoPermisos = sp.SelectPermiso(int.Parse(usuarioInfo["id_rol"].ToString()));

                        this.Visible = false;
                        Main mainForm = new Main(this);
                        mainForm.Show();
                    }

                    else
                    {
                        showLoginError("Error desconocido, por favor intente de nuevo.");
                    }
                }
            }

            else
            {
                showLoginError("Por favor introduzca su email y contraseña.");
            }

            this.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblLoginError.Visible = false;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtLoginEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
