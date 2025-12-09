using MySql.Data.MySqlClient;
using System.Collections.Generic;
using P1_GestionListaMusical.Modelos;
using System.Linq;
using System;

namespace P1_GestionListaMusical.Datos
{
    public class HorarioRepository
    {
        public List<Horario> ObtenerTodos()
        {
            var horarios = new List<Horario>();
            string query = "SELECT EventoID, ListaID, Nombre, ReglaRRule, InicioRegla, Excepciones, EstaActivo FROM Horarios";

            try
            {
                using (var conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horarios.Add(new Horario
                            {
                                EventoID = reader.GetInt32("EventoID"),
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                ReglaRRule = reader.IsDBNull(reader.GetOrdinal("ReglaRRule")) ? null : reader.GetString("ReglaRRule"),
                                InicioRegla = reader.GetDateTime("InicioRegla"),
                                Excepciones = reader.IsDBNull(reader.GetOrdinal("Excepciones")) ? null : reader.GetString("Excepciones"),
                                EstaActivo = reader.GetBoolean("EstaActivo")
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return horarios;
        }

        public List<Horario> ObtenerHorariosActivos()
        {
            var horarios = new List<Horario>();
            string query = "SELECT EventoID, ListaID, Nombre, ReglaRRule, InicioRegla, Excepciones, EstaActivo FROM Horarios WHERE EstaActivo = 1";

            try
            {
                using (var conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horarios.Add(new Horario
                            {
                                EventoID = reader.GetInt32("EventoID"),
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                ReglaRRule = reader.IsDBNull(reader.GetOrdinal("ReglaRRule")) ? null : reader.GetString("ReglaRRule"),
                                InicioRegla = reader.GetDateTime("InicioRegla"),
                                Excepciones = reader.IsDBNull(reader.GetOrdinal("Excepciones")) ? null : reader.GetString("Excepciones"),
                                EstaActivo = reader.GetBoolean("EstaActivo")
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return horarios;
        }

        public Horario ObtenerPorId(int id)
        {
            string query = "SELECT EventoID, ListaID, Nombre, ReglaRRule, InicioRegla, Excepciones, EstaActivo FROM Horarios WHERE EventoID = @id";
            Horario horario = null;

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            horario = new Horario
                            {
                                EventoID = reader.GetInt32("EventoID"),
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                ReglaRRule = reader.IsDBNull(reader.GetOrdinal("ReglaRRule")) ? null : reader.GetString("ReglaRRule"),
                                InicioRegla = reader.GetDateTime("InicioRegla"),
                                Excepciones = reader.IsDBNull(reader.GetOrdinal("Excepciones")) ? null : reader.GetString("Excepciones"),
                                EstaActivo = reader.GetBoolean("EstaActivo")
                            };
                        }
                    }
                }
            }
            return horario;
        }

        public List<string> ObtenerRutasAudioPorLista(int listaId)
        {
            var rutas = new List<string>();
            string query = @"
                SELECT C.RutaArchivo 
                FROM Canciones C
                JOIN CancionLista CL ON C.CancionID = CL.CancionID
                WHERE CL.ListaID = @listaId
                ORDER BY CL.Orden ASC";

            try
            {
                using (var conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@listaId", listaId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rutas.Add(reader.GetString("RutaArchivo"));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return rutas;
        }

        public void Insertar(Horario horario)
        {
            string query = @"
                INSERT INTO Horarios (ListaID, Nombre, EstaActivo, ReglaRRule, InicioRegla, Excepciones) 
                VALUES (@ListaID, @Nombre, @EstaActivo, @ReglaRRule, @InicioRegla, @Excepciones)";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ListaID", horario.ListaID);
                    cmd.Parameters.AddWithValue("@Nombre", horario.Nombre);
                    cmd.Parameters.AddWithValue("@EstaActivo", horario.EstaActivo);
                    cmd.Parameters.AddWithValue("@ReglaRRule", horario.ReglaRRule);
                    cmd.Parameters.AddWithValue("@InicioRegla", horario.InicioRegla);
                    cmd.Parameters.AddWithValue("@Excepciones", horario.Excepciones);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Horario horario)
        {
            string query = @"
                UPDATE Horarios SET 
                ListaID = @ListaID, Nombre = @Nombre, EstaActivo = @EstaActivo, 
                ReglaRRule = @ReglaRRule, InicioRegla = @InicioRegla, Excepciones = @Excepciones
                WHERE EventoID = @EventoID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ListaID", horario.ListaID);
                    cmd.Parameters.AddWithValue("@Nombre", horario.Nombre);
                    cmd.Parameters.AddWithValue("@EstaActivo", horario.EstaActivo);
                    cmd.Parameters.AddWithValue("@ReglaRRule", horario.ReglaRRule);
                    cmd.Parameters.AddWithValue("@InicioRegla", horario.InicioRegla);
                    cmd.Parameters.AddWithValue("@Excepciones", horario.Excepciones);
                    cmd.Parameters.AddWithValue("@EventoID", horario.EventoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int eventoId)
        {
            string query = "DELETE FROM Horarios WHERE EventoID = @EventoID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventoID", eventoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}