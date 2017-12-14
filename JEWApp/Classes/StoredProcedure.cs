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

        public int DeleteFacturaDetalle(int facturaId, int productoId)
        {
            string storedProcedureName = "sp_delete_factura_detalle";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertCliente(int tipoId, int tipoDocId, string docId, string nombreCliente, string apellidoCliente, string direccionCliente, string telefonoCliente, string correoCliente, int fechaNacDia = 0, int fechaNacMes = 0, int fechaNacAno = 0)
        {
            string storedProcedureName = "sp_insert_cliente";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TipoId", SqlDbType.Int).Value = tipoId;
            cmd.Parameters.Add("@TipoDocId", SqlDbType.Int).Value = tipoDocId;
            cmd.Parameters.Add("@DocId", SqlDbType.NVarChar, 50).Value = docId;
            cmd.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = nombreCliente;
            cmd.Parameters.Add("@ApellidoCliente", SqlDbType.NVarChar, 50).Value = apellidoCliente;
            cmd.Parameters.Add("@DireccionCliente", SqlDbType.NVarChar, 50).Value = direccionCliente;
            cmd.Parameters.Add("@TelefonoCliente", SqlDbType.NChar, 10).Value = telefonoCliente;
            cmd.Parameters.Add("@CorreoCliente", SqlDbType.NVarChar, 50).Value = correoCliente;

            if (fechaNacDia > 0) cmd.Parameters.Add("@FechaNacDia", SqlDbType.TinyInt).Value = fechaNacDia;
            if (fechaNacMes > 0) cmd.Parameters.Add("@FechaNacMes", SqlDbType.TinyInt).Value = fechaNacMes;
            if (fechaNacAno > 0) cmd.Parameters.Add("@FechaNacAno", SqlDbType.Int).Value = fechaNacAno;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertEmpleado( int roldId, int tipoDocId, string docId, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string correoEmpleado, string passwordEmpleado)
        {
            string storedProcedureName = "sp_insert_empleado";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@RolId", SqlDbType.Int).Value = roldId;
            cmd.Parameters.Add("@TipoDocId", SqlDbType.Int).Value = tipoDocId;
            cmd.Parameters.Add("@DocId", SqlDbType.NVarChar, 50).Value = docId;
            cmd.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar, 50).Value = nombreEmpleado;
            cmd.Parameters.Add("@ApellidoEmpleado", SqlDbType.NVarChar, 50).Value = apellidoEmpleado;
            cmd.Parameters.Add("@TelefonoEmpleado", SqlDbType.NChar, 10).Value = telefonoEmpleado;
            cmd.Parameters.Add("@CorreoEmpleado", SqlDbType.NVarChar, 50).Value = correoEmpleado;
            cmd.Parameters.Add("@PasswordEmpleado", SqlDbType.NVarChar, 255).Value = passwordEmpleado;

            int affectedRows;

            db.conectar();

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }
            
            db.desconectar();

            return affectedRows;
        }

        public int InsertFactura(int clienteId, int estadoId, string descrFactura)
        {
            string storedProcedureName = "sp_insert_factura";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            cmd.Parameters.Add("@EstadoId", SqlDbType.Int).Value = estadoId;
            cmd.Parameters.Add("@DescrFactura", SqlDbType.NVarChar, 255).Value = descrFactura;
            cmd.Parameters.Add("@InsertedFacturaId", SqlDbType.Int).Direction = ParameterDirection.Output;

            db.conectar();

            int insertedId;

            try
            {
                cmd.ExecuteNonQuery();
                insertedId = Convert.ToInt32(cmd.Parameters["@InsertedFacturaId"].Value);
            }

            catch
            {
                insertedId = 0;
            }

            db.desconectar();

            return insertedId;
        }

        public int InsertFacturaDetalle(int facturaId, int productoId, int vehiculoId, int empleadoId, double cantidad, double precio)
        {
            string storedProcedureName = "sp_insert_factura_detalle";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;

            if (vehiculoId != 0) cmd.Parameters.Add("@VehiculoId", SqlDbType.Int).Value = vehiculoId;

            cmd.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = empleadoId;
            cmd.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = cantidad;
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;

            cmd.Parameters["@Cantidad"].Precision = 11;
            cmd.Parameters["@Cantidad"].Scale = 2;
            cmd.Parameters["@Precio"].Precision = 11;
            cmd.Parameters["@Precio"].Scale = 2;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertPermiso(int rolId, int tareaId, int permitido)
        {
            string storedProcedureName = "sp_insert_permiso";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@RolId", SqlDbType.Int).Value = rolId;
            cmd.Parameters.Add("@TareaId", SqlDbType.Int).Value = tareaId;
            cmd.Parameters.Add("@Permitido", SqlDbType.Int).Value = permitido;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertProducto(int categoriaId, int medidaId, string nombreProducto, string descrProducto)
        {
            string storedProcedureName = "sp_insert_producto";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CategoriaId", SqlDbType.Int).Value = categoriaId;
            cmd.Parameters.Add("@MedidaId", SqlDbType.Int).Value = medidaId;
            cmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 50).Value = nombreProducto;
            cmd.Parameters.Add("@DescrProducto", SqlDbType.NVarChar, 255).Value = descrProducto;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertProductoInventario(int productoId, double cantidadDisponible, double cantidadMinima, double precio)
        {
            string storedProcedureName = "sp_insert_producto_inventario";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            cmd.Parameters.Add("@CantidadDisponible", SqlDbType.Decimal).Value = cantidadDisponible;
            cmd.Parameters.Add("@CantidadMinima", SqlDbType.Decimal).Value = cantidadMinima;
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;

            cmd.Parameters["@CantidadDisponible"].Precision = 11;
            cmd.Parameters["@CantidadDisponible"].Scale = 2;
            cmd.Parameters["@CantidadMinima"].Precision = 11;
            cmd.Parameters["@CantidadMinima"].Scale = 2;
            cmd.Parameters["@Precio"].Precision = 11;
            cmd.Parameters["@Precio"].Scale = 2;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public int InsertRol(string nombreRol, string descrRol)
        {
            string storedProcedureName = "sp_insert_rol";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@RolNombre", SqlDbType.NVarChar, 50).Value = nombreRol;
            cmd.Parameters.Add("@RolDescr", SqlDbType.NVarChar, 255).Value = descrRol;
            cmd.Parameters.Add("@InsertedRolId", SqlDbType.Int).Direction = ParameterDirection.Output;

            db.conectar();

            int insertedId;

            try
            {
                cmd.ExecuteNonQuery();
                insertedId = Convert.ToInt32(cmd.Parameters["@InsertedRolId"].Value);
            }

            catch
            {
                insertedId = 0;
            }
            
            db.desconectar();

            return insertedId;
        }

        public int InsertVehiculo(int clienteId, int marcaId, int modeloId, int anoVehiculo, string matriculaVehiculo, string descrVehiculo)
        {
            string storedProcedureName = "sp_insert_vehiculo";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            cmd.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcaId;
            cmd.Parameters.Add("@ModeloId", SqlDbType.Int).Value = modeloId;
            cmd.Parameters.Add("@Anovehiculo", SqlDbType.Int).Value = anoVehiculo;
            cmd.Parameters.Add("@MatriculaVehiculo", SqlDbType.NVarChar, 50).Value = matriculaVehiculo;
            cmd.Parameters.Add("@DescrVehiculo", SqlDbType.NVarChar, 255).Value = descrVehiculo;

            db.conectar();

            int affectedRows;

            try
            {
                affectedRows = cmd.ExecuteNonQuery();
            }

            catch
            {
                affectedRows = 0;
            }

            db.desconectar();

            return affectedRows;
        }

        public DataTable SelectCliente(int clienteId = 0)
        {
            string storedProcedureName = "sp_select_cliente";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != clienteId)
            {
                da.SelectCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectClienteTipo(int clienteTipoId = 0)
        {
            string storedProcedureName = "sp_select_cliente_tipo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != clienteTipoId)
            {
                da.SelectCommand.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteTipoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectEmpleado(int empleadoId = 0)
        {
            string storedProcedureName = "sp_select_empleado";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != empleadoId)
            {
                da.SelectCommand.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = empleadoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectFactura(int facturaId = 0)
        {
            string storedProcedureName = "sp_select_factura";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != facturaId)
            {
                da.SelectCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectFacturaDetalle(int facturaId)
        {
            string storedProcedureName = "sp_select_factura_detalle";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectFacturaEstado(int estadoId = 0)
        {
            string storedProcedureName = "sp_select_factura_estado";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != estadoId)
            {
                da.SelectCommand.Parameters.Add("@EstadoId", SqlDbType.Int).Value = estadoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectInventario(int productoId = 0)
        {
            string storedProcedureName = "sp_select_inventario";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != productoId)
            {
                da.SelectCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectPermiso(int rolId, int selectAll = 0)
        {
            string storedProcedureName = "sp_select_permiso";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@RolId", SqlDbType.Int).Value = rolId;

            if (0 != selectAll)
            {
                da.SelectCommand.Parameters.Add("@SelectAll", SqlDbType.Int).Value = selectAll;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectProducto(int productoId = 0)
        {
            string storedProcedureName = "sp_select_producto";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != productoId)
            {
                da.SelectCommand.Parameters.Add("@ProductoId", SqlDbType.Int).Value = productoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectProductoCategoria(int categoriaId = 0)
        {
            string storedProcedureName = "sp_select_producto_categoria";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != categoriaId)
            {
                da.SelectCommand.Parameters.Add("@CategoriaId", SqlDbType.Int).Value = categoriaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectProductoMedida(int medidaId = 0)
        {
            string storedProcedureName = "sp_select_producto_medida";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != medidaId)
            {
                da.SelectCommand.Parameters.Add("@MedidaId", SqlDbType.Int).Value = medidaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectRol(int rolId = 0)
        {
            string storedProcedureName = "sp_select_rol";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != rolId)
            {
                da.SelectCommand.Parameters.Add("@RolId", SqlDbType.Int).Value = rolId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectTarea(int tareaId = 0)
        {
            string storedProcedureName = "sp_select_tarea";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != tareaId)
            {
                da.SelectCommand.Parameters.Add("@TareaId", SqlDbType.Int).Value = tareaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectTipoDocId(int tipoDocId = 0)
        {
            string storedProcedureName = "sp_select_tipo_docid";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != tipoDocId)
            {
                da.SelectCommand.Parameters.Add("@DocId", SqlDbType.Int).Value = tipoDocId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectVehiculo(int vehiculoId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != vehiculoId)
            {
                da.SelectCommand.Parameters.Add("@VehiculoId", SqlDbType.Int).Value = vehiculoId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectVehiculoMarca(int marcaId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo_marca";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != marcaId)
            {
                da.SelectCommand.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcaId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable SelectVehiculoModelo(int modeloId = 0)
        {
            string storedProcedureName = "sp_select_vehiculo_modelo";
            SqlDataAdapter da = new SqlDataAdapter(storedProcedureName, db.getDbConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (0 != modeloId)
            {
                da.SelectCommand.Parameters.Add("@ModeloId", SqlDbType.Int).Value = modeloId;
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string VerifyEmpleadoLogin(string email, string password)
        {
            string storedProcedureName = "sp_verify_empleado_login";
            SqlCommand cmd = new SqlCommand(storedProcedureName, db.getDbConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LoginEmail", SqlDbType.NVarChar, 50).Value = email;
            cmd.Parameters.Add("@LoginPassword", SqlDbType.NVarChar, 50).Value = password;
            cmd.Parameters.Add("@ResponseMessage", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;

            db.conectar();
            cmd.ExecuteNonQuery();
            string result = Convert.ToString(cmd.Parameters["@ResponseMessage"].Value);
            db.desconectar();
            return result;
        }
    }
}
