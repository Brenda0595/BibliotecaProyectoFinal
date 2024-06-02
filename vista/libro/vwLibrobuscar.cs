using BibliotecaProyecto.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaProyecto.modelo;

namespace BibliotecaProyecto.vista.libro
{
    public partial class vwLibrobuscar : Form
    {
        public vwLibrobuscar()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnBuscar.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Cambia el color de fondo del boton btnBuscar 
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtNombre.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtCodigo.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtAutor.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtPais.BackColor = ColorTranslator.FromHtml("#EAEAEA");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Limpiar los datos existentes en el DataGridView
            dtgvwBuscar.DataSource = null;
            dtgvwBuscar.Rows.Clear();

            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "";
            }

            string codigo = txtCodigo.Text;
            if (string.IsNullOrEmpty(codigo))
            {
                codigo = "";
            }

            string autor = txtAutor.Text;
            if (string.IsNullOrEmpty(autor))
            {
                autor = "";
            }

            string pais = txtPais.Text;
            if (string.IsNullOrEmpty(pais))
            {
                pais = "";
            }

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(codigo)
                && string.IsNullOrEmpty(autor) && string.IsNullOrEmpty(pais))
            {
                MessageBox.Show("Por favor ingrese un dato para la busqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener la lista de libro a buscar
            cltLibro ctllibro = new cltLibro();
            List<Libros> listaLibro = ctllibro.BuscarLibros(nombre,codigo,pais,autor,true);

            Console.WriteLine("La lista. " + listaLibro.Count);
            // Verificar si la lista de categorías no es nula y tiene elementos
            if (listaLibro != null && listaLibro.Count > 0)
            {
                // Crear una tabla para almacenar los datos
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Autor");
                tabla.Columns.Add("Fecha");
                tabla.Columns.Add("Pais");
                tabla.Columns.Add("Fecha de ingreso");
                tabla.Columns.Add("Codigo");
                tabla.Columns.Add("Disponible");
                tabla.Columns.Add("Existencia");
                tabla.Columns.Add("Establecimiento");
                tabla.Columns.Add("Categoria");
                tabla.Columns.Add("ID");

                // Llenar la tabla con los datos de las categorías
                foreach (Libros libro in listaLibro)
                {
                    tabla.Rows.Add(libro.Nombre, libro.Autor, libro.Fecha,
                        libro.Pais, libro.Fecha_ingreso, libro.Codigo, libro.Disponible,
                        libro.Existencia
                        ,libro.Establecimiento.Codigo,libro.Categoria.Nombre,
                        libro.Id_libro);
                }

                // Asignar la tabla como origen de datos del DataGridView
                dtgvwBuscar.DataSource = tabla;
            }
            else
            {
                // Mostrar mensaje si la lista esta vacia
                MessageBox.Show("No hay se encontro registro para esos valores ingresados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de Libro está vacía o nula.");
            }
        }

    }
}
