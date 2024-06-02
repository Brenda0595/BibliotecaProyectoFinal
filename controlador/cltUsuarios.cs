using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using BibliotecaProyecto.modelo;

namespace BibliotecaProyecto.controlador
{
    class cltUsuarios
    {
        private Conexion conexion = new Conexion();

        public Usuario IsValidUser(string username, string password)
        {
            string query = "SELECT * FROM Usuario WHERE username = @Username AND contrasena = @Password";
            Usuario usuario = null;

            using (SqlConnection connection = conexion.AbrirConexion())
            {
                try
                {
                    Console.WriteLine("La query: " + query);
                    SqlCommand comando = new SqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@Username", username);
                    comando.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Direccion = reader["direccion"].ToString(),
                                Dui = reader["dui"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Username = reader["username"].ToString(),
                                Contrasena = reader["contrasena"].ToString(),
                                Estado = reader["estado"].ToString()
                            };
                        }
                    }

                    Console.WriteLine("usuario: " + (usuario != null));
                    return usuario;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Aseguramos que la conexión se cierre correctamente
                    // Cerramos la conexión fuera del bloque using
                    conexion.CerrarConexion();
                    Console.WriteLine("Cerramos la conexion...");
                }
            }

            // Cerramos la conexión fuera del bloque using
            conexion.CerrarConexion();
            return usuario;
        }

        // Método para crear un nuevo usuario
        public int CrearUsuario(Usuario usuario)
        {
            int respuesta = 1;
            try
            {              
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    // Verificar si el nombre de usuario ya existe
                    string queryValidar = "SELECT COUNT(*) FROM Usuario WHERE username = @Username";
                    SqlCommand comando = new SqlCommand(queryValidar, con);
                    comando.Parameters.AddWithValue("@Username", usuario.Username);
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    if (count > 0)
                    {
                        return respuesta;
                    }
                    

                    string query = "INSERT INTO Usuario (nombre, apellido, correo, direccion, telefono, dui, username, contrasena,estado) " +
                                   "VALUES (@nombre, @apellido, @correo, @direccion, @telefono, @dui, @username, @contrasena, @estado)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@dui", usuario.Dui);
                    cmd.Parameters.AddWithValue("@username", usuario.Username);
                    cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        respuesta = 0;
                    }
                        

                    return respuesta;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el usuario: " + ex.Message);
                return 2;
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        // Método para obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Usuario";
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            //usuario.Id_usuario = reader["id_usuario"].ToString();
                            usuario.Id_usuario = Convert.ToInt32(reader["id_usuario"].ToString());
                            usuario.Nombre = reader["nombre"].ToString();
                            usuario.Apellido = reader["apellido"].ToString();
                            usuario.Correo = reader["correo"].ToString();
                            usuario.Direccion = reader["direccion"].ToString();
                            usuario.Telefono = reader["telefono"].ToString();
                            usuario.Dui = reader["dui"].ToString();
                            usuario.Username = reader["username"].ToString();
                            usuario.Contrasena = reader["contrasena"].ToString();
                            usuario.Estado = reader["estado"].ToString();
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
            return usuarios;
        }

        // Método para actualizar un usuario existente
        public int ActualizarUsuario(Usuario usuario)
        {
            int respuesta = 1;
            try
            {

                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, correo = @correo, " +
                                   "direccion = @direccion, telefono = @telefono, dui = @dui, username = @username, " +
                                   "contrasena = @contrasena,estado = @estado WHERE id_usuario = @id_usuario";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@dui", usuario.Dui);
                    cmd.Parameters.AddWithValue("@username", usuario.Username);
                    cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        respuesta = 0;
                    }

                    return respuesta;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
                return 1;
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        // Método para eliminar un usuario existente
        public bool EliminarUsuario(int id_usuario)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Usuario WHERE id_usuario = @id_usuario";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                return false;
            }
            finally
            {
                // Aseguramos que la conexión se cierre correctamente
                Console.WriteLine("Cerramos la conexion...");
                conexion.CerrarConexion();
            }
        }

        private bool NombreUsuarioExiste(string username)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE username = @Username";
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    SqlCommand comando = new SqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                return false;
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

    
