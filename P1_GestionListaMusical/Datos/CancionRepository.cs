using MySql.Data.MySqlClient;
using P1_GestionListaMusical.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_GestionListaMusical.Datos
{
    internal class CancionRepository
    {
        public List<Cancion> ObtenerTodas()
        {
            var canciones = new List<Cancion>();
            string query = "SELECT CancionID, Titulo, Artista, RutaArchivo, DuracionSegundos FROM Canciones";

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
                            canciones.Add(new Cancion
                            {
                                CancionID = reader.GetInt32("CancionID"),
                                Titulo = reader.GetString("Titulo"),
                                Artista = reader.GetString("Artista"),
                                RutaArchivo = reader.GetString("RutaArchivo"),
                                DuracionSegundos = reader.GetInt32("DuracionSegundos")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return canciones;
        }

        public Cancion ObtenerPorId(int id)
        {
            string query = "SELECT CancionID, Titulo, Artista, RutaArchivo, DuracionSegundos FROM Canciones WHERE CancionID = @id";
            Cancion cancion = null;

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
                            cancion = new Cancion
                            {
                                CancionID = reader.GetInt32("CancionID"),
                                Titulo = reader.GetString("Titulo"),
                                Artista = reader.GetString("Artista"),
                                RutaArchivo = reader.GetString("RutaArchivo"),
                                DuracionSegundos = reader.GetInt32("DuracionSegundos")
                            };
                        }
                    }
                }
            }
            return cancion;
        }

        public void Insertar(Cancion cancion)
        {
            string query = "INSERT INTO Canciones (Titulo, Artista, RutaArchivo, DuracionSegundos) VALUES (@Titulo, @Artista, @RutaArchivo, @DuracionSegundos)";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", cancion.Titulo);
                    cmd.Parameters.AddWithValue("@Artista", cancion.Artista);
                    cmd.Parameters.AddWithValue("@RutaArchivo", cancion.RutaArchivo);
                    cmd.Parameters.AddWithValue("@DuracionSegundos", cancion.DuracionSegundos);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Cancion cancion)
        {
            string query = "UPDATE Canciones SET Titulo = @Titulo, Artista = @Artista, RutaArchivo = @RutaArchivo, DuracionSegundos = @DuracionSegundos WHERE CancionID = @CancionID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", cancion.Titulo);
                    cmd.Parameters.AddWithValue("@Artista", cancion.Artista);
                    cmd.Parameters.AddWithValue("@RutaArchivo", cancion.RutaArchivo);
                    cmd.Parameters.AddWithValue("@DuracionSegundos", cancion.DuracionSegundos);
                    cmd.Parameters.AddWithValue("@CancionID", cancion.CancionID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int cancionId)
        {
            string query = "DELETE FROM Canciones WHERE CancionID = @CancionID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CancionID", cancionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
