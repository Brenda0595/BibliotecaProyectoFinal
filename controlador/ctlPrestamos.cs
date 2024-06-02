using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.controlador
{
    class ctlPrestamos
    {
        private Conexion conexion = new Conexion();

        // Método para crear un nuevo préstamo
        /*public bool CrearPrestamo(Prestamos prestamo)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Prestamos (nombre, apellido, correo, fecha_inicio, telefono, dui, fecha_fin, monto, cuota, estado, codigo_libro, codigo_usuario) " +
                                   "VALUES (@nombre, @apellido, @correo, @fecha_inicio, @telefono, @dui, @fecha_fin, @monto, @cuota, @estado,@codigo_libro, @codigo_usuario)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", prestamo.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", prestamo.Apellido);
                    cmd.Parameters.AddWithValue("@correo", prestamo.Correo);
                    cmd.Parameters.AddWithValue("@fecha_inicio", prestamo.Fecha_inicio);
                    cmd.Parameters.AddWithValue("@telefono", prestamo.Telefono);
                    cmd.Parameters.AddWithValue("@dui", prestamo.Dui);
                    cmd.Parameters.AddWithValue("@fecha_fin", prestamo.Fecha_fin);
                    cmd.Parameters.AddWithValue("@monto", prestamo.Monto);
                    cmd.Parameters.AddWithValue("@cuota", prestamo.Cuota);
                    cmd.Parameters.AddWithValue("@estado", prestamo.Estado);
                    cmd.Parameters.AddWithValue("@codigo_libro", prestamo.Codigo_libro.Id_libro);
                    cmd.Parameters.AddWithValue("@codigo_usuario", prestamo.Codigo_usuario.Id_usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el préstamo: " + ex.Message);
                return false;
            }
        }*/

        public bool CrearPrestamo(Prestamos prestamo, List<Libros> librosAgregados)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    // Insertar el préstamo en la tabla Prestamos
                    string query = "INSERT INTO Prestamos (nombre, apellido, correo, fecha_inicio, telefono, dui, fecha_fin, monto, cuota, estado, codigo, codigo_usuario) " +
                                   "VALUES (@nombre, @apellido, @correo, @fecha_inicio, @telefono, @dui, @fecha_fin, @monto, @cuota, @estado, @codigo, @codigo_usuario); " +
                                   "SELECT SCOPE_IDENTITY();"; // Obtiene el ID del registro insertado
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", prestamo.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", prestamo.Apellido);
                    cmd.Parameters.AddWithValue("@correo", prestamo.Correo);
                    cmd.Parameters.AddWithValue("@fecha_inicio", prestamo.Fecha_inicio);
                    cmd.Parameters.AddWithValue("@telefono", prestamo.Telefono);
                    cmd.Parameters.AddWithValue("@dui", prestamo.Dui);
                    cmd.Parameters.AddWithValue("@fecha_fin", prestamo.Fecha_fin);
                    cmd.Parameters.AddWithValue("@monto", prestamo.Monto);
                    cmd.Parameters.AddWithValue("@cuota", prestamo.Cuota);
                    cmd.Parameters.AddWithValue("@estado", prestamo.Estado);
                    cmd.Parameters.AddWithValue("@codigo", DBNull.Value); // Inicialmente, el campo código se deja en blanco
                    cmd.Parameters.AddWithValue("@codigo_usuario", prestamo.Codigo_usuario.Id_usuario);

                    // Obtener el ID del préstamo insertado
                    int idPrestamo = Convert.ToInt32(cmd.ExecuteScalar());

                    if (idPrestamo > 0)
                    {
                        // Actualizar el campo código con el ID del préstamo insertado
                        query = "UPDATE Prestamos SET codigo = @codigo WHERE id_codigoprestamo = @idPrestamo";
                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", "PR" + idPrestamo.ToString().PadLeft(6, '0')); // Aquí puedes definir el formato del código
                        cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                        cmd.ExecuteNonQuery();

                        // Insertar líneas de préstamo para cada libro agregado
                        foreach (Libros libro in librosAgregados)
                        {
                            query = "INSERT INTO lineaPrestamos (codigolinea_prestamos, nombre_libro, codigo_libro, nombre, apellido, correo, fecha_inicio, telefono, dui, fecha_fin, monto, cuota, estado, codigo) " +
                                    "VALUES (@codigolinea_prestamos, @nombre_libro, @codigo_libro, @nombre, @apellido, @correo, @fecha_inicio, @telefono, @dui, @fecha_fin, @monto, @cuota, @estado, @codigo)";
                            cmd.CommandText = query;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@codigolinea_prestamos", "" + idPrestamo); // Puedes definir el formato del código
                            cmd.Parameters.AddWithValue("@nombre_libro", libro.Nombre);
                            cmd.Parameters.AddWithValue("@codigo_libro", libro.Codigo);
                            cmd.Parameters.AddWithValue("@nombre", prestamo.Nombre);
                            cmd.Parameters.AddWithValue("@apellido", prestamo.Apellido);
                            cmd.Parameters.AddWithValue("@correo", prestamo.Correo);
                            cmd.Parameters.AddWithValue("@fecha_inicio", prestamo.Fecha_inicio);
                            cmd.Parameters.AddWithValue("@telefono", prestamo.Telefono);
                            cmd.Parameters.AddWithValue("@dui", prestamo.Dui);
                            cmd.Parameters.AddWithValue("@fecha_fin", prestamo.Fecha_fin);
                            cmd.Parameters.AddWithValue("@monto", prestamo.Monto);
                            cmd.Parameters.AddWithValue("@cuota", prestamo.Cuota);
                            cmd.Parameters.AddWithValue("@estado", prestamo.Estado);
                            cmd.Parameters.AddWithValue("@codigo", "PR" + idPrestamo.ToString().PadLeft(6, '0')); // Puedes definir el formato del código
                            cmd.ExecuteNonQuery();
                        }

                        // Actualizar el estado y la disponibilidad de cada libro agregado en la lista
                        foreach (Libros libro in librosAgregados)
                        {
                            libro.Disponible--; // Reducir la disponibilidad del libro
                            libro.Estado = (libro.Disponible > 0) ? "Disponible" : "No Disponible"; // Actualizar el estado del libro

                            // Llamar al método para actualizar el libro en la base de datos
                            ActualizarLibroxPrestamo(libro);
                        }

                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No se pudo obtener el ID del nuevo préstamo.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el préstamo: " + ex.Message);
                return false;
            }
        }


        // Método para obtener todos los préstamos
        public List<Prestamos> BuscarPrestamos(string nombre, string apellido, string correo, string dui, string usuario2, string estado)
        {
            List<Prestamos> prestamosEncontrados = new List<Prestamos>();
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.Append("SELECT p.id_codigoprestamo, p.nombre AS prestamo_nombre, p.apellido AS prestamo_apellido, p.correo AS prestamo_correo, ");
                    queryBuilder.Append("p.fecha_inicio AS prestamo_fecha_inicio, p.telefono AS prestamo_telefono, p.dui AS prestamo_dui, ");
                    queryBuilder.Append("p.fecha_fin AS prestamo_fecha_fin, p.monto AS prestamo_monto, p.cuota AS prestamo_cuota, ");
                    queryBuilder.Append("p.estado AS prestamo_estado,p.codigo AS prestamo_codigo, u.id_usuario, u.nombre AS usuario_nombre, u.apellido AS usuario_apellido, ");
                    queryBuilder.Append("u.correo AS usuario_correo, u.direccion AS usuario_direccion, u.telefono AS usuario_telefono, ");
                    queryBuilder.Append("u.dui AS usuario_dui, u.username AS usuario_username, u.contrasena AS usuario_contrasena, ");
                    queryBuilder.Append("u.estado AS usuario_estado ");
                    queryBuilder.Append("FROM Prestamos p ");
                    queryBuilder.Append("INNER JOIN Usuario u ON p.codigo_usuario = u.id_usuario ");

                    List<string> conditions = new List<string>();
                    List<string> parameters = new List<string>();
                    List<string> valor = new List<string>();

                    if (!string.IsNullOrEmpty(nombre))
                    {
                        conditions.Add("p.nombre LIKE @nombre");
                        parameters.Add(nombre);
                        valor.Add("@nombre");
                    }

                    if (!string.IsNullOrEmpty(apellido))
                    {
                        conditions.Add("p.apellido LIKE @apellido");
                        parameters.Add(apellido);
                        valor.Add("@apellido");
                    }

                    if (!string.IsNullOrEmpty(correo))
                    {
                        conditions.Add("p.correo LIKE @correo");
                        parameters.Add(correo);
                        valor.Add("@correo");
                    }

                    if (!string.IsNullOrEmpty(dui))
                    {
                        conditions.Add("p.dui LIKE @dui");
                        parameters.Add(dui);
                        valor.Add("@dui");
                    }

                    if (!string.IsNullOrEmpty(usuario2))
                    {
                        conditions.Add("p.codigo_usuario LIKE @usuario");
                        parameters.Add(usuario2);
                        valor.Add("@usuario");
                    }

                    if (!string.IsNullOrEmpty(estado))
                    {
                        conditions.Add("p.estado LIKE @estado");
                        parameters.Add(estado);
                        valor.Add("@estado");
                    }

                    if (conditions.Count > 0)
                    {
                        queryBuilder.Append(" WHERE ");
                        queryBuilder.Append(string.Join(" AND ", conditions));
                    }

                    string query = queryBuilder.ToString();
                    SqlCommand cmd = new SqlCommand(query, con);

                    for (int i = 0; i < parameters.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(valor[i], "%" + parameters[i] + "%");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prestamos prestamo = new Prestamos();
                            prestamo.Id_codigoprestamo = Convert.ToInt32(reader["id_codigoprestamo"]);
                            prestamo.Nombre = reader["prestamo_nombre"].ToString();
                            prestamo.Apellido = reader["prestamo_apellido"].ToString();
                            prestamo.Correo = reader["prestamo_correo"].ToString();
                            prestamo.Fecha_inicio = Convert.ToDateTime(reader["prestamo_fecha_inicio"]).ToString("yyyy-MM-dd");
                            prestamo.Telefono = reader["prestamo_telefono"].ToString();
                            prestamo.Dui = reader["prestamo_dui"].ToString();
                            prestamo.Fecha_fin = Convert.ToDateTime(reader["prestamo_fecha_fin"]).ToString("yyyy-MM-dd");
                            prestamo.Monto = reader["prestamo_monto"].ToString();
                            prestamo.Cuota = reader["prestamo_cuota"].ToString();
                            prestamo.Estado = reader["prestamo_estado"].ToString();
                            prestamo.Codigo = reader["prestamo_codigo"].ToString();

                            Usuario usuario = new Usuario();
                            usuario.Id_usuario = Convert.ToInt32(reader["id_usuario"]);
                            usuario.Nombre = reader["usuario_nombre"].ToString();
                            usuario.Apellido = reader["usuario_apellido"].ToString();
                            usuario.Correo = reader["usuario_correo"].ToString();
                            usuario.Direccion = reader["usuario_direccion"].ToString();
                            usuario.Telefono = reader["usuario_telefono"].ToString();
                            usuario.Dui = reader["usuario_dui"].ToString();
                            usuario.Username = reader["usuario_username"].ToString();
                            usuario.Contrasena = reader["usuario_contrasena"].ToString();
                            usuario.Estado = reader["usuario_estado"].ToString();

                            prestamo.Codigo_usuario = usuario;

                            prestamosEncontrados.Add(prestamo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar préstamos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return prestamosEncontrados;
        }

        /*
         * METODOS PARA CANCELAR LOS PRESTAMOS 
         * ESTOS METODOS SE UTILIZAN EN LA VISTA DE CANCELAR PRESTAMO
         */

        public Prestamos BuscarPrestamoPorCodigo(string codigo)
        {
            Prestamos prestamo = null;

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Prestamos WHERE codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        prestamo = new Prestamos();
                        prestamo.Id_codigoprestamo = Convert.ToInt32(reader["id_codigoprestamo"]);
                        prestamo.Nombre = reader["nombre"].ToString();
                        prestamo.Apellido = reader["apellido"].ToString();
                        prestamo.Correo = reader["correo"].ToString();
                        prestamo.Fecha_inicio = reader["fecha_inicio"].ToString();
                        prestamo.Telefono = reader["telefono"].ToString();
                        prestamo.Dui = reader["dui"].ToString();
                        prestamo.Fecha_fin = reader["fecha_fin"].ToString();
                        prestamo.Monto = reader["monto"].ToString();
                        prestamo.Cuota = reader["cuota"].ToString();
                        prestamo.Estado = reader["estado"].ToString();
                        prestamo.Codigo = reader["codigo"].ToString();
                        // Asignar otros campos según sea necesario
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar el préstamo por código: " + ex.Message);
            }

            return prestamo;
        }

        public List<LineaPrestamos> ObtenerLineasPrestamoPorCodigo(string codigoPrestamo)
        {
            List<LineaPrestamos> lineasPrestamo = new List<LineaPrestamos>();

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM lineaPrestamos WHERE codigo = @codigoPrestamo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@codigoPrestamo", codigoPrestamo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        LineaPrestamos linea = new LineaPrestamos();
                        linea.Id_codigolineaprestamo = Convert.ToInt32(reader["id_codigolineaprestamo"]);
                        linea.Codigolinea_prestamos = reader["codigolinea_prestamos"].ToString();
                        linea.Nombre_libro = reader["nombre_libro"].ToString();
                        linea.Codigo_libro = reader["codigo_libro"].ToString();
                        linea.Nombre = reader["nombre"].ToString();
                        linea.Apellido = reader["apellido"].ToString();
                        linea.Correo = reader["correo"].ToString();
                        linea.Fecha_inicio = Convert.ToDateTime(reader["fecha_inicio"]);
                        linea.Telefono = reader["telefono"].ToString();
                        linea.Dui = reader["dui"].ToString();
                        linea.Fecha_fin = Convert.ToDateTime(reader["fecha_fin"]);
                        linea.Monto = Convert.ToDecimal(reader["monto"]);
                        linea.Cuota = Convert.ToDecimal(reader["cuota"]);
                        linea.Estado = reader["estado"].ToString();
                        linea.Codigo = reader["codigo"].ToString();
                        // Asignar otros campos según sea necesario
                        lineasPrestamo.Add(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las líneas de préstamo por código: " + ex.Message);
            }

            return lineasPrestamo;
        }

        // Método para actualizar el estado de una línea de préstamo
        public void ActualizarEstadoLineaPrestamo(int codigoLinea, string codigo, string nuevoEstado)
        {
            try
            {

                Console.WriteLine("Datos." + codigoLinea + " -- " + codigo + " -- " + nuevoEstado);
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"UPDATE lineaPrestamos SET Estado = @nuevoEstado WHERE id_codigolineaprestamo = @codigoLinea AND codigo = @codigo";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@codigoLinea", codigoLinea);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al actualizar el estado de la línea de préstamo: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        // Método para actualizar el estado de un préstamo
        public void ActualizarEstadoPrestamo(string codigoPrestamo, string nuevoEstado)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"UPDATE Prestamos SET Estado = @nuevoEstado WHERE Codigo = @codigoPrestamo";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@codigoPrestamo", codigoPrestamo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al actualizar el estado del préstamo: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }


        // Método para actualizar un préstamo existente
        public bool ActualizarPrestamo(Prestamos prestamo)
        {
            // Implementa el método para actualizar un préstamo
            return false;
        }

        // Método para eliminar un préstamo existente
        public bool EliminarPrestamo(int id_codigoprestamo)
        {
            // Implementa el método para eliminar un préstamo
            return false;
        }

        public void ActualizarLibroxPrestamo(Libros libro)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = @"UPDATE Libros SET disponible = @disponible, estado = @estado WHERE id_libro = @id_libro";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Verificar si el valor disponible es mayor a cero
                    if (libro.Disponible > 0)
                    {
                        cmd.Parameters.AddWithValue("@disponible", libro.Disponible - 1); // Restar 1 al valor disponible
                        cmd.Parameters.AddWithValue("@estado", "Disponible"); // Establecer el estado como Disponible
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@disponible", 0); // Establecer el valor disponible como cero
                        cmd.Parameters.AddWithValue("@estado", "No Disponible"); // Establecer el estado como No Disponible
                    }

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

    }
}
