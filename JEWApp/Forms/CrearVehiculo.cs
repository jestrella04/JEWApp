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
    public partial class CrearVehiculo : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public CrearVehiculo()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void CrearVehiculo_Load(object sender, EventArgs e)
        {
            DataTable clienteLista = sp.SelectCliente();
            DataTable vehiculoMarcaLista = sp.SelectVehiculoMarca();

            fo.LlenarCombo(cmbCliente, clienteLista);
            fo.LlenarCombo(cmbVehiculoMarca, vehiculoMarcaLista);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMsg = "";

            int clienteId = int.Parse(cmbCliente.SelectedValue.ToString());
            int vehiculoMarcaId = int.Parse(cmbVehiculoMarca.SelectedValue.ToString());
            int vehiculoModeloId = int.Parse(cmbVehiculoModelo.SelectedValue.ToString());
            int vehiculoAno = 0;

            string vehiculoMatricula = txtVehiculoMatricula.Text;
            string vehiculoDescripcion = txtvehiculoDescripcion.Text;

            int.TryParse(txtVehiculoAno.Text, out vehiculoAno);

            if (vehiculoAno == 0)
            {
                error = true;
                errorMsg = "El año es inválido.";
            }

            if (String.IsNullOrWhiteSpace(vehiculoMatricula) || String.IsNullOrWhiteSpace(vehiculoDescripcion))
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
                int i = sp.InsertVehiculo(clienteId, vehiculoMarcaId, vehiculoModeloId, vehiculoAno, vehiculoMatricula, vehiculoDescripcion);

                if (i > 0)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Vehículo creado exitosamente.");
                    fo.LimpiarForm();
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear el vehículo. Intente nuevamente.", error = true);
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

        private void cmbVehiculoMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int marcaId = int.Parse(cmbVehiculoMarca.SelectedValue.ToString());
            DataTable vehiculoModeloLista = sp.SelectVehiculoModelo(marcaId);

            fo.LlenarCombo(cmbVehiculoModelo, vehiculoModeloLista);
        }
    }
}
