using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.controlador
{
    class ctlEstablecimiento
    {
        private Conexion conexion = new Conexion();

        // Método para crear un nuevo establecimiento con validación de código duplicado
        public bool CrearEstablecimiento(Establecimiento establecimiento)
        {
            try
            {

                // Si no existe un establecimiento con el mismo código, proceder con la inserción
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Establecimiento (cantida, codigo, cantidadAgr, cantidadActual) VALUES (@cantida, @codigo, @cantidadAgr, @cantidadActual)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cantida", establecimiento.Cantida);
                    cmd.Parameters.AddWithValue("@codigo", establecimiento.Codigo);
                    cmd.Parameters.AddWithValue("@cantidadAgr", establecimiento.CantidadAgr);
                    cmd.Parameters.AddWithValue("@cantidadActual", establecimiento.CantidadActual);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el establecimiento: " + ex.Message);
                return false;
            }
        }

        // Método para obtener todos los establecimientos
        public List<Establecimiento> ObtenerEstablecimientos()
        {
            List<Establecimiento> establecimientos = new List<Establecimiento>();
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Establecimiento";
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Establecimiento establecimiento = new Establecimiento();
                            establecimiento.Id_establecimiento = Convert.ToInt32(reader["id_establecimiento"]);
                            establecimiento.Cantida = Convert.ToInt32(reader["cantida"]);
                            establecimiento.Codigo = reader["codigo"].ToString();
                            establecimiento.CantidadAgr = Convert.ToInt32(reader["cantidadAgr"]);
                            establecimiento.CantidadActual = Convert.ToInt32(reader["cantidadActual"]);
                            establecimientos.Add(establecimiento);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los establecimientos: " + ex.Message);
            }
            return establecimientos;
        }

        // Método para actualizar un establecimiento existente
        public bool ActualizarEstablecimiento(Establecimiento establecimiento)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "UPDATE Establecimiento SET cantida = @cantida, codigo = @codigo, cantidadAgr = @cantidadAgr, cantidadActual = @cantidadActual WHERE id_establecimiento = @id_establecimiento";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cantida", establecimiento.Cantida);
                    cmd.Parameters.AddWithValue("@codigo", establecimiento.Codigo);
                    cmd.Parameters.AddWithValue("@cantidadAgr", establecimiento.CantidadAgr);
                    cmd.Parameters.AddWithValue("@cantidadActual", establecimiento.CantidadActual);
                    cmd.Parameters.AddWithValue("@id_establecimiento", establecimiento.Id_establecimiento);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el establecimiento: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un establecimiento existente
        public bool EliminarEstablecimiento(int id_establecimiento)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Establecimiento WHERE id_establecimiento = @id_establecimiento";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id_establecimiento", id_establecimiento);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el establecimiento: " + ex.Message);
                return false;
            }
        }

        // Método para buscar un establecimiento por código
        public Establecimiento BuscarEstablecimientoPorCodigo(string codigo)
        {
            Establecimiento establecimientoEncontrado = null;
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Establecimiento WHERE codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            establecimientoEncontrado = new Establecimiento();
                            establecimientoEncontrado.Id_establecimiento = Convert.ToInt32(reader["id_establecimiento"]);
                            establecimientoEncontrado.Cantida = Convert.ToInt32(reader["cantida"]);
                            establecimientoEncontrado.Codigo = reader["codigo"].ToString();
                            establecimientoEncontrado.CantidadAgr = Convert.ToInt32(reader["cantidadAgr"]);
                            establecimientoEncontrado.CantidadActual = Convert.ToInt32(reader["cantidadActual"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar el establecimiento por código: " + ex.Message);
            }
            return establecimientoEncontrado;
        }

    }
}
