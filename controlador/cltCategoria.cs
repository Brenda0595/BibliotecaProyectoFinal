using BibliotecaProyecto.modelo;
using BibliotecaProyecto.vista.categoria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.controlador
{
    class cltCategoria
    {
        private Conexion conexion = new Conexion();

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Categoria";
                    SqlCommand comando = new SqlCommand(query, connection);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria();
                            categoria.Id_categoria = Convert.ToInt32(reader["id_categoria"]);
                           // categoria.Id_categoria = reader["id_categoria"].ToString();
                            categoria.Nombre = reader["nombre"].ToString();
                            categoria.Campo_clase = reader["campo_clase"].ToString();
                            categoria.Genero = reader["genero"].ToString();
                            categoria.Tema_libro = reader["tema_libro"].ToString();
                            categorias.Add(categoria);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al obtener categorías: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }

            return categorias;
        }

        public void InsertarCategoria(Categoria categoria)
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Categoria (nombre, campo_clase, genero, tema_libro) " +
                                   "VALUES (@nombre, @campo_clase, @genero, @tema_libro)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@campo_clase", categoria.Campo_clase);
                    cmd.Parameters.AddWithValue("@genero", categoria.Genero);
                    cmd.Parameters.AddWithValue("@tema_libro", categoria.Tema_libro);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al insertar categoría: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    string query = "UPDATE Categoria SET nombre = @nombre, campo_clase = @campo_clase, " +
                                   "genero = @genero, tema_libro = @tema_libro WHERE id_categoria = @id_categoria";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@campo_clase", categoria.Campo_clase);
                    cmd.Parameters.AddWithValue("@genero", categoria.Genero);
                    cmd.Parameters.AddWithValue("@tema_libro", categoria.Tema_libro);
                    cmd.Parameters.AddWithValue("@id_categoria", categoria.Id_categoria);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al actualizar categoría: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        public void EliminarCategoria(int id_categoria)
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Categoria WHERE id_categoria = @id_categoria";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al eliminar categoría: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }
    }
}
