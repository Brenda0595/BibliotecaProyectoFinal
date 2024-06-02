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
    public partial class generarPrestamos : Form
    {
        private Usuario usuario;
        // Declara una lista para almacenar los libros agregados
        private List<Libros> librosAgregados = new List<Libros>();
        // Crear una tabla para almacenar los datos
        DataTable tabla = new DataTable();

        private Libros librro;
        private Categoria categ;
        private Establecimiento establecimi;

        public generarPrestamos(Usuario usu)
        {
            InitializeComponent();
            this.usuario = usu;
            llenarDatosUsuario();

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón especifico
            btnbuscar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnagregar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnGenerar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnlimpiar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtnombreLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo 
            //txtnombreLibro.Font = new Font(txtnombreLibro.Font, FontStyle.Bold); // Establecer el estilo de fuente en negrita
            txtdisponibleLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcodigoLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtEstaLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtnombreLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCategoriaLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCategoriaLibro.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtMontoP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCuotaP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtIDusuario.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtNombreP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtApellidoP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtNombreS.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtApellidoS.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtCorreoS.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtTelefonoS.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtDuiS.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            //ShowDatosLibro += ShowDatosLibro_Click;
            this.Load += generarPrestamos_Load;
        }

        private void generarPrestamos_Load(object sender, EventArgs e)
        {
            if (librro != null)
            {
                txtIDlibro.Text = ""+librro.Id_libro;
                txtnombreLibro.Text = librro.Nombre;
                txtcodigoLibro.Text = librro.Codigo;
                txtdisponibleLibro.Text = "" + librro.Disponible;
                txtEstaLibro.Text = librro.Establecimiento.Codigo;
                txtCategoriaLibro.Text = librro.Categoria.Nombre;
                Console.WriteLine("Valor :" + txtnombreLibro.Text);    
            }
            
        }
        public void ShowDatosLibro_Click(string nombreLibro, string codigoLibro, string autor, string disponibilidad, string categoria, string establecimiento, string id)
        {

            Console.WriteLine("METODO >" + nombreLibro);    
            librro = new Libros();
            librro.Id_libro = Convert.ToInt32(id);
            librro.Nombre = nombreLibro;
            librro.Codigo = codigoLibro;
            librro.Disponible = Convert.ToInt32(disponibilidad);
            categ = new Categoria();
            categ.Nombre = categoria;
            establecimi = new Establecimiento();
            establecimi.Codigo = establecimiento;
            librro.Establecimiento = establecimi;
            librro.Categoria = categ;
            librro.Establecimiento.Codigo = establecimiento;
            librro.Categoria.Nombre = categoria;

            this.OnLoad(EventArgs.Empty);
        }

        public void llenarDatosUsuario()
        {
            txtIDusuario.Text = ""+usuario.Id_usuario;
            txtNombreP.Text = usuario.Nombre;
            txtApellidoP.Text = usuario.Apellido;


            txtMontoP.Text = "0";
            txtCuotaP.Text = "0";

            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Codigo");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtnombreLibro.Text) && string.IsNullOrEmpty(txtcodigoLibro.Text))
            {
                MessageBox.Show("Debe agregar un campo de Busqueda codigo o nombre del libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtnombreLibro.Text;
            string codigo = txtcodigoLibro.Text;
            // Obtener la lista de libro a buscar
            cltLibro ctllibro = new cltLibro();
            List<Libros> listaLibro = ctllibro.BuscarLibros(nombre, codigo,"", "",false);

            // Verificar si la lista de categorías no es nula y tiene elementos
            if (listaLibro != null && listaLibro.Count > 0)
            {
                if (listaLibro.Count > 1)
                {
                    // Mostrar mensaje si la lista esta vacia
                    MessageBox.Show("Hay mas de valor guardado con el mismo codigo o nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Llenar la tabla con los datos de las categorías
                foreach (Libros libro in listaLibro)
                {
                    txtIDlibro.Text = ""+libro.Id_libro;
                    txtnombreLibro.Text = libro.Nombre;
                    txtcodigoLibro.Text = libro.Codigo;
                    txtdisponibleLibro.Text = ""+libro.Disponible;
                    txtEstaLibro.Text = libro.Establecimiento.Codigo;
                    txtCategoriaLibro.Text = libro.Categoria.Nombre;
                }
            }
            else
            {
                // Mostrar mensaje si la lista esta vacia
                MessageBox.Show("No se encontro registro para los valores solicitados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //generarPrestamos instanciaGenerarPrestamos = new generarPrestamos(usuario);
                //Dialogobusquedalibro Dialogolibro = new Dialogobusquedalibro(instanciaGenerarPrestamos, usuario);
                //Dialogobusquedalibro Dialogolibro = new Dialogobusquedalibro();
               // Dialogolibro.ShowDialog();

                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de Libro está vacía o nula.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Llamar al método para llenar el DataGridView
            LlenarDataGridView();
            limpiarLibro();
        }

        private void LlenarDataGridView()
        {
            // Verificar si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(txtIDlibro.Text))
            {
                MessageBox.Show("Debe agregar datos de un libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtnombreLibro.Text) && string.IsNullOrEmpty(txtcodigoLibro.Text))
            {
                MessageBox.Show("Debe agregar un campo de Búsqueda código o nombre del libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtnombreLibro.Text;
            string codigo = txtcodigoLibro.Text;
            // Obtener la lista de libros a buscar
            cltLibro ctllibro = new cltLibro();
            List<Libros> listaLibro = ctllibro.BuscarLibros(nombre, codigo, "", "", false);

            // Verificar si la lista de libros no es nula y tiene elementos
            if (listaLibro != null && listaLibro.Count > 0)
            {
                // Validar que se puedan agregar hasta 3 libros
                if (librosAgregados.Count + listaLibro.Count > 3)
                {
                    MessageBox.Show("Solo se pueden agregar hasta 3 libros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si alguno de los libros ya fue agregado previamente
                foreach (Libros libro in listaLibro)
                {
                    if (librosAgregados.Any(l => l.Id_libro == libro.Id_libro))
                    {
                        MessageBox.Show("El libro con codigo " + libro.Codigo + " ya ha sido agregado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Llenar el DataGridView con los datos de los libros encontrados
                foreach (Libros libro in listaLibro)
                {
                    if (libro.Disponible <= 0)
                    {
                        MessageBox.Show("Debe existir dato Disponible para realizar el préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tabla.Rows.Add(
                        libro.Nombre,
                        libro.Codigo);
                }
                dtgvlistalibro.DataSource = tabla;

                // Agregar los libros a la lista de libros agregados
                librosAgregados.AddRange(listaLibro);
            }
            else
            {
                // Mostrar mensaje si la lista está vacía
                MessageBox.Show("No se encontraron registros para los valores solicitados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar si la lista de libros agregados está vacía
            if (librosAgregados.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un libro para generar el préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtIDusuario.Text))
            {
                MessageBox.Show("Datos de usuario no registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreS.Text))
            {
                MessageBox.Show("Nombre del solicitante es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtApellidoS.Text))
            {
                MessageBox.Show("El campo Apellido del solicitante es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTelefonoS.Text))
            {
                MessageBox.Show("El campo Telefono del solicitante es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDuiS.Text))
            {
                MessageBox.Show("El campo Dui del solicitante es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Prestamos prestamo = new Prestamos();
            prestamo.Nombre = txtNombreS.Text;
            prestamo.Apellido = txtApellidoS.Text;
            prestamo.Correo = txtCorreoS.Text;
            prestamo.Fecha_inicio = txtFechaInicio.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
            prestamo.Telefono = txtTelefonoS.Text;
            prestamo.Dui = txtDuiS.Text;
            prestamo.Fecha_fin = txtFechaFin.Value.ToString("yyyy-MM-dd"); // Convertir la fecha al formato adecuado
            prestamo.Monto = txtMontoP.Text;
            prestamo.Cuota = txtCuotaP.Text;
            prestamo.Estado = "Activo";

            // Inicializar el objeto Usuario
            prestamo.Codigo_usuario = new Usuario();
            prestamo.Codigo_usuario.Id_usuario = Convert.ToInt32(txtIDusuario.Text);

            ctlPrestamos ctlprestamo = new ctlPrestamos();

            // Llamar al método CrearPrestamo pasando la lista de libros agregados
            bool proceso = ctlprestamo.CrearPrestamo(prestamo, librosAgregados);

            if (proceso)
            {
                // Mostrar un mensaje de éxito
                MessageBox.Show("Prestamo se registró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                dtgvlistalibro.Rows.Clear();
            }
            else
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al generar prestamo: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarLibro()
        {
            txtnombreLibro.Text = "";
            txtcodigoLibro.Text = "";
            txtdisponibleLibro.Text = "";
            txtCategoriaLibro.Text = "";
            txtEstaLibro.Text = "";
        }

        private void LimpiarFormulario()
        {
            txtnombreLibro.Text = "";
            txtcodigoLibro.Text = "";
            txtdisponibleLibro.Text = "";
            txtCategoriaLibro.Text = "";
            txtEstaLibro.Text = "";
            txtNombreS.Text = "";
            txtApellidoS.Text = "";
            txtCorreoS.Text = "";
            txtTelefonoS.Text = "";
            txtDuiS.Text = "";
            //txtNombreP.Text = "";
            //txtApellidoP.Text = "";
            txtMontoP.Text = "";
            txtCuotaP.Text = "";
            txtFechaInicio.Value = DateTime.Now;
            txtFechaFin.Value = DateTime.Now;
            txtIDlibro.Text = "";

            // Limpiar la lista de libros agregados
            librosAgregados.Clear();

            // Limpiar los datos del DataGridView
            dtgvlistalibro.DataSource = null;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


    }
}
