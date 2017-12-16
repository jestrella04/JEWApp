using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEWApp
{
    public class FormOperations
    {
        private Form formOps;

        public FormOperations(Form theForm)
        {
            formOps = theForm;

            formaAllBtn();
        }

        public void formaAllBtn()
        {
            foreach (Control c in formOps.Controls)
            {
                if (c is Button)
                {
                    formatBtn(((Button)c));
                }

                else if (c is GroupBox)
                {
                    foreach (Control gb in c.Controls)
                    {
                        if (gb is Button)
                        {
                            formatBtn(((Button)gb));
                        }
                    }
                }
            }
        }

        public void formatBtn(Button btn)
        {
            btn.ForeColor = Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            if (!String.IsNullOrWhiteSpace(btn.Text))
            {
                if (btn.Text == "Crear" || btn.Text == "Actualizar" || btn.Text == "Iniciar Sesión")
                {
                    btn.BackColor = ColorTranslator.FromHtml("#F50057");
                }

                else if (btn.Text == "Agregar Producto")
                {
                    btn.BackColor = ColorTranslator.FromHtml("#FF4081");
                }

                else
                {
                    btn.BackColor = ColorTranslator.FromHtml("#F06292");
                }
            }
        }

        public void LimpiarForm()
        {
            foreach (Control c in formOps.Controls)
            {
                if (c is TextBox) c.Text = "";

                if (c is GroupBox)
                {
                    foreach (Control gb in c.Controls)
                    {
                        if (gb is TextBox)
                        {
                            gb.Text = "";
                        }
                    }
                }
            }
        }

        public void LimpiarCheckedListBox(CheckedListBox box)
        {
            foreach (int i in box.CheckedIndices)
            {
                box.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        public void LlenarCombo(ComboBox cmb, DataTable dt)
        {
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "nombre";
        }

        public void LlenarCheckedListBox(CheckedListBox box, DataTable dt)
        {
            box.DataSource = dt;
            box.ValueMember = "id";
            box.DisplayMember = "nombre";
        }

        public void MostrarLabelMsg(Label label, string msg, bool error = false)
        {
            label.Text = msg;

            if (error)
            {
                label.ForeColor = ColorTranslator.FromHtml("#F50057");
            }

            else
            {
                label.ForeColor = ColorTranslator.FromHtml("#2E7D32");
            }

            label.Visible = true;
        }
    }
}
