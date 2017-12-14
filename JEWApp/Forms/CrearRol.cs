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
    public partial class CrearRol : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public CrearRol()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }

        private void CrearRol_Load(object sender, EventArgs e)
        {
            DataTable tareaLista = sp.SelectTarea();

            fo.LlenarCheckedListBox(clbRolPermisos, tareaLista);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool error = false;
            bool errorPermisos = false;
            string errorMsg = "";

            string rolNombre = txtNombre.Text;
            string rolDescripcion = txtDescripcion.Text;

            if (String.IsNullOrWhiteSpace(rolNombre) || String.IsNullOrWhiteSpace(rolDescripcion))
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
                int insertedRolId = sp.InsertRol(rolNombre, rolDescripcion);

                if (insertedRolId > 0)
                {
                    int cb = 0;

                    foreach(DataRowView tarea in clbRolPermisos.Items)
                    {
                        int tareaId = int.Parse(tarea["id"].ToString());
                        int permitido = Convert.ToInt32(clbRolPermisos.GetItemChecked(cb));

                        int i = sp.InsertPermiso(insertedRolId, tareaId, permitido);

                        if (i == 0)
                        {
                            errorPermisos = true;
                            //errorMsg = "Rol creado, pero ocurrio un error al guardar los permisos.";
                        }

                        cb++;
                    }
                }

                if (insertedRolId > 0 && !errorPermisos)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Rol creado exitosamente.");
                    fo.LimpiarForm();

                    foreach (int i in clbRolPermisos.CheckedIndices)
                    {
                        clbRolPermisos.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }

                else if (insertedRolId > 0 && errorPermisos)
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Rol creado, pero hubo errores almacenando los permisos.", error = true);
                    fo.LimpiarForm();

                    foreach (int i in clbRolPermisos.CheckedIndices)
                    {
                        clbRolPermisos.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }

                else
                {
                    fo.MostrarLabelMsg(lblResultadoMsg, "Ocurrió un error al crear el rol. Intente nuevamente.", error = true);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();

            foreach (int i in clbRolPermisos.CheckedIndices)
            {
                clbRolPermisos.SetItemCheckState(i, CheckState.Unchecked);
            }

            lblResultadoMsg.Visible = false;
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fo.LimpiarForm();

            foreach (int i in clbRolPermisos.CheckedIndices)
            {
                clbRolPermisos.SetItemCheckState(i, CheckState.Unchecked);
            }

            this.Close();
        }
    }
}
