using MySql.Data.MySqlClient;
using P1_GestionListaMusical.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_GestionListaMusical.Datos
{
    internal class ListaRepository
    {
        public List<Lista> ObtenerTodas()
        {
            var listas = new List<Lista>();
            string query = "SELECT ListaID, Nombre, Descripcion, ModoReproduccion FROM Listas";

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
                            listas.Add(new Lista
                            {
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                Descripcion = reader.GetString("Descripcion"),
                                ModoReproduccion = reader.GetString("ModoReproduccion")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
                                Descripcion = reader.GetString("Descripcion"),
                                ModoReproduccion = reader.GetString("ModoReproduccion")
                            };
                        }
                    }
                }
            }
            return lista;
        }

        public void Insertar(Lista lista)
        {
            string query = "INSERT INTO Listas (Nombre, Descripcion, ModoReproduccion) VALUES (@Nombre, @Descripcion, @ModoReproduccion)";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", lista.Descripcion);
                    cmd.Parameters.AddWithValue("@ModoReproduccion", lista.ModoReproduccion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Lista lista)
        {
            string query = "UPDATE Listas SET Nombre = @Nombre, Descripcion = @Descripcion, ModoReproduccion = @ModoReproduccion WHERE ListaID = @ListaID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", lista.Descripcion);
                    cmd.Parameters.AddWithValue("@ModoReproduccion", lista.ModoReproduccion);
                    cmd.Parameters.AddWithValue("@ListaID", lista.ListaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int listaId)
        {
            string query = "DELETE FROM Listas WHERE ListaID = @ListaID";

            using (var conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ListaID", listaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
