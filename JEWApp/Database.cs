using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JEWApp
{
    class Database
    {
        private SqlConnection db;

        public SqlConnection conectar()
        {
            db = new SqlConnection(@"Data Source=DESKTOP-S412P7J\SQLEXPRESS;Initial Catalog=jewdb;Integrated Security=True");
            return db;
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
