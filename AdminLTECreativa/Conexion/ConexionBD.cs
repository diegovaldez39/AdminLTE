using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AdminLTECreativa.Conexion
{
    public class ConexionBD
    {
        public static string server = "localhost";
        public static string port = "5432";
        public static string username = "postgres";
        public static string password = "123";
        public static string database = "creativa";
        public static string cadena = "Server = " + server + "; Port = " + port + "; Username = " + username + "; Password = " + password + "; Database = " + database;
        NpgsqlConnection cn;

        public NpgsqlConnection Conecta() {
            try
            {
                cn = new NpgsqlConnection(cadena);
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                throw;
            }
  
        }
    }
}
