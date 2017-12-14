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
            bool detalleError = false;
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
                errorMsg = "Rellene todos los campos requeridos.";
            }

            if (error)
            {
                fo.MostrarLabelMsg(lblResultadoMsg, errorMsg, error = true);
            }

            else
            {
                int insertedFacturaId = sp.InsertFactura(clienteId, 1, facturaDescripcion);

                if (insertedFacturaId > 0)
                {
                    foreach(DataGridViewRow row in dgvFacturaDetalle.Rows)
                    {
                        int prodId = int.Parse(row.Cells[0].Value.ToString());
                        int vehiculoId = int.Parse(row.Cells[2].Value.ToString());
                        int empleadoId = Session.empleadoId;
                        double cantidad = double.Parse(row.Cells[0].Value.ToString());
                        double precio = double.Parse(row.Cells[0].Value.ToString());

                        int i = sp.InsertFacturaDetalle(insertedFacturaId, prodId, vehiculoId, empleadoId, cantidad, precio);

                        if (i == 0)
                        {
                            detalleError = true;
                        }
                    }
                }

                if (insertedFacturaId > 0 && !detalleError)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Factura creada exitosamente.");
                    fo.LimpiarForm();
                }

                else if (insertedFacturaId > 0 && detalleError)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Factura creada, pero hubo errores almacenando los detalles.", error = true);
                    fo.LimpiarForm();
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear la factura. Intente nuevamente.", error = true);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            dgvFacturaDetalle.Rows.Clear();
            lblResultadoMsg.Visible = false;
            lblfacturaDetalleMsg.Visible = false;
            cmbCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();
            this.Close();
        }

        private void btnFacturaDetalleAdd_Click(object sender, EventArgs e)
        {
            int productoId = int.Parse(cmbFacturaDetalleProducto.SelectedValue.ToString());

            int vehiculoId = 0;
            double cantidad = 0;
            double precio = 0;

            if (cmbFacturaDetalleVehiculo.Items.Count > 0)
            {
                int.TryParse(cmbFacturaDetalleVehiculo.SelectedValue.ToString(), out vehiculoId);
            }            

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

                txtFacturaDetalleCantidad.Text = "";
                txtFacturaDetallePrecio.Text = "";
            }
            
            else
            {
                fo.MostrarLabelMsg(lblfacturaDetalleMsg, "Llene todos los campos.", true);
            }
        }

        private void cmbFacturaDetalleProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int productoId = int.Parse(cmbFacturaDetalleProducto.SelectedValue.ToString());

            DataTable inventario = sp.SelectInventario(productoId);

            if (inventario.Rows.Count > 0)
            {
                txtFacturaDetallePrecio.Text = inventario.Rows[0]["precio"].ToString();
            }

            if (productoId == 1)
            {
                DataTable vehiculoLista = sp.SelectVehiculo();
                DataView dv = new DataView(vehiculoLista);

                dv.RowFilter = "id_cliente = " + cmbCliente.SelectedValue.ToString();
                var filter = dv.ToTable();

                fo.LlenarCombo(cmbFacturaDetalleVehiculo, filter);
                cmbFacturaDetalleVehiculo.Enabled = true;
                btnFacturaDetalleAgregarVehiculo.Enabled = true;
            }

            else
            {
                cmbFacturaDetalleVehiculo.Enabled = false;
                btnFacturaDetalleAgregarVehiculo.Enabled = false;
            }
        }

        private void btnFacturaDetalleAgregarVehiculo_Click(object sender, EventArgs e)
        {
            CrearVehiculo crearVehiculoForm = new CrearVehiculo();

            crearVehiculoForm.MinimizeBox = false;
            crearVehiculoForm.MaximizeBox = false;
            crearVehiculoForm.ShowIcon = false;
            crearVehiculoForm.StartPosition = FormStartPosition.CenterScreen;
            crearVehiculoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            crearVehiculoForm.Show();
        }
    }
}
