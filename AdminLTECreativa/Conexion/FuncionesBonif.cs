using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTECreativa.Models;
using Npgsql;

namespace AdminLTECreativa.Conexion
{
    public class FuncionesBonif
    {
        readonly ConexionBD obj = new();
        NpgsqlDataReader dr;
        readonly List<Solicitude> solicitudes = new List<Solicitude>();
        private static creativaContext Context { get; set; }

        public int Consulta(string email, string mes)
        {
            try
            {
                string query = "select email, mes from bonificacion where email = @Email and mes = @Mes";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mes", mes);
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
        public int RegistrarBonificacion(string email, DateTime fecha, string name, string lastname, string dui, string cargo, string mes)
        {
            if (Consulta(email, mes) == 1)
            {
                return 0;
            }
            else
            {
                string query = "INSERT INTO solicitudes(email, fecha, name, lastname, dui, cargo, mes, tipoSolicitud, estado) VALUES(@Email,@Fecha,@Name,@Lastname,@Dui,@Cargo,@Mes,'Bonificacion','Pendiente')";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Dui", dui);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    cmd.Parameters.AddWithValue("@Mes", mes);
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
        }
        public int RegistrarHorasE(string email, DateTime fecha, string name, string lastname, string dui, string cargo, string mes)
        {

                string query = "INSERT INTO solicitudes(email, fecha, name, lastname, dui, cargo, mes, tipoSolicitud, estado) VALUES(@Email,@Fecha,@Name,@Lastname,@Dui,@Cargo,@Mes,'Horas Extras', 'Pendiente')";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Dui", dui);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    cmd.Parameters.AddWithValue("@Mes", mes);
                    cmd.ExecuteNonQuery();
                    return 1;
            }
        }
        public int RegistrarAdelSal(string email, DateTime fecha, string name, string lastname, string dui, string mes, string mesDesc)
        {
                string query = "INSERT INTO solicitudes(email, fecha, name, lastname, dui, mes, mesDesc, tipoSolicitud, estado) VALUES(@Email,@Fecha,@Name,@Lastname,@Dui,@Mes,@MesDesc,'Anticipo Salarial','Pendiente')";
                using (var cmd = new NpgsqlCommand(query, obj.Conecta()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Dui", dui);
                    cmd.Parameters.AddWithValue("@Mes", mes);
                    cmd.Parameters.AddWithValue("@MesDesc", mesDesc);
                    cmd.ExecuteNonQuery();
                    return 1;
            }
        }
    }
}
