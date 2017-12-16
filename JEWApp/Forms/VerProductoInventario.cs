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
    public partial class VerProductoInventario : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerProductoInventario()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void actualizarInventarioLista()
        {
            DataTable inventarioLista = sp.SelectInventario();
            DataTable productoLista = sp.SelectProducto();

            fo.LlenarCombo(cmbInventarioProducto, productoLista);
            dgvProductoInventario.Rows.Clear();

            foreach (DataRow row in inventarioLista.Rows)
            {
                dgvProductoInventario.Rows.Add(row["id_producto"].ToString(), row["nombre_producto"].ToString(), row["cantidad_disponible"].ToString(), row["cantidad_minima"].ToString(), row["precio"].ToString());
            }
        }

        private void VerProductoInventario_Load(object sender, EventArgs e)
        {
            actualizarInventarioLista();            
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            int productoId = int.Parse(cmbInventarioProducto.SelectedValue.ToString());

            double cantidadDisponible = 0;
            double cantidadMinima = 0;
            double precio = 0;

            if (!double.TryParse(txtInventarioCantidadDisponible.Text, out cantidadDisponible) || !double.TryParse(txtInventarioCantidadMinima.Text, out cantidadMinima) || !double.TryParse(txtInventarioPrecio.Text, out precio))
            {
                error = true;
                errorMsg = "Rellene los campos con valores válidos.";
            }

            if (error)
            {
                fo.MostrarLabelMsg(lblResultadoMsg, errorMsg, error = true);
            }

            else
            {
                int i = sp.InsertProductoInventario(productoId, cantidadDisponible, cantidadMinima, precio);

                if (i > 0)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Inventario actualizado exitosamente.");
                    actualizarInventarioLista();
                    fo.LimpiarForm();
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error actualizando el inventario. Intente nuevamente.", error = true);
                }
            }
        }

        private void cmbInventarioProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int productoId = int.Parse(cmbInventarioProducto.SelectedValue.ToString());

            DataTable producto = sp.SelectInventario(productoId);

            int contador = producto.Rows.Count;

            if (contador > 0)
            {
                string cantidadDisponible = producto.Rows[0]["cantidad_disponible"].ToString();
                string cantidadMinima = producto.Rows[0]["cantidad_minima"].ToString();
                string precio = producto.Rows[0]["precio"].ToString();

                if (!String.IsNullOrWhiteSpace(cantidadDisponible)) txtInventarioCantidadDisponible.Text = cantidadDisponible;
                if (!String.IsNullOrWhiteSpace(cantidadMinima)) txtInventarioCantidadMinima.Text = cantidadMinima;
                if (!String.IsNullOrWhiteSpace(precio)) txtInventarioPrecio.Text = precio;
            }
        }
    }
}
