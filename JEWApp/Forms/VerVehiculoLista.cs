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
    public partial class VerVehiculoLista : Form
    {
        private StoredProcedure sp;
        private FormOperations fo;

        public VerVehiculoLista()
        {
            InitializeComponent();

            sp = new StoredProcedure();
            fo = new FormOperations(this);
        }
    }
}
