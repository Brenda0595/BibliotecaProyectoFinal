using BibliotecaProyecto.controlador;
using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto.vista.libro
{
    public partial class mttLibros : Form
    {
        public mttLibros()
        {
            InitializeComponent();
            MostrarLibro();
            LlenarComboBoxCategorias();
            LlenarComboBoxEstablecimiento();
            dtgvwCargarLibros.CellClick += dtgvwCargarLibros_CellContentClick;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnAgregar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnActualizar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnEliminar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtIdLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtnombre.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
            txtAutor.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtPais.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtDisponible.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtExistencia.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCodigo.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            cmbEstado.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            cmbEstablecimiento.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            cmbCategoria.BackColor = ColorTranslator.FromHtml("#EAEAEA");
        }

        private void MostrarLibro()
        {
            // Limpiar los datos existentes en el DataGridView
            dtgvwCargarLibros.DataSource = null;
            dtgvwCargarLibros.Rows.Clear();

            // Obtener la lista de libro a buscar
            cltLibro ctllibro = new cltLibro();
            List<Libros> listaLibro = ctllibro.ObtenerlistaLibros();

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
                tabla.Columns.Add("Estado");
                tabla.Columns.Add("Establecimiento");
                tabla.Columns.Add("Categoria");
                tabla.Columns.Add("ID");

                // Llenar la tabla con los datos de las categorías
                foreach (Libros libro in listaLibro)
                {
                    tabla.Rows.Add(libro.Nombre, libro.Autor, libro.Fecha,
                        libro.Pais, libro.Fecha_ingreso, libro.Codigo, libro.Disponible,
                        libro.Existencia, libro.Estado
                        , libro.Establecimiento.Codigo, libro.Categoria.Nombre, libro.Id_libro
                        );
                }

                // Asignar la tabla como origen de datos del DataGridView
                dtgvwCargarLibros.DataSource = tabla;
            }
            else
            {
                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de Libro está vacía o nula.");
            }
        }

        private void dtgvwCargarLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Datos. " + e.RowIndex);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgvwCargarLibros.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                string nombreLibro = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string idLibro = filaSeleccionada.Cells["ID"].Value.ToString();
                string Autor = filaSeleccionada.Cells["Autor"].Value.ToString();
                string codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();

                // Formatear la fecha de acuerdo al formato esperado
                string fecha = filaSeleccionada.Cells["Fecha"].Value.ToString(); // Supongamos que la fecha ya está en el formato esperado

                string pais = filaSeleccionada.Cells["Pais"].Value.ToString();

                // Formatear la fecha de ingreso
                string fechaInge = filaSeleccionada.Cells["Fecha de ingreso"].Value.ToString(); // Supongamos que la fecha de ingreso ya está en el formato esperado

                string disponible = filaSeleccionada.Cells["Disponible"].Value.ToString();
                string existencia = filaSeleccionada.Cells["Existencia"].Value.ToString();
                string estado = filaSeleccionada.Cells["Estado"].Value.ToString();
                string establecimiento = filaSeleccionada.Cells["Establecimiento"].Value.ToString();
                string categoria = filaSeleccionada.Cells["Categoria"].Value.ToString();

                // Asignar valores a los controles
                txtnombre.Text = nombreLibro;
                txtIdLibro.Text = idLibro;
                txtAutor.Text = Autor;
                txtCodigo.Text = codigo;

                // Convertir las fechas directamente a DateTime
                DateTime fechaDateTime;
                DateTime fechaIngeDateTime;

                if (DateTime.TryParse(fecha, out fechaDateTime))
                {
                    datefecha.Value = fechaDateTime;
                }
                else
                {
                    // Manejar el caso en que la conversión falle
                    MessageBox.Show("La fecha no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (DateTime.TryParse(fechaInge, out fechaIngeDateTime))
                {
                    dateFechaIngreso.Value = fechaIngeDateTime;
                }
                else
                {
                    // Manejar el caso en que la conversión falle
                    MessageBox.Show("La fecha de ingreso no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtPais.Text = pais;

                // Asignar los valores de existencia y disponible a los controles correspondientes
                txtDisponible.Text = disponible;
                txtExistencia.Text = existencia;

                // Seleccionar el establecimiento en el ComboBox cmbEstablecimiento
                foreach (Establecimiento est in cmbEstablecimiento.Items)
                {
                    if (est.Codigo == establecimiento)
                    {
                        cmbEstablecimiento.SelectedItem = est;
                        break;
                    }
                }

                // Seleccionar la categoría en el ComboBox cmbCategoria
                foreach (Categoria cat in cmbCategoria.Items)
                {
                    if (cat.Nombre == categoria)
                    {
                        cmbCategoria.SelectedItem = cat;
                        break;
                    }
                }

                if (cmbEstado.Items.Contains(estado))
                {
                    cmbEstado.SelectedItem = estado;
                }
                else
                {
                    Console.WriteLine("El estado no está en la lista del ComboBox de Género.");
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
               cltLibro controladorLibro = new cltLibro();
               cltCategoria clienteCategoria = new cltCategoria();
            try
            {
                bool proceso = CamposObligatorios();
                if (!proceso)
                {
                    return;
                }

                // Crear un nuevo objeto Libros con los datos de los controles del formulario
                Libros nuevoLibro = new Libros();
                nuevoLibro.Nombre = txtnombre.Text;
                nuevoLibro.Autor = txtAutor.Text;
                nuevoLibro.Fecha = datefecha.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
                nuevoLibro.Pais = txtPais.Text;
                nuevoLibro.Fecha_ingreso = dateFechaIngreso.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
                nuevoLibro.Codigo = txtCodigo.Text;
                nuevoLibro.Disponible = Convert.ToInt32(txtDisponible.Value); // Convertir el valor del NumericUpDown a string
                nuevoLibro.Existencia = txtExistencia.Value.ToString(); // Convertir el valor del NumericUpDown a string
                nuevoLibro.Estado = cmbEstado.SelectedItem.ToString();

                if (Convert.ToInt32(nuevoLibro.Disponible) > Convert.ToInt32(nuevoLibro.Existencia))
                {
                    MessageBox.Show("La candidad Disponible no puede ser Mayor que la Existencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el establecimiento seleccionado
                Establecimiento establecimientoSeleccionado = (Establecimiento)cmbEstablecimiento.SelectedItem;
                // Obtener el ID del establecimiento seleccionado
                int idEstablecimiento = establecimientoSeleccionado.Id_establecimiento;

                // Obtener el establecimiento seleccionado
                Categoria categoriaSeleccionado = (Categoria)cmbCategoria.SelectedItem;
                // Obtener el ID del establecimiento seleccionado
                int idCategoria = establecimientoSeleccionado.Id_establecimiento;

                // Asignar los valores de los ComboBox (Establecimiento y Categoria) al nuevo libro
                // Aquí debes obtener los valores seleccionados de los ComboBox, supongamos que tienen las propiedades SelectedValue que contienen los IDs correspondientes
                nuevoLibro.Establecimiento = establecimientoSeleccionado;
                nuevoLibro.Categoria = categoriaSeleccionado;
                Console.WriteLine("Establecimiento." + nuevoLibro.Establecimiento);
                Console.WriteLine("2.Establecimiento."+nuevoLibro.Establecimiento.Id_establecimiento);

                Console.WriteLine("Categoria." + nuevoLibro.Categoria);
                Console.WriteLine("2.Categoria." + nuevoLibro.Categoria.Id_categoria);


                // Llamar al método AgregarLibro del controlador
                controladorLibro.AgregarLibro(nuevoLibro);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El libro se agrego correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MostrarLibro();
                // Limpiar los controles después de agregar un libro
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al agregar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un dato de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cltLibro controladorLibro = new cltLibro();
                cltCategoria clienteCategoria = new cltCategoria();

                bool proceso = CamposObligatorios();
                if (!proceso)
                {
                    return;
                }
                // Crear un nuevo objeto Libros con los datos de los controles del formulario
                Libros libroActualizar = new Libros();
                libroActualizar.Id_libro = Convert.ToInt32(txtIdLibro.Text); // Obtener el ID del libro seleccionado

                // Asignar los nuevos valores a los otros campos del libro desde los controles del formulario
                libroActualizar.Nombre = txtnombre.Text;
                libroActualizar.Autor = txtAutor.Text;
                libroActualizar.Fecha = datefecha.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
                libroActualizar.Pais = txtPais.Text;
                libroActualizar.Fecha_ingreso = dateFechaIngreso.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
                libroActualizar.Codigo = txtCodigo.Text;
                libroActualizar.Disponible = Convert.ToInt32(txtDisponible.Value.ToString()); // Convertir el valor del NumericUpDown a string
                libroActualizar.Existencia = txtExistencia.Value.ToString(); // Convertir el valor del NumericUpDown a string
                libroActualizar.Estado = cmbEstado.SelectedItem.ToString();

                // Obtener el establecimiento seleccionado
                Establecimiento establecimientoSeleccionado = (Establecimiento)cmbEstablecimiento.SelectedItem;
                // Obtener el ID del establecimiento seleccionado
                //int idEstablecimiento = establecimientoSeleccionado.Id_establecimiento;

                // Obtener la categoria seleccionada
                Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;
                // Obtener el ID de la categoria seleccionada
                //int idCategoria = categoriaSeleccionada.Id_categoria;

                // Asignar los valores de los ComboBox (Establecimiento y Categoria) al libro a actualizar
                libroActualizar.Establecimiento = establecimientoSeleccionado;
                libroActualizar.Categoria = categoriaSeleccionada;

                if (Convert.ToInt32(libroActualizar.Disponible) > Convert.ToInt32(libroActualizar.Existencia))
                {
                    MessageBox.Show("La candidad Disponible no puede ser Mayor que la Existencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Llamar al método ActualizarLibro del controlador
                controladorLibro.ActualizarLibro(libroActualizar);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El libro se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MostrarLibro();
                // Limpiar los controles después de actualizar un libro
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al actualizar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIdLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un dato de la tabla para Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                 // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el libro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    cltLibro controladorLibro = new cltLibro();
                    cltCategoria clienteCategoria = new cltCategoria();

                    int idLibro = Convert.ToInt32(txtIdLibro.Text); // Obtener el ID del libro seleccionado

                    // Llamar al método EliminarLibro del controlador
                    controladorLibro.EliminarLibro(idLibro);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("El libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarLibro();
                    // Limpiar los controles después de actualizar un libro
                    LimpiarControles();
                }
               
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboBoxCategorias()
        {
            cltLibro controladorLibro = new cltLibro();
            cltCategoria clienteCategoria = new cltCategoria();

            // Llenar el ComboBox de Clase
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("No Disponible");
            cmbEstado.Items.Add("Pronto Disponible");
            cmbEstado.Items.Add("Retirado");
            cmbEstado.Items.Add("Exclusivo");
            // Limpiar ComboBox antes de llenarlo
            cmbCategoria.Items.Clear();

            // Obtener la lista de categorías
            List<Categoria> categorias = clienteCategoria.ObtenerCategorias();

            // Verificar si la lista de categorías no es nula y tiene elementos
            if (categorias != null && categorias.Count > 0)
            {
                // Agregar las categorías al ComboBox
                foreach (Categoria categoria in categorias)
                {
                    cmbCategoria.Items.Add(categoria);
                }
            }
            else
            {
                // Si la lista está vacía o nula, puedes mostrar un mensaje o realizar otra acción según sea necesario
                //MessageBox.Show("No se encontraron categorías.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("No se encontraron categorías.");
            }
        }

        private void LlenarComboBoxEstablecimiento()
        {
            // Limpiar el ComboBox antes de llenarlo
            cmbEstablecimiento.Items.Clear();

            // Obtener la lista de establecimientos
            ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();
            List<Establecimiento> establecimientos = controladorEstablecimiento.ObtenerEstablecimientos();

            // Verificar si se obtuvieron establecimientos
            if (establecimientos != null && establecimientos.Count > 0)
            {
                // Agregar cada establecimiento al ComboBox
                foreach (Establecimiento establecimiento in establecimientos)
                {
                    cmbEstablecimiento.Items.Add(establecimiento);
                }
            }
            else
            {
                // Si no se encontraron establecimientos, mostrar un mensaje o realizar otra acción
                MessageBox.Show("No se encontraron establecimientos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para limpiar los controles del formulario
        private void LimpiarControles()
        {
            txtIdLibro.Text = "";
            txtnombre.Text = "";
            txtAutor.Text = "";
            datefecha.Value = DateTime.Now;
            txtPais.Text = "";
            dateFechaIngreso.Value = DateTime.Now;
            txtCodigo.Text = "";
            txtDisponible.Value = 0;
            txtExistencia.Value = 0;
            cmbEstado.SelectedIndex = -1;
            cmbEstablecimiento.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
        }

        public bool CamposObligatorios()
        {
            // Verificar si el campos txtnombcategoria no están vacíos
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("El campo Nombre para la categoria es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si el campos cmbClase no están vacíos
            if (txtAutor.Text == null)
            {
                MessageBox.Show("El campo Autor es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show("El Pais es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El Codigo es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtDisponible.Text))
            {
                MessageBox.Show("La cantidad Disponible es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtExistencia.Text))
            {
                MessageBox.Show("La cantidad de Existencia es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si los campos txtLibro no están vacíos
            if (cmbEstablecimiento.SelectedItem == null)
            {
                MessageBox.Show("El campo genero es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Verificar si los campos txtLibro no están vacíos
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("El campo genero es obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
