using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JEWApp
{
    public class Database
    {
        private string connectionString = @"Data Source=DESKTOP-52K7R3D\SQLEXPRESS;Initial Catalog=jewdb;Integrated Security=True";
        private SqlConnection db;

        public Database()
        {
            db = new SqlConnection(connectionString);
        }

        public SqlConnection getDbConnection()
        {
            return db;
        }

        public void conectar()
        {
            db.Open();
        }

        public void desconectar()
        {
            db.Close();
        }

        public DataTable consultaStringDT(String sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, db);

            da.Fill(dt);
            return dt;
        }
    }
}
