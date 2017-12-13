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
    public partial class CrearFactura : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public CrearFactura()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            DataTable clienteLista = sp.SelectCliente();
            DataTable productoLista = sp.SelectProducto();

            fo.LlenarCombo(cmbCliente, clienteLista);
            fo.LlenarCombo(cmbFacturaDetalleProducto, productoLista);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            int clienteId = int.Parse(cmbCliente.SelectedValue.ToString());
            string facturaDescripcion = txtFacturaDescripcion.Text;

            int cantidadProductos = dgvFacturaDetalle.Rows.Count;

            if (cantidadProductos == 0)
            {
                error = true;
                errorMsg = "Agrege al menos un producto.";
            }

            if (String.IsNullOrWhiteSpace(facturaDescripcion))
            {
                error = true;
                errorMsg = "Rellene todos los campos requeridos";
            }

            if (error)
            {
                fo.MostrarLabelMsg(lblResultadoMsg, errorMsg, error = true);
            }

            else
            {
                int i = sp.InsertFactura(clienteId, 1, facturaDescripcion);

                if (i > 0)
                {
                    bool detalleError = false;

                    foreach(var c in dgvFacturaDetalle.Rows)
                    {
                        //int j = sp.InsertFacturaDetalle(i,c[""])
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            lblResultadoMsg.Visible = false;
            cmbCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            this.Close();
        }

        private void cmbFacturaDetalleProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cmbFacturaDetalleProducto.SelectedValue.ToString()) == 1)
            {
                DataTable vehiculoLista = sp.SelectVehiculo();
                DataView dv = new DataView(vehiculoLista);

                dv.RowFilter = "id_cliente = " + cmbCliente.SelectedValue.ToString();
                var filter = dv.ToTable();

                fo.LlenarCombo(cmbFacturaDetalleVehiculo, filter);
                cmbFacturaDetalleVehiculo.Enabled = true;
            }

            else
            {
                cmbFacturaDetalleVehiculo.Enabled = false;
            }
        }

        private void btnFacturaDetalleAdd_Click(object sender, EventArgs e)
        {
            int productoId = int.Parse(cmbFacturaDetalleProducto.SelectedValue.ToString());
            int vehiculoId = 0;
            double cantidad = 0;
            double precio = 0;

            int.TryParse(cmbFacturaDetalleVehiculo.SelectedValue.ToString(), out vehiculoId);
            double.TryParse(txtFacturaDetalleCantidad.Text, out cantidad);
            double.TryParse(txtFacturaDetallePrecio.Text, out precio);

            DataTable producto = sp.SelectProducto(productoId);
            string prodNombre = producto.Rows[0]["nombre"].ToString();

            if (cantidad > 0 && precio > 0)
            {
                if (productoId == 1)
                {
                    dgvFacturaDetalle.Rows.Add(productoId, prodNombre, vehiculoId, cantidad, precio);
                }

                else
                {
                    dgvFacturaDetalle.Rows.Add(productoId, prodNombre, 0, cantidad, precio);
                }
            }
            
            else
            {
                fo.MostrarLabelMsg(lblfacturaDetalleMsg, "Llene todos los campos.", true);
            }
        }
    }
}
