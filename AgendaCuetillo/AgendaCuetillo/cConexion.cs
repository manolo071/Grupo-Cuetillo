using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaCuetillo
{
    public class cConexion
    {
        SqlConnection conex = new SqlConnection();

        static string servidor;
        static string DB;
        static string user;
        static string password;
        static string puerto;

        string cadenaConexion = "Data sourcer" + servidor + "," + puerto + ";" + "user id=" + user + ";" + "password" + password + ";" + "Initial Catalog" + DB + ";" + "Persist Security Info=true";

        public SqlConnection establecerconexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Si se logro conectar a la DB");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la DB");
            }
            return conex;
        }

    }
}

