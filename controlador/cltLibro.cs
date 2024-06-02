using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.controlador
{
    class cltLibro
    {
        private Conexion conexion = new Conexion();

        public List<Libros> BuscarLibros(string nombre, string codigo, string pais, string autor,bool validar)
        {
            List<Libros> librosEncontrados = new List<Libros>();
            try
            {

                using (SqlConnection con = conexion.AbrirConexion())
                {
                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.Append("SELECT l.*, e.*,e.codigo AS codigo_establecimiento, c.*, c.nombre AS nombre_categoria ");
                    queryBuilder.Append("FROM Libros l ");
                    queryBuilder.Append("INNER JOIN Establecimiento e ON l.id_establecimiento = e.id_establecimiento ");
                    queryBuilder.Append("INNER JOIN Categoria c ON l.id_categoria = c.id_categoria ");
                    queryBuilder.Append("WHERE ");

                    List<string> conditions = new List<string>();
                    List<string> parameters = new List<string>();
                    List<string> varl = new List<string>();
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        if (validar)
                        {
                            conditions.Add("l.nombre LIKE @nombre");
                        }
                        else
                        {
                            conditions.Add("l.nombre = @nombre");
                        }
                        
                        parameters.Add(nombre);
                        varl.Add("@nombre");
                    }

                    if (!string.IsNullOrEmpty(codigo))
                    {
                        if (validar)
                        {
                            conditions.Add("l.codigo LIKE @codigo");
                        }
                        else
                        {
                            conditions.Add("l.codigo = @codigo");
                        }
                        
                        parameters.Add(codigo);
                        varl.Add("@codigo");
                    }

                    if (!string.IsNullOrEmpty(pais))
                    {
                        conditions.Add("l.pais LIKE @pais");
                        parameters.Add(pais);
                        varl.Add("@pais");
                    }

                    if (!string.IsNullOrEmpty(autor))
                    {
                        conditions.Add("l.autor LIKE @autor");
                        parameters.Add(autor);
                        varl.Add("@autor");
                    }

                    // Agregar las condiciones al StringBuilder
                    if (validar)
                    {
                        queryBuilder.Append(string.Join(" OR ", conditions));
                    }
                    else
                    {
                        queryBuilder.Append(string.Join(" AND ", conditions));
                    }
                    

                    // Construir la consulta SQL final
                    string query = queryBuilder.ToString();
                    Console.WriteLine("La Query." + query);
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Agregar los parámetros necesarios
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        if (validar)
                        {
                            cmd.Parameters.AddWithValue(varl[i], "%" + parameters[i] + "%");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(varl[i], "" + parameters[i] + "");
                        }
                       
                        Console.WriteLine("condicon  " + varl[i]);
                        Console.WriteLine("Parametros " + parameters[i]);
                    }


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libros libro = new Libros();
                            libro.Id_libro = Convert.ToInt32(reader["id_libro"]);
                            libro.Nombre = reader["nombre"].ToString();
                            libro.Autor = reader["autor"].ToString();
                            libro.Fecha = reader["fecha"].ToString();
                            libro.Pais = reader["pais"].ToString();
                            libro.Fecha_ingreso = reader["fecha_ingreso"].ToString();
                            libro.Codigo = reader["codigo"].ToString();
                            libro.Disponible = Convert.ToInt32(reader["disponible"].ToString());
                            libro.Existencia = reader["existencia"].ToString();
                            libro.Estado = reader["estado"].ToString();

                            // Crear objeto Establecimiento
                            Establecimiento establecimiento = new Establecimiento();
                            establecimiento.Id_establecimiento = Convert.ToInt32(reader["id_establecimiento"]);
                            establecimiento.Cantida = Convert.ToInt32(reader["cantida"].ToString());
                            establecimiento.Codigo = reader["codigo_establecimiento"].ToString();

                            // Crear objeto Categoria
                            Categoria categoria = new Categoria();
                            categoria.Id_categoria = Convert.ToInt32(reader["id_categoria"]);
                            categoria.Nombre = reader["nombre_categoria"].ToString();
                            categoria.Campo_clase = reader["campo_clase"].ToString();
                            categoria.Genero = reader["genero"].ToString();
                            categoria.Tema_libro = reader["tema_libro"].ToString();

                            // Asignar objetos Establecimiento y Categoria al libro
                            libro.Establecimiento = establecimiento;
                            libro.Categoria = categoria;

                            librosEncontrados.Add(libro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al Buscar libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
            return librosEncontrados;
        }


        public List<Libros> ObtenerlistaLibros()
        {
            List<Libros> librosEncontrados = new List<Libros>();

            try
            {

                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT l.*, e.codigo AS establecimiento_codigo, c.nombre AS categoria_nombre " +
                                   "FROM Libros l " +
                                   "INNER JOIN Establecimiento e ON l.id_establecimiento = e.id_establecimiento " +
                                   "INNER JOIN Categoria c ON l.id_categoria = c.id_categoria";
                    SqlCommand cmd = new SqlCommand(query, con);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libros libro = new Libros();
                            libro.Id_libro = Convert.ToInt32(reader["id_libro"]);
                            libro.Nombre = reader["nombre"].ToString();
                            libro.Autor = reader["autor"].ToString();
                            libro.Fecha = reader["fecha"].ToString();
                            libro.Pais = reader["pais"].ToString();
                            libro.Fecha_ingreso = reader["fecha_ingreso"].ToString();
                            libro.Codigo = reader["codigo"].ToString();
                            libro.Disponible = Convert.ToInt32(reader["disponible"].ToString());
                            libro.Existencia = reader["existencia"].ToString();
                            libro.Estado = reader["estado"].ToString();

                            // Llenar las propiedades Establecimiento y Categoria
                            libro.Establecimiento = new Establecimiento() { Codigo = reader["establecimiento_codigo"].ToString() };
                            libro.Categoria = new Categoria() { Nombre = reader["categoria_nombre"].ToString() };

                            librosEncontrados.Add(libro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al Buscar libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
            return librosEncontrados;
        }

        // Método para agregar un nuevo libro
        public void AgregarLibro(Libros libro)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO Libros (nombre, autor, fecha, pais, fecha_ingreso, codigo, disponible, existencia,estado, id_establecimiento, id_categoria) 
                                     VALUES (@nombre, @autor, @fecha, @pais, @fecha_ingreso, @codigo, @disponible, @existencia,@estado, @id_establecimiento, @id_categoria)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", libro.Nombre);
                    cmd.Parameters.AddWithValue("@autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@fecha", libro.Fecha);
                    cmd.Parameters.AddWithValue("@pais", libro.Pais);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", libro.Fecha_ingreso);
                    cmd.Parameters.AddWithValue("@codigo", libro.Codigo);
                    cmd.Parameters.AddWithValue("@disponible", libro.Disponible);
                    cmd.Parameters.AddWithValue("@existencia", libro.Existencia);
                    cmd.Parameters.AddWithValue("@estado", libro.Estado);
                    cmd.Parameters.AddWithValue("@id_establecimiento", libro.Establecimiento.Id_establecimiento); // Suponiendo que Establecimiento tiene una propiedad Id_establecimiento
                    cmd.Parameters.AddWithValue("@id_categoria", libro.Categoria.Id_categoria); // Suponiendo que Categoria tiene una propiedad Id_categoria

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al Crear libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        // Método para actualizar un libro existente
        public void ActualizarLibro(Libros libro)
        {
            try
            { 
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"UPDATE Libros SET nombre = @nombre, autor = @autor, fecha = @fecha, pais = @pais, 
                                     fecha_ingreso = @fecha_ingreso, codigo = @codigo, disponible = @disponible, existencia = @existencia,
                                     estado = @estado, id_establecimiento = @id_establecimiento, id_categoria = @id_categoria 
                                     WHERE id_libro = @id_libro";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", libro.Nombre);
                    cmd.Parameters.AddWithValue("@autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@fecha", libro.Fecha);
                    cmd.Parameters.AddWithValue("@pais", libro.Pais);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", libro.Fecha_ingreso);
                    cmd.Parameters.AddWithValue("@codigo", libro.Codigo);
                    cmd.Parameters.AddWithValue("@disponible", libro.Disponible);
                    cmd.Parameters.AddWithValue("@existencia", libro.Existencia);
                    cmd.Parameters.AddWithValue("@estado", libro.Estado);
                    cmd.Parameters.AddWithValue("@id_establecimiento", libro.Establecimiento.Id_establecimiento); // Suponiendo que Establecimiento tiene una propiedad Id_establecimiento
                    cmd.Parameters.AddWithValue("@id_categoria", libro.Categoria.Id_categoria); // Suponiendo que Categoria tiene una propiedad Id_categoria
                    cmd.Parameters.AddWithValue("@id_libro", libro.Id_libro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        // Método para eliminar un libro
        public void EliminarLibro(int idLibro)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Libros WHERE id_libro = @id_libro";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id_libro", idLibro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al eliminar libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        /*
        *  Metodos para generar Prestamo
        */
        public void ActualizarLibroxPrestamo(Libros libro)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"UPDATE Libros SET disponible = @disponible, estado = @estado WHERE id_libro = @id_libro";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@disponible", libro.Disponible);
                    cmd.Parameters.AddWithValue("@estado", libro.Estado);
                    cmd.Parameters.AddWithValue("@id_libro", libro.Id_libro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar libro: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }

        }

        // Método para actualizar el estado de un libro
        public void ActualizarEstadoLibro(string codigoLibro, string nuevoEstado)
        {
            Console.WriteLine("ActualizarEstadoLibro codigoLibro." + codigoLibro);
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    // Consulta SQL para actualizar el estado del libro y aumentar en uno el valor de la columna Disponible
                    string query = @"UPDATE Libros SET Estado = @nuevoEstado, Disponible = Disponible + 1 WHERE Codigo = @codigoLibro";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@codigoLibro", codigoLibro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al actualizar el estado del libro: " + ex.Message);
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
