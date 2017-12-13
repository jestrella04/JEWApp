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
    public partial class VerFactura : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;
        private int facturaId;

        public VerFactura(int id)
        {
            InitializeComponent();

            facturaId = id;
            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void VerFactura_Load(object sender, EventArgs e)
        {
            DataTable facturaCabecera = sp.SelectFactura(facturaId);
            DataTable facturaDetalle = sp.SelectFacturaDetalle(facturaId);

            txtFacturaId.Text = facturaId.ToString();
            txtNombreCliente.Text = facturaCabecera.Rows[0]["nombre"].ToString();
            txtEstadoFactura.Text = facturaCabecera.Rows[0]["nombre_estado"].ToString();
            txtFechaCreacion.Text = facturaCabecera.Rows[0]["fecha_creacion"].ToString();
            txtFechaActualizacion.Text = facturaCabecera.Rows[0]["fecha_actualizacion"].ToString();

            dgvFacturaDetalle.Rows.Add(facturaDetalle.Rows[0]["nombre_producto"], facturaDetalle.Rows[0]["id_vehiculo"], facturaDetalle.Rows[0]["id_empleado"], facturaDetalle.Rows[0]["nombre_empleado"], facturaDetalle.Rows[0]["cantidad"], facturaDetalle.Rows[0]["precio"]);
        }
    }
}
