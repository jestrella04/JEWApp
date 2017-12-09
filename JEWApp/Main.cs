using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace JEWApp
{
    public partial class Main : Form
    {
        private Login loginForm;
        private StoredProcedure sp;

        public Main(Login login)
        {
            sp = new StoredProcedure();
            InitializeComponent();
            loginForm = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool sesionIniciada = Session.sesionIniciada;

            if (! sesionIniciada)
            {
                this.Close();
                loginForm.txtLoginEmail.Text = "";
                loginForm.txtLoginPassword.Text = "";
                loginForm.Show();
            }

            else
            {
                DataTable userInfo = sp.SelectEmpleado(Session.empleadoId);
                lblStatusBarLoginMessage.Text = "Bienvenido a JEWApp " + userInfo.Rows[0]["nombre_completo"] + ".";

                var permisoUsuarioCrear = Session.empleadoPermisos.Select("nombre_tarea = 'crear empleado'");
                var permisoUsuarioVer = Session.empleadoPermisos.Select("nombre_tarea = 'ver empleado'");
                var permisoRolCrear = Session.empleadoPermisos.Select("nombre_tarea = 'crear rol'");
                var permisoRolVer = Session.empleadoPermisos.Select("nombre_tarea = 'ver rol'");
                var permisoClienteCrear = Session.empleadoPermisos.Select("nombre_tarea = 'crear cliente'");
                var permisoClienteVer = Session.empleadoPermisos.Select("nombre_tarea = 'ver cliente'");
                var permisoProductoCrear = Session.empleadoPermisos.Select("nombre_tarea = 'crear producto'");
                var permisoProductoVer = Session.empleadoPermisos.Select("nombre_tarea = 'ver producto'");
                var permisoProductoInventario = Session.empleadoPermisos.Select("nombre_tarea = 'inventario'");
                var permisoFacturaCrear = Session.empleadoPermisos.Select("nombre_tarea = 'factura crear'");
                var permisoFacturaVer = Session.empleadoPermisos.Select("nombre_tarea = 'ver factura'");
                var permisoReporteComisiones = Session.empleadoPermisos.Select("nombre_tarea = 'reporte comisiones'");

                if (permisoUsuarioCrear == null || permisoUsuarioCrear.Length == 0) btnUsuarioCrear.Visible = false;
                if (permisoUsuarioVer == null || permisoUsuarioVer.Length == 0) btnUsuarioLista.Visible = false;
                if (permisoRolCrear == null || permisoRolCrear.Length == 0) btnRolCrear.Visible = false;
                if (permisoRolVer == null || permisoRolVer.Length == 0) btnRolLista.Visible = false;
                if (permisoClienteCrear == null || permisoClienteCrear.Length == 0) btnClienteCrear.Visible = false;
                if (permisoClienteVer == null || permisoClienteVer.Length == 0) btnClienteLista.Visible = false;
                if (permisoProductoCrear == null || permisoProductoCrear.Length == 0) btnProductoCrear.Visible = false;
                if (permisoProductoVer == null || permisoProductoVer.Length == 0) btnProductoLista.Visible = false;
                if (permisoProductoInventario == null || permisoProductoInventario.Length == 0) btnProductoInventario.Visible = false;
                if (permisoFacturaCrear == null || permisoFacturaCrear.Length == 0) btnFacturaCrear.Visible = false;
                if (permisoFacturaVer == null || permisoFacturaVer.Length == 0) btnFacturaLista.Visible = false;
                if (permisoReporteComisiones == null || permisoReporteComisiones.Length == 0) btnReporteComisiones.Visible = false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.sesionIniciada)
            {
                loginForm.Close();
            }
        }

        private void btnSesionCerrar_Click(object sender, EventArgs e)
        {
            Session.sesionIniciada = false;
            this.Close();
            loginForm.txtLoginEmail.Text = "";
            loginForm.txtLoginPassword.Text = "";
            loginForm.Show();
        }
    }
}
