using MySql.Data.MySqlClient;
using System.Collections.Generic;
using P1_GestionListaMusical.Modelos;
using System;

namespace P1_GestionListaMusical.Datos
{
    public class ListaRepository
    {
        public List<Lista> ObtenerTodas()
        {
            var listas = new List<Lista>();
            string query = "SELECT ListaID, Nombre, Descripcion, ModoReproduccion FROM Listas";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listas.Add(new Lista
                        {
                            ListaID = reader.GetInt32("ListaID"),
                            Nombre = reader.GetString("Nombre"),
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                            ModoReproduccion = reader.IsDBNull(reader.GetOrdinal("ModoReproduccion")) ? "Secuencial" : reader.GetString("ModoReproduccion")
                        });
                    }
                }
            }
            return listas;
        }

        public Lista ObtenerPorId(int id)
        {
            string query = "SELECT ListaID, Nombre, Descripcion, ModoReproduccion FROM Listas WHERE ListaID = @id";
            Lista lista = null;

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
                            lista = new Lista
                            {
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                                ModoReproduccion = reader.IsDBNull(reader.GetOrdinal("ModoReproduccion")) ? "Secuencial" : reader.GetString("ModoReproduccion")
                            };
                        }
                    }
                }
            }
            return lista;
        }

        public List<Cancion> ObtenerCancionesDeLista(int listaId)
        {
            var canciones = new List<Cancion>();
            string query = @"
                SELECT c.CancionID, c.Titulo, c.Artista, c.RutaArchivo, c.DuracionSegundos
                FROM Canciones c
                JOIN CancionLista cl ON c.CancionID = cl.CancionID
                WHERE cl.ListaID = @ListaID
                ORDER BY cl.Orden ASC";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ListaID", listaId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            canciones.Add(new Cancion
                            {
                                CancionID = reader.GetInt32("CancionID"),
                                Titulo = reader.IsDBNull(reader.GetOrdinal("Titulo")) ? "Sin Título" : reader.GetString("Titulo"),
                                Artista = reader.IsDBNull(reader.GetOrdinal("Artista")) ? "" : reader.GetString("Artista"),
                                RutaArchivo = reader.IsDBNull(reader.GetOrdinal("RutaArchivo")) ? "" : reader.GetString("RutaArchivo"),
                                DuracionSegundos = reader.IsDBNull(reader.GetOrdinal("DuracionSegundos")) ? 0 : reader.GetInt32("DuracionSegundos")
                            });
                        }
                    }
                }
            }
            return canciones;
        }

        public void AgregarCancionALista(int listaId, int cancionId)
        {
            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM CancionLista WHERE ListaID = @ListaID AND CancionID = @CancionID";
                using (var cmdCheck = new MySqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@ListaID", listaId);
                    cmdCheck.Parameters.AddWithValue("@CancionID", cancionId);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0) return;
                }

                string orderQuery = "SELECT COALESCE(MAX(Orden), 0) + 1 FROM CancionLista WHERE ListaID = @ListaID";
                int nextOrder = 1;
                using (var cmdOrder = new MySqlCommand(orderQuery, conn))
                {
                    cmdOrder.Parameters.AddWithValue("@ListaID", listaId);
                    nextOrder = Convert.ToInt32(cmdOrder.ExecuteScalar());
                }

                string insertQuery = "INSERT INTO CancionLista (ListaID, CancionID, Orden) VALUES (@ListaID, @CancionID, @Orden)";
                using (var cmdInsert = new MySqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@ListaID", listaId);
                    cmdInsert.Parameters.AddWithValue("@CancionID", cancionId);
                    cmdInsert.Parameters.AddWithValue("@Orden", nextOrder);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        public void QuitarCancionDeLista(int listaId, int cancionId)
        {
            string query = "DELETE FROM CancionLista WHERE ListaID = @ListaID AND CancionID = @CancionID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ListaID", listaId);
                    cmd.Parameters.AddWithValue("@CancionID", cancionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int Insertar(Lista lista)
        {
            string query = "INSERT INTO Listas (Nombre, Descripcion, ModoReproduccion) VALUES (@Nombre, @Descripcion, @Modo); SELECT LAST_INSERT_ID();";
            int newId = 0;

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", lista.Nombre ?? "Nueva Lista");
                    cmd.Parameters.AddWithValue("@Descripcion", lista.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@Modo", lista.ModoReproduccion ?? "Secuencial");
                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return newId;
        }

        public void Actualizar(Lista lista)
        {
            string query = "UPDATE Listas SET Nombre = @Nombre, Descripcion = @Descripcion, ModoReproduccion = @Modo WHERE ListaID = @ID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", lista.Nombre ?? "Lista Modificada");
                    cmd.Parameters.AddWithValue("@Descripcion", lista.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@Modo", lista.ModoReproduccion ?? "Secuencial");
                    cmd.Parameters.AddWithValue("@ID", lista.ListaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Listas WHERE ListaID = @id";
            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}