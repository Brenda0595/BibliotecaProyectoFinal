using BibliotecaProyecto.controlador;
using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto.vista.prestamo
{
    public partial class Dialogobusquedalibro : Form
    {

        generarPrestamos generarP;
        Usuario usuario;
        public Dialogobusquedalibro(generarPrestamos generarPrestamo,Usuario user)
        {
            InitializeComponent();
            this.generarP = generarPrestamo;
            this.usuario = user;
            dtgriviwDialogo.CellClick += dtgriviwDialogo_Click;
        }

        private void btnbuscarlibro_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnbuscarlibro_Click");
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtNlibro.Text) && string.IsNullOrEmpty(txtCodigoLibro.Text))
            {
                MessageBox.Show("Debe agregar un campo de Busqueda codigo o nombre del libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNlibro.Text;
            string codigo = txtCodigoLibro.Text;
            // Obtener la lista de libro a buscar
            cltLibro ctllibro = new cltLibro();
            List<Libros> listaLibro = ctllibro.BuscarLibros(nombre, codigo, "", "", true);

            // Verificar si la lista de usuarios no es nula y tiene elementos
            if (listaLibro != null && listaLibro.Count > 0)
            {
                // Crear una tabla para almacenar los datos
                DataTable tablaDialogo = new DataTable();

                tablaDialogo.Columns.Add("Nombre Libro");
                tablaDialogo.Columns.Add("Codigo Libro");
                tablaDialogo.Columns.Add("Author");
                tablaDialogo.Columns.Add("Disponibilidad");
                tablaDialogo.Columns.Add("Categoria");
                tablaDialogo.Columns.Add("Establecimiento");
                tablaDialogo.Columns.Add("ID");


                // Llenar la tabla con los datos de los usuarios
                foreach (Libros libro in listaLibro)
                {
                    tablaDialogo.Rows.Add(libro.Nombre,libro.Codigo,libro.Autor,libro.Disponible,libro.Categoria.Nombre,libro.Establecimiento.Codigo,libro.Id_libro);
                }

                // Asignar la tabla como origen de datos del DataGridView
                dtgriviwDialogo.DataSource = tablaDialogo;
            }
            else
            {
                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de usuarios está vacía o nula.");
            }


        }

        private void dtgriviwDialogo_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de la columna deseada (puedes usar e.ColumnIndex para verificar la columna)
            Console.WriteLine("Proceso. " + (e.RowIndex >= 0) + " -- " + (e.ColumnIndex >= 0));
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Console.WriteLine(dtgriviwDialogo.Rows[e.RowIndex]);
                // Obtener la fila seleccionada
                DataGridViewRow row = dtgriviwDialogo.Rows[e.RowIndex];

                // Obtener los datos de la fila seleccionada
                string nombreLibro = row.Cells["Nombre Libro"].Value.ToString();
                string codigoLibro = row.Cells["Codigo Libro"].Value.ToString();
                string autor = row.Cells["Author"].Value.ToString();
                string disponibilidad = row.Cells["Disponibilidad"].Value.ToString();
                string categoria = row.Cells["Categoria"].Value.ToString();
                string establecimiento = row.Cells["Establecimiento"].Value.ToString();
                string idlibro = row.Cells["ID"].Value.ToString();

                Console.WriteLine("CAMBIAR DE VISTA.");
                // Crear una instancia de generarPrestamos y pasar los datos del libro      
                generarP.ShowDatosLibro_Click(nombreLibro, codigoLibro, autor, disponibilidad, categoria, establecimiento, idlibro);
                //generarPrestamos instanciaGenerarPrestamos = new generarPrestamos(usuario);
                //Dialogobusquedalibro dialogo = new Dialogobusquedalibro(instanciaGenerarPrestamos, usuario);
                //dialogo.Close();
                this.Close();
            }
        }
 
    }
}