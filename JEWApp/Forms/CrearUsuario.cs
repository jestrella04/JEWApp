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
    public partial class CrearUsuario : Form
    {
        private StoredProcedure sp = new StoredProcedure();
        private FormOperations fo = new FormOperations();

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            DataTable rolLista = sp.SelectRol();
            DataTable tipoDocLista = sp.SelectTipoDocId();

            fo.LlenarCombo(cmbRol, rolLista);
            fo.LlenarCombo(cmbTipoDoc, tipoDocLista);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            string doc = txtDocumento.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            int rolId = int.Parse(cmbRol.SelectedValue.ToString());
            int tipoDocId = int.Parse(cmbTipoDoc.SelectedValue.ToString());

            string pass1 = txtContrasena1.Text;
            string pass2 = txtContrasena2.Text;

            if (String.IsNullOrWhiteSpace(doc) || String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(apellido) || String.IsNullOrWhiteSpace(telefono) || String.IsNullOrWhiteSpace(correo))
            {
                error = true;
                errorMsg = "Rellene todos los campos requeridos.";
            }

            if (telefono.Length != 10)
            {
                error = true;
                errorMsg = "El número de teléfono es inválido.";
            }

            if (!correo.Contains("@") && !correo.Contains("."))
            {
                error = true;
                errorMsg = "El formato de correo es inválido.";
            }

            if (String.IsNullOrWhiteSpace(pass1) && String.IsNullOrWhiteSpace(pass2))
            {
                if (pass1 != pass2)
                {
                    error = true;
                    errorMsg = "La contraseña no coincide.";
                }
            }

            if (error)
            {
                fo.MostrarLabelMsg(lblResultadoMsg, errorMsg, error = true);
            }

            else
            {
                int i = sp.InsertEmpleado(rolId, tipoDocId, doc, nombre, apellido, telefono, correo, pass1);

                if (i > 0)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Usuario creado exitosamente.");
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear el usuario. Intente nuevamente.", error = true);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm(this.Controls);
            cmbRol.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm(this.Controls);
            this.Close();
        }
    }
}
