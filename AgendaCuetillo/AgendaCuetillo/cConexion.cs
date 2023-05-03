using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace AgendaCuetillo
{
    public class cConexion
    {
        SqlConnection conex = new SqlConnection();
        protected OleDbConnection conexion;
        static string servidor = "localhost";
        static string DB = "DBAgenda";
        static string user = "Agenda";
        static string password = "726965602016";
        static string puerto = "1433";

        string cadenaConexion = "Data source=" + servidor + "," + puerto + ";" + "user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + DB + ";" + "Persist Security Info=true";

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

        public OleDbConnection conexionBD()
        {
            try
            {
                conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBAgenda.accdb");
                conexion.Open();
                MessageBox.Show("Si se logro conectar a la DB");
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logro conectar a la DB");
            }
            return conexion;
        }

    }
}

