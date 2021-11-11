using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AdminLTECreativa.Conexion
{
    public class Funciones
    {
        ConexionBD obj = new ConexionBD();
        NpgsqlDataReader dr;
        NpgsqlDataAdapter da;
        NpgsqlConnection cn;
        public int Registrar(string name, string lastname, string userr, string email, string password, string repassword, string rol)
        {
            if (Consulta(userr) == 1)
            {
                return 0;
            }
            else
            {
                string query = "INSERT INTO usuario(name, lastname, userr, email, password, repassword, rol) VALUES(@Name,@Lastname,@Userr,@Email,@Password,@Repassword,@Rol)";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Userr", userr);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Repassword", repassword);
                    if (rol == "1")
                    {
                        cmd.Parameters.AddWithValue("@Rol", '1');
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Rol", '2');
                    }
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }

        }
        public int Consulta(string username)
        {
            try
            {
                string query = "select userr from usuario where userr = @User";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@User", username);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No insertado: '{ex}'");
            }
            return 0;
        }
        public void ActualizarPassword(string username, string password)
        {
            try
            {
                string query = "update usuario set password = @Password where userr = @User";
                using (var cm = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cm.Parameters.AddWithValue("@User", username);
                    cm.Parameters.AddWithValue("@Password", password);
                    cm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"no actualizado: '{ex}'");
            }
        }
        public int Login(string username, string password)
        {
            try
            {
                string query = "select name, userr, password, rol from usuario where userr = @User and password = @Password";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@User", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string col1Value = dr["rol"].ToString();
                        if (col1Value.Equals("1")) {
                            return 1;
                        }
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No insertado: '{ex}'");
            }
            return 0;
        }
    }
}
