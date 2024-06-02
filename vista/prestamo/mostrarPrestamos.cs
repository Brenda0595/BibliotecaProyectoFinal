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
    public partial class mostrarPrestamos : Form
    {

        public mostrarPrestamos()
        {
            InitializeComponent();
            LlenarComboBox();
            MostrarPrestamosEnDataGridView("", "", "", "", "", "");
            // Suscribir el evento CellClick del DataGridView dtgwPrestamo
            dtgwPrestamo.CellClick += dtgwPrestamo_CellClick;
            // Suscribir el evento CellClick del DataGridView dtgwPrestamo
            dtgvwlineaPrestamo.CellClick += dtgvwlineaPrestamo_CellClick;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón especifico
            btnbuscar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnlimpiar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnlimpiarLinea.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtNombre.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtApellido.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtDui.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCorreo.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtNombreL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtfechaInicoL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtfechaFinL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcorreoL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcodigoL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtEstadoL.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcodigo.BackColor = ColorTranslator.FromHtml("#EAEAEA");
        }
        //este metodo recibe varios parametros de busqueda
        private void MostrarPrestamosEnDataGridView(string nombre, string apellido, string correo,string dui, string usuario, string estado)
        {
            try
            {
                //llamamos al controlador para buscar prestamo
                ctlPrestamos cltrprestamo = new ctlPrestamos();
                // Llamar al método BuscarPrestamos para obtener los préstamos
                List<Prestamos> prestamos = cltrprestamo.BuscarPrestamos(nombre, apellido, correo,dui,usuario,estado);

                // Verificar si se encontraron prestamos
                if (prestamos != null && prestamos.Count > 0)
                {
                    // Crear una tabla para almacenar los datos
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("CODIGO");
                    tabla.Columns.Add("Nombre");
                    tabla.Columns.Add("Apellido");
                    tabla.Columns.Add("Correo");
                    tabla.Columns.Add("Fecha Inicio");
                    tabla.Columns.Add("Teléfono");
                    tabla.Columns.Add("DUI");
                    tabla.Columns.Add("Fecha Fin");
                    tabla.Columns.Add("Monto");
                    tabla.Columns.Add("Cuota");
                    tabla.Columns.Add("Estado");
                    tabla.Columns.Add("Nombre Usuario");
                    tabla.Columns.Add("Apellido Usuario");
                    tabla.Columns.Add("Dirección Usuario");
                    tabla.Columns.Add("Teléfono Usuario");
                    tabla.Columns.Add("DUI Usuario");
                    tabla.Columns.Add("Estado Usuario");
                    

                    // Llenar la tabla con los datos de los prestamos
                    foreach (Prestamos prestamo in prestamos)
                    {
                        tabla.Rows.Add(
                            prestamo.Codigo,
                            prestamo.Nombre,
                            prestamo.Apellido,
                            prestamo.Correo,
                            prestamo.Fecha_inicio,
                            prestamo.Telefono,
                            prestamo.Dui,
                            prestamo.Fecha_fin,
                            prestamo.Monto,
                            prestamo.Cuota,
                            prestamo.Estado,
                            prestamo.Codigo_usuario.Nombre,
                            prestamo.Codigo_usuario.Apellido,
                            prestamo.Codigo_usuario.Direccion,
                            prestamo.Codigo_usuario.Telefono,
                            prestamo.Codigo_usuario.Dui,
                            prestamo.Codigo_usuario.Estado
                        );
                    }

                    // Asignar la tabla como origen de datos del DataGridView
                    dtgwPrestamo.DataSource = tabla;
                }
                else
                {
                    // Si no se encontraron préstamos, limpiar el DataGridView
                    dtgwPrestamo.DataSource = null;
                    // Si la lista está vacía o nula, puedes mostrar un mensaje o realizar otra acción según sea necesario
                    MessageBox.Show("No se encontraron Prestamos con los datos Filtrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("No se encontraron Prestamos.");
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al mostrar préstamos en DataGridView: " + ex.Message);
            }
        }

        private void LlenarComboBox()
        {
            cltUsuarios controladorUsuarios = new cltUsuarios();

            // Llenar el ComboBox de Clase
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Parcialmente Aplicado");
            //cmbEstado.Items.Add("Cancelado");
            cmbEstado.Items.Add("Cancelado");
            //cmbEstado.Items.Add("Exclusivo");
            // Limpiar ComboBox antes de llenarlo
            cmbUsuario.Items.Clear();

            // Obtener la lista de categorías
            List<Usuario> usuarios = controladorUsuarios.ObtenerUsuarios();

            // Verificar si la lista de categorías no es nula y tiene elementos
            if (usuarios != null && usuarios.Count > 0)
            {
                // Agregar las categorías al ComboBox
                foreach (Usuario usuario in usuarios)
                {
                    cmbUsuario.Items.Add(usuario);
                }
            }
            else
            {
                // Si la lista está vacía o nula, puedes mostrar un mensaje o realizar otra acción según sea necesario
                //MessageBox.Show("No se encontraron Prestamos con los datos Filtrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("No se encontraron Usuarios para llenar combox Mostrar Prestamos.");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Dui = txtDui.Text;
                string correo = txtCorreo.Text;
                string Estado = "";
                if (cmbEstado.SelectedItem != null)
                {
                    Estado = cmbEstado.SelectedItem.ToString();
                }

                string Usuario = "";
                if (cmbUsuario.SelectedItem != null)
                {
                    // Obtener el objeto Usuario seleccionado del ComboBox
                    Usuario usuarioSeleccionado = (Usuario)cmbUsuario.SelectedItem;
                    // Retornar el ID del usuario seleccionado
                    Usuario = ""+usuarioSeleccionado.Id_usuario;
                }
                else
                {
                    Usuario = "";
                }
                Console.WriteLine("Estado. " + Estado);
                Console.WriteLine("Usuario. " + Usuario);

                MostrarPrestamosEnDataGridView(Nombre, Apellido, correo, Dui, Usuario, Estado);

            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al buscar el Prestamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar las líneas de préstamo en el DataGridView dtgwLineaPrestamo al hacer clic en una celda del DataGridView dtgwPrestamo
        private void dtgwPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener el índice de la fila seleccionada
                int indiceFilaSeleccionada = e.RowIndex;

                // Verificar si la selección es válida
                if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dtgwPrestamo.Rows.Count)
                {
                    // Obtener los valores de la fila seleccionada
                    DataGridViewRow filaSeleccionada = dtgwPrestamo.Rows[indiceFilaSeleccionada];

                    // Asignar los valores a los cuadros de texto y ComboBox
                    txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                    txtDui.Text = filaSeleccionada.Cells["DUI"].Value.ToString();
                    txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                    cmbUsuario.Text = filaSeleccionada.Cells["Nombre Usuario"].Value.ToString() + " " + filaSeleccionada.Cells["Apellido Usuario"].Value.ToString();
                    cmbEstado.Text = filaSeleccionada.Cells["Estado"].Value.ToString();
                    txtcodigo.Text = filaSeleccionada.Cells["CODIGO"].Value.ToString();

                    // Obtener el código de préstamo seleccionado en la fila actual
                    string codigoPrestamo = dtgwPrestamo.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

                    // Llamar al método ObtenerLineasPrestamoPorCodigo para obtener las líneas de préstamo asociadas a ese préstamo
                    ctlPrestamos ctlPrestamo = new ctlPrestamos();
                    List<LineaPrestamos> lineasPrestamo = ctlPrestamo.ObtenerLineasPrestamoPorCodigo(codigoPrestamo);

                    // Crear una tabla para almacenar los datos de las líneas de préstamo
                    DataTable tablaLineasPrestamo = new DataTable();
                    tablaLineasPrestamo.Columns.Add("ID");
                    tablaLineasPrestamo.Columns.Add("Código de Libro");
                    tablaLineasPrestamo.Columns.Add("Nombre de Libro");
                    tablaLineasPrestamo.Columns.Add("Nombre");
                    tablaLineasPrestamo.Columns.Add("Apellido");
                    tablaLineasPrestamo.Columns.Add("Correo");
                    tablaLineasPrestamo.Columns.Add("Fecha de Inicio");
                    tablaLineasPrestamo.Columns.Add("Teléfono");
                    tablaLineasPrestamo.Columns.Add("DUI");
                    tablaLineasPrestamo.Columns.Add("Fecha de Fin");
                    tablaLineasPrestamo.Columns.Add("Monto");
                    tablaLineasPrestamo.Columns.Add("Cuota");
                    tablaLineasPrestamo.Columns.Add("Estado");
                    tablaLineasPrestamo.Columns.Add("Código");

                    // Llenar la tabla con los datos de las líneas de préstamo
                    foreach (LineaPrestamos linea in lineasPrestamo)
                    {
                        tablaLineasPrestamo.Rows.Add(
                            linea.Id_codigolineaprestamo,
                            linea.Codigo_libro,
                            linea.Nombre_libro,
                            linea.Nombre,
                            linea.Apellido,
                            linea.Correo,
                            linea.Fecha_inicio.ToString("yyyy-MM-dd"), // Asegurarse de formatear la fecha según sea necesario
                            linea.Telefono,
                            linea.Dui,
                            linea.Fecha_fin.ToString("yyyy-MM-dd"), // Asegurarse de formatear la fecha según sea necesario
                            linea.Monto,
                            linea.Cuota,
                            linea.Estado,
                            linea.Codigo
                        );
                    }

                    // Asignar la tabla como origen de datos del DataGridView dtgwLineaPrestamo
                    dtgvwlineaPrestamo.DataSource = tablaLineasPrestamo;
                }
                

            }
            catch (Exception ex)
            {
                // Manejar la excepción de acuerdo a tus necesidades
                Console.WriteLine("Error al cargar las líneas de préstamo en el DataGridView: " + ex.Message);
            }
        }

        private void dtgvwlineaPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int indiceFilaSeleccionada = e.RowIndex;

            // Verificar si la selección es válida
            if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dtgvwlineaPrestamo.Rows.Count)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgvwlineaPrestamo.Rows[indiceFilaSeleccionada];

                // Asignar los valores a los cuadros de texto
                txtNombreL.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtfechaInicoL.Text = filaSeleccionada.Cells["Fecha de Inicio"].Value.ToString();
                txtfechaFinL.Text = filaSeleccionada.Cells["Fecha de Fin"].Value.ToString();
                txtcorreoL.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txtcodigoL.Text = filaSeleccionada.Cells["Código de Libro"].Value.ToString();
                txtEstadoL.Text = filaSeleccionada.Cells["Estado"].Value.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDui.Text = "";
            txtCorreo.Text = "";
            txtNombreL.Text = "";
            txtfechaInicoL.Text = "";
            txtfechaFinL.Text = "";
            txtcorreoL.Text = "";
            txtcodigoL.Text = "";
            txtEstadoL.Text = "";
            txtcodigo.Text = "";

            // Limpiar los ComboBox
            cmbUsuario.SelectedItem = null; // Limpia la selección actual
            cmbUsuario.SelectedIndex = -1; // Limpiar la selección
            cmbEstado.SelectedIndex = -1; // Limpiar la selección

            // Limpiar el DataGridView dtgvwlineaPrestamo
            dtgvwlineaPrestamo.DataSource = null;
        }
        //llamo al metodo LimpiarCampos para limpiar
        //los campos de texto
        private void btnlimpiarLinea_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        //Limpia los campos de texto relacionados con las líneas de prestamo
        private void LimpiarCampos()
        {
            txtNombreL.Text = "";
            txtfechaInicoL.Text = "";
            txtfechaFinL.Text = "";
            txtcorreoL.Text = "";
            txtcodigoL.Text = "";
            txtEstadoL.Text = "";
        }
    }
}
