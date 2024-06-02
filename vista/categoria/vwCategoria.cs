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

namespace BibliotecaProyecto.vista.categoria
{
    public partial class vwCategoria : Form
    {

        public vwCategoria()
        {
            InitializeComponent();
            LlenarComboBoxes();
            MostrarCategoriasEnDataGridView();
            dtgvwCategoria.CellClick += dtgvwCategoria_CellClick;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnAgregar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnEditar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnEliminar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtnombcategoria.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtIdCategoria.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
            cmbGenero.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            cmbClase.BackColor = ColorTranslator.FromHtml("#EAEAEA");
      
        }

        private void LlenarComboBoxes()
        {
            // Llenar el ComboBox de Clase
            cmbClase.Items.Add("A");
            cmbClase.Items.Add("B");
            cmbClase.Items.Add("C");
            cmbClase.Items.Add("D");

            // Llenar el ComboBox de Género
            cmbGenero.Items.Add("Mujer");
            cmbGenero.Items.Add("Niñes");
            cmbGenero.Items.Add("Hombre");
            cmbGenero.Items.Add("Toda Familia");
        }


        private void MostrarCategoriasEnDataGridView()
        {
            // Limpiar los datos existentes en el DataGridView
            dtgvwCategoria.DataSource = null;
            dtgvwCategoria.Rows.Clear();

            // Obtener la lista de categorías
            cltCategoria controladorCategoria = new cltCategoria();
            List<Categoria> categorias = controladorCategoria.ObtenerCategorias();

            // Verificar si la lista de categorías no es nula y tiene elementos
            if (categorias != null && categorias.Count > 0)
            {
                // Crear una tabla para almacenar los datos
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Campo Clase");
                tabla.Columns.Add("Género");
                tabla.Columns.Add("Tema Libro");
                tabla.Columns.Add("ID");

                // Llenar la tabla con los datos de las categorías
                foreach (Categoria categoria in categorias)
                {
                    tabla.Rows.Add(categoria.Nombre, categoria.Campo_clase, categoria.Genero, categoria.Tema_libro, categoria.Id_categoria);
                }

                // Asignar la tabla como origen de datos del DataGridView
                dtgvwCategoria.DataSource = tabla;
            }
            else
            {
                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de categorías está vacía o nula.");
            }
        }

        private void dtgvwCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgvwCategoria.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                string nombreCategoria = filaSeleccionada.Cells["nombre"].Value.ToString();
                string idCategoria = filaSeleccionada.Cells["ID"].Value.ToString();
                string campoClase = filaSeleccionada.Cells["Campo Clase"].Value.ToString();
                string temaLibro = filaSeleccionada.Cells["Tema Libro"].Value.ToString();
                string genero = filaSeleccionada.Cells["Género"].Value.ToString();

                // Verificar los valores obtenidos
                Console.WriteLine("Nombre de categoría: " + nombreCategoria);
                Console.WriteLine("ID de categoría: " + idCategoria);
                Console.WriteLine("Tema Libro: " + temaLibro);
                Console.WriteLine("Campo Clase: " + campoClase);
                Console.WriteLine("Género: " + genero);

                // Asignar valores a los controles
                txtnombcategoria.Text = nombreCategoria;
                txtIdCategoria.Text = idCategoria;
                txtLibro.Text = temaLibro;

                // Verificar y seleccionar los valores en los ComboBox
                if (cmbClase.Items.Contains(campoClase))
                {
                    cmbClase.SelectedItem = campoClase;
                }
                else
                {
                    Console.WriteLine("El tema del libro no está en la lista del ComboBox de Clase.");
                }

                if (cmbGenero.Items.Contains(genero))
                {
                    cmbGenero.SelectedItem = genero;
                }
                else
                {
                    Console.WriteLine("El género no está en la lista del ComboBox de Género.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool proceso = CamposObligatorios();
                if (!proceso)
                {
                    return;
                }

                // Obtener valores de los controles
                string nombre = txtnombcategoria.Text;
                string campoClase = cmbClase.SelectedItem.ToString();
                string genero = cmbGenero.SelectedItem.ToString();
                string temaLibro = txtLibro.Text;

                // Crear objeto de categoría
                Categoria nuevaCategoria = new Categoria
                {
                    Nombre = nombre,
                    Campo_clase = campoClase,
                    Genero = genero,
                    Tema_libro = temaLibro
                };

                
                // Llamar al método para insertar categoría
                cltCategoria controladorCategoria = new cltCategoria();
                controladorCategoria.InsertarCategoria(nuevaCategoria);

                // Mostrar mensaje de inserción exitosa
                MessageBox.Show("Categoría insertada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar las cajas de texto después de insertar
                txtnombcategoria.Text = "";
                txtLibro.Text = "";
                txtIdCategoria.Text = "";

                // Actualizar el DataGridView
                MostrarCategoriasEnDataGridView();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show("Error al insertar categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdCategoria.Text))
                {
                    MessageBox.Show("Debe seleccionar un dato de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool proceso = CamposObligatorios();
                if (!proceso)
                {
                    return;
                }

                // Obtener valores de los controles
                int id_categoria = int.Parse(txtIdCategoria.Text);
                string nombre = txtnombcategoria.Text;
                string campoClase = cmbClase.SelectedItem.ToString();
                string genero = cmbGenero.SelectedItem.ToString();
                string temaLibro = txtLibro.Text;

                // Crear objeto de categoría
                Categoria categoriaActualizada = new Categoria
                {
                    Id_categoria = id_categoria,
                    Nombre = nombre,
                    Campo_clase = campoClase,
                    Genero = genero,
                    Tema_libro = temaLibro
                };

                // Llamar al método para actualizar categoría
                cltCategoria controladorCategoria = new cltCategoria();
                controladorCategoria.ActualizarCategoria(categoriaActualizada);

                // Mostrar mensaje de actualizar exitosa
                MessageBox.Show("Categoría Actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar las cajas de texto después de insertar
                txtnombcategoria.Text = "";
                txtLibro.Text = "";
                txtIdCategoria.Text = "";

                // Actualizar el DataGridView
                MostrarCategoriasEnDataGridView();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show("Error al Actualizar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdCategoria.Text))
                {
                    MessageBox.Show("Debe seleccionar un dato de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener ID de la categoría seleccionada
                int idCategoria = int.Parse(txtIdCategoria.Text);

                // Llamar al método para eliminar categoría
                cltCategoria controladorCategoria = new cltCategoria();
                controladorCategoria.EliminarCategoria(idCategoria);

                // Mostrar mensaje de actualizar exitosa
                MessageBox.Show("Categoría Eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar las cajas de texto después de insertar
                txtnombcategoria.Text = "";
                txtLibro.Text = "";
                txtIdCategoria.Text = "";

                // Actualizar el DataGridView
                MostrarCategoriasEnDataGridView();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show("Error al Eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        public bool CamposObligatorios()
        {
            // Verificar si el campos txtnombcategoria no están vacíos
            if (string.IsNullOrEmpty(txtnombcategoria.Text) )
            {
                MessageBox.Show("El campo Nombre para la categoria es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si el campos cmbClase no están vacíos
            if (cmbClase.SelectedItem == null )
            {
                MessageBox.Show("El campo clase es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si los campos txtLibro no están vacíos
            if ( cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("El campo genero es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si los campos obligatorios no están vacíos
            if ( string.IsNullOrEmpty(txtLibro.Text) )
            {
                MessageBox.Show("El titulo es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
