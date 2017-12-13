using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEWApp.Forms
{
    public partial class CrearProducto : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public CrearProducto()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {
            DataTable prodCategoriaLista = sp.SelectProductoCategoria();
            DataTable prodMedidaLista = sp.SelectProductoMedida();

            fo.LlenarCombo(cmbCategoria, prodCategoriaLista);
            fo.LlenarCombo(cmbMedida, prodMedidaLista);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            int prodCategoriaId = int.Parse(cmbCategoria.SelectedValue.ToString());
            int prodMedidaId = int.Parse(cmbMedida.SelectedValue.ToString());

            string prodNombre = txtNombre.Text;
            string prodDescripcion = txtDescripcion.Text;

            if (String.IsNullOrWhiteSpace(prodNombre) || String.IsNullOrWhiteSpace(prodDescripcion))
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
                int i = sp.InsertProducto(prodCategoriaId, prodMedidaId, prodNombre, prodDescripcion);

                if (i > 0)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Producto creado exitosamente.");
                    fo.LimpiarForm();
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear el producto. Intente nuevamente.", error = true);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            lblResultadoMsg.Visible = false;
            cmbCategoria.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            this.Close();
        }
    }
}
