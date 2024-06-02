using BibliotecaProyecto.modelo;
using BibliotecaProyecto.vista.categoria;
using BibliotecaProyecto.vista.establecimiento;
using BibliotecaProyecto.vista.libro;
using BibliotecaProyecto.vista.prestamo;
using BibliotecaProyecto.vista.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto.vista
{
    public partial class Menu : Form
    {
        private Form formularioActual; 
        private vwLibrobuscar agregarLibroControl;
        private mttLibros mantenimientolibro;
        private vwCategoria mntCategoriaControl;
        private mostrarPrestamos mostrarprestamo;
        private generarPrestamos generaprestamo;
        private cancelarPrestamo cancelarprestamo;
        private mttUsuarios mantenimientoUsuario;
        private mttEstablecimientos mantenimientoEstablecimiento;

        private Usuario usuario;

        public Menu(Usuario usu)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usu;

            // Inicialmente muestra el UserControl de agregar
            agregarLibroControl = new vwLibrobuscar();
            mantenimientolibro = new mttLibros();

            mntCategoriaControl = new vwCategoria();

            mostrarprestamo = new mostrarPrestamos();
            generaprestamo = new generarPrestamos(this.usuario);
            cancelarprestamo = new cancelarPrestamo();

            mantenimientoUsuario = new mttUsuarios();

            MostrarFormulario(mantenimientolibro);
        }

        private void ProcesoLibros_Load(object sender, EventArgs e)
        {

        }
        // VISTAS PARA LOS LIBROS
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarLibroControl = new vwLibrobuscar();
            MostrarFormulario(agregarLibroControl);

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientolibro = new mttLibros();
            MostrarFormulario(mantenimientolibro);
        }

        // VISTA PARA CATEGORIAS
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mntCategoriaControl = new vwCategoria();
            MostrarFormulario(mntCategoriaControl);
        }
        //VISTA PARA USUARIOS
        private void mantenimientoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoUsuario = new mttUsuarios();
            MostrarFormulario(mantenimientoUsuario);
        }

        private void mantenimientoEstablecimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEstablecimiento = new mttEstablecimientos();
            MostrarFormulario(mantenimientoEstablecimiento);
        }

        // VISTA PARA PRESTAMOS
        private void mostrarPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarprestamo = new mostrarPrestamos();
            MostrarFormulario(mostrarprestamo);
        }
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaprestamo = new generarPrestamos(this.usuario);
            MostrarFormulario(generaprestamo);
        }

        private void cancelarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelarprestamo = new cancelarPrestamo();
            MostrarFormulario(cancelarprestamo);
        }


        private void MostrarFormulario(Form formulario)
        {
            // Cerrar el formulario actual mostrado, si hay alguno
            Console.WriteLine(" validamos el formulario ");
            Console.WriteLine((formularioActual != null ));
            if (formularioActual != null )
            {
                Console.WriteLine(" cerrar el formulario ");
                formularioActual.Close();
            }


            // Mostrar el formulario deseado
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            Controls.Add(formulario);
            formularioActual = formulario;
            formulario.Show();
        }

        
        

    }
}
