using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JEWApp
{
    class StoredProcedure
    {
        Database db = new Database();

        public void DeleteFacturaDetalle(int facturaId, int productoId)
        {
            string storedProcedureName = "sp_delete_factura_detalle";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;

            da.DeleteCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            da.DeleteCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;

            db.desconectar();
        }

        public void InsertCliente(int tipoId, int tipoDocId, string docId, string nombreCliente, string apellidoCliente, string direccionCliente, string telefonoCliente, string correoCliente, int fechaNacDia, int fechaNacMes, int fechaNacAno)
        {
            string storedProcedureName = "sp_insert_cliente";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@TipoId", SqlDbType.Int).Value = tipoId;
            da.InsertCommand.Parameters.Add("@TipoDocId", SqlDbType.Int).Value = tipoDocId;
            da.InsertCommand.Parameters.Add("@DocId", SqlDbType.NVarChar).Value = docId;
            da.InsertCommand.Parameters.Add("@NombreCliente", SqlDbType.NVarChar).Value = nombreCliente;
            da.InsertCommand.Parameters.Add("@ApellidoCliente", SqlDbType.NVarChar).Value = apellidoCliente;
            da.InsertCommand.Parameters.Add("@DireccionCliente", SqlDbType.NVarChar).Value = direccionCliente;
            da.InsertCommand.Parameters.Add("@TelefonoCliente", SqlDbType.NChar).Value = telefonoCliente;
            da.InsertCommand.Parameters.Add("@CorreoCliente", SqlDbType.NVarChar).Value = correoCliente;
            da.InsertCommand.Parameters.Add("@FechaNacDia", SqlDbType.TinyInt).Value = fechaNacDia;
            da.InsertCommand.Parameters.Add("@FechaNacMes", SqlDbType.TinyInt).Value = fechaNacMes;
            da.InsertCommand.Parameters.Add("@FechaNacAno", SqlDbType.Int).Value = fechaNacAno;

            db.desconectar();
        }

        public void InsertEmpleado( int roldId, int tipoDocId, string docId, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string correoEmpleado, string passwordEmpleado)
        {
            string storedProcedureName = "sp_insert_empleado";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@RolId", SqlDbType.Int).Value = roldId;
            da.InsertCommand.Parameters.Add("@TipoDocId", SqlDbType.Int).Value = tipoDocId;
            da.InsertCommand.Parameters.Add("@DocId", SqlDbType.NVarChar).Value = docId;
            da.InsertCommand.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar).Value = nombreEmpleado;
            da.InsertCommand.Parameters.Add("@ApellidoEmpleado", SqlDbType.NVarChar).Value = apellidoEmpleado;
            da.InsertCommand.Parameters.Add("@TelefonoEmpleado", SqlDbType.NChar).Value = telefonoEmpleado;
            da.InsertCommand.Parameters.Add("@CorreoEmpleado", SqlDbType.NVarChar).Value = correoEmpleado;
            da.InsertCommand.Parameters.Add("@PasswordEmpleado", SqlDbType.NVarChar).Value = passwordEmpleado;

            db.desconectar();
        }

        public void InsertFactura(int clienteId, int estadoId, string descrFactura)
        {
            string storedProcedureName = "sp_insert_factura";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            da.InsertCommand.Parameters.Add("@EstadoId", SqlDbType.Int).Value = estadoId;
            da.InsertCommand.Parameters.Add("@DescrFactura", SqlDbType.NVarChar).Value = descrFactura;

            db.desconectar();
        }

        public void InsertFacturaDetalle(int facturaId, int productoId, int vehiculoId, int empleadoId, double cantidad, double precio)
        {
            string storedProcedureName = "sp_insert_factura_detalle";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            da.InsertCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            da.InsertCommand.Parameters.Add("@VehiculoId", SqlDbType.Int).Value = vehiculoId;
            da.InsertCommand.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = empleadoId;
            da.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = cantidad;
            da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;

            db.desconectar();
        }

        public void InsertProductoInventario(int productoId, double cantidadDisponible, double cantidadMinima, double precio)
        {
            string storedProcedureName = "sp_insert_producto_inventario";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            da.InsertCommand.Parameters.Add("@CantidadDisponible", SqlDbType.Decimal).Value = cantidadDisponible;
            da.InsertCommand.Parameters.Add("@CantidadMinima", SqlDbType.Decimal).Value = cantidadMinima;
            da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;

            db.desconectar();
        }

        public void InsertVehiculo(int clienteId, int marcaId, int modeloId, int anoVehiculo, string matriculaVehiculo, string descrVehiculo)
        {
            string storedProcedureName = "sp_insert_vehiculo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.InsertCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            da.InsertCommand.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcaId;
            da.InsertCommand.Parameters.Add("@ModeloId", SqlDbType.Int).Value = modeloId;
            da.InsertCommand.Parameters.Add("@Anovehiculo", SqlDbType.Int).Value = anoVehiculo;
            da.InsertCommand.Parameters.Add("@MatriculaVehiculo", SqlDbType.NVarChar).Value = matriculaVehiculo;
            da.InsertCommand.Parameters.Add("@DescrVehiculo", SqlDbType.NVarChar).Value = descrVehiculo;

            db.desconectar();
        }

        public DataTable SelectCliente(int clienteId = 0)
        {
            string storedProcedureName = "sp_select_cliente";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if ( 0 != clienteId)
            {
                da.SelectCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectClienteTipo(int clienteTipoId = 0)
        {
            string storedProcedureName = "sp_select_cliente_tipo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != clienteTipoId)
            {
                da.SelectCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteTipoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectEmpleado(int empleadoId = 0)
        {
            string storedProcedureName = "sp_select_empleado";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != empleadoId)
            {
                da.SelectCommand.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = empleadoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectFactura(int facturaId = 0)
        {
            string storedProcedureName = "sp_select_factura";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != facturaId)
            {
                da.SelectCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectFacturaDetalle(int facturaId)
        {
            string storedProcedureName = "sp_select_factura_detalle";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectFacturaEstado(int estadoId = 0)
        {
            string storedProcedureName = "sp_select_factura_estado";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != estadoId)
            {
                da.SelectCommand.Parameters.Add("@EstadoId", SqlDbType.Int).Value = estadoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectInventario()
        {
            string storedProcedureName = "sp_select_inventario";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectPermiso(int usuarioId)
        {
            string storedProcedureName = "sp_select_permiso";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@UsuarioId", SqlDbType.Int).Value = usuarioId;

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectProducto(int productoId = 0)
        {
            string storedProcedureName = "sp_select_producto";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != productoId)
            {
                da.SelectCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectProductoCategoria(int categoriaId = 0)
        {
            string storedProcedureName = "sp_select_producto_categoria";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != categoriaId)
            {
                da.SelectCommand.Parameters.Add("@CategoriaId", SqlDbType.Int).Value = categoriaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectProductoMedida(int medidaId = 0)
        {
            string storedProcedureName = "sp_select_producto_medida";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != medidaId)
            {
                da.SelectCommand.Parameters.Add("@MedidaId", SqlDbType.Int).Value = medidaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectRol(int rolId = 0)
        {
            string storedProcedureName = "sp_select_rol";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != rolId)
            {
                da.SelectCommand.Parameters.Add("@RolId", SqlDbType.Int).Value = rolId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectTarea(int tareaId = 0)
        {
            string storedProcedureName = "sp_select_tarea";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != tareaId)
            {
                da.SelectCommand.Parameters.Add("@TareaId", SqlDbType.Int).Value = tareaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectTipoDocId(int tipoDocId = 0)
        {
            string storedProcedureName = "sp_select_tipo_docid";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != tipoDocId)
            {
                da.SelectCommand.Parameters.Add("@DocId", SqlDbType.Int).Value = tipoDocId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectVehiculo(int vehiculoId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != vehiculoId)
            {
                da.SelectCommand.Parameters.Add("@VehiculoId", SqlDbType.Int).Value = vehiculoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectVehiculoMarca(int marcaId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo_marca";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != marcaId)
            {
                da.SelectCommand.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable SelectVehiculoModelo(int modeloId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo_modelo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != modeloId)
            {
                da.SelectCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = modeloId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }

        public DataTable VerifyEmpleadoLogin(string email, string password)
        {
            string storedProcedureName = "sp_verify_empleado_login";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@LoginEmail", SqlDbType.Int).Value = email;
            da.SelectCommand.Parameters.Add("@LoginPassword", SqlDbType.Int).Value = password;

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.desconectar();

            return dt;
        }
    }
}
