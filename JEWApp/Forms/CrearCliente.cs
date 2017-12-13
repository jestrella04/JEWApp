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
    public partial class CrearCliente : Form
    {
        private StoredProcedure sp = new StoredProcedure();
        private FormOperations fo = new FormOperations();

        public CrearCliente()
        {
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            DataTable clienteTipoLista = sp.SelectClienteTipo();
            DataTable tipoDocLista = sp.SelectTipoDocId();

            fo.LlenarCombo(cmbTipo, clienteTipoLista);
            fo.LlenarCombo(cmbTipoDoc, tipoDocLista);
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            int tipoClienteId = int.Parse(cmbTipo.SelectedValue.ToString());
            int tipoDocId = int.Parse(cmbTipoDoc.SelectedValue.ToString());

            string doc = txtDocumento.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            string fechaDia = "";
            string fechaMes = "";
            string fechaAno = txtFechaAno.Text;

            int fechaDiaInt = 0;
            int fechaMesInt = 0;
            int fechaAnoInt = 0;

            if (cmbFechaDia.SelectedItem != null) fechaDia = cmbFechaDia.SelectedItem.ToString();
            if (cmbFechaMes.SelectedItem != null) fechaMes = cmbFechaMes.SelectedItem.ToString();

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

            if (!String.IsNullOrWhiteSpace(fechaDia) && !String.IsNullOrWhiteSpace(fechaMes))
            {
                fechaDiaInt = int.Parse(fechaDia);
                fechaMesInt = cmbFechaMes.SelectedIndex + 1;
            }

            if (!String.IsNullOrWhiteSpace(fechaAno))
            {
                if (int.TryParse(fechaAno, out int ano))
                {
                    fechaAnoInt = ano;
                }

                else
                {
                    error = true;
                    errorMsg = "El año de nacimiento es inválido.";
                }
            }

            if (String.IsNullOrWhiteSpace(doc) || String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(apellido) || String.IsNullOrWhiteSpace(direccion) || String.IsNullOrWhiteSpace(telefono) || String.IsNullOrWhiteSpace(correo))
            {
                error = true;
                errorMsg = "Rellene todos los campos requeridos.";
            }

            if (error)
            {
                fo.MostrarLabelMsg(lblResultadoMsg, errorMsg, error = true);
            }

            else
            {
                int i;

                if (fechaDiaInt > 0 && fechaMesInt > 0 && fechaAnoInt > 0)
                {
                    i = sp.InsertCliente(tipoClienteId, tipoDocId, doc, nombre, apellido, direccion, telefono, correo, fechaDiaInt, fechaMesInt, fechaAnoInt);
                }

                else if (fechaDiaInt > 0 && fechaMesInt > 0 && fechaAnoInt == 0)
                {
                    i = sp.InsertCliente(tipoClienteId, tipoDocId, doc, nombre, apellido, direccion, telefono, correo, fechaDiaInt, fechaMesInt);
                }

                else
                {
                    i = sp.InsertCliente(tipoClienteId, tipoDocId, doc, nombre, apellido, direccion, telefono, correo);
                }

                if (i > 0)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Cliente creado exitosamente.");
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear el cliente. Intente nuevamente.", error = true);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm(this.Controls);
            cmbTipo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm(this.Controls);
            this.Close();
        }
    }
}
