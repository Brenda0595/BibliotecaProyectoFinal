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
    public partial class cancelarPrestamo : Form
    {
        List<LineaPrestamos> listaPrestamo = new List<LineaPrestamos>();
        DataTable tablacancelar = new DataTable();
        public cancelarPrestamo()
        {
            InitializeComponent();
            dtgvPrestamo.CellClick += dtgvPrestamo_CellClick;
            CrearTabla();

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnBuscar.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Cambia el color de fondo del boton btnBuscar 
            btnlimpiar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnquitar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnCancelar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtnombreP.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtapellidoP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcorreoP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtfechaInicioP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txttelP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtduiP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtfechaFinP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtmontoP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtcuotaP.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            txtestado.BackColor = ColorTranslator.FromHtml("#EAEAEA");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscarP.Text))
            {
                MessageBox.Show("Debe ingresa un codigo para buscar el prestamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigo = txtbuscarP.Text;

            ctlPrestamos ctlprestamo = new ctlPrestamos();

            // Buscar el préstamo por código
            Prestamos prestamo = ctlprestamo.BuscarPrestamoPorCodigo(codigo);

            if (prestamo != null)
            {
                // Mostrar la información del préstamo en los campos correspondientes
                txtnombreP.Text = prestamo.Nombre;
                txtapellidoP.Text = prestamo.Apellido;
                txtcorreoP.Text = prestamo.Correo;
                txtfechaInicioP.Text = prestamo.Fecha_inicio;
                txttelP.Text = prestamo.Telefono;
                txtduiP.Text = prestamo.Dui;
                txtfechaFinP.Text = prestamo.Fecha_fin;
                txtmontoP.Text = prestamo.Monto;
                txtcuotaP.Text = prestamo.Cuota;
                txtestado.Text = prestamo.Estado;

                // Obtener las líneas de préstamo asociadas al préstamo encontrado
                ctlprestamo = new ctlPrestamos(); //Limpiamos nuevamente el controlador
                Console.WriteLine("Buscar Codigo. " + prestamo.Codigo);
                List<LineaPrestamos> lineasPrestamo = ctlprestamo.ObtenerLineasPrestamoPorCodigo(prestamo.Codigo);

                // Crear una tabla para almacenar los datos de las líneas de préstamo
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Codigo Linea Prestamo");
                tabla.Columns.Add("Nombre Libro");
                tabla.Columns.Add("Codigo Libro");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Apellido");
                tabla.Columns.Add("Correo");
                tabla.Columns.Add("Fecha Inicio");
                tabla.Columns.Add("Telefono");
                tabla.Columns.Add("DUI");
                tabla.Columns.Add("Fecha Fin");
                tabla.Columns.Add("Monto");
                tabla.Columns.Add("Cuota");
                tabla.Columns.Add("Estado");
                tabla.Columns.Add("Id Codigo");
                

                // Llenar la tabla con los datos de las líneas de préstamo
                Console.WriteLine("llena. " + lineasPrestamo.Count);
                foreach (LineaPrestamos linea in lineasPrestamo)
                {
                    Console.WriteLine("llena. " + linea.Nombre_libro);
                    tabla.Rows.Add(linea.Codigo,linea.Nombre_libro, linea.Codigo_libro, linea.Nombre, 
                        linea.Apellido, linea.Correo, linea.Fecha_inicio, linea.Telefono, linea.Dui, 
                        linea.Fecha_fin, linea.Monto, linea.Cuota, linea.Estado,linea.Id_codigolineaprestamo);
                }

                // Asignar la tabla como origen de datos del DataGridView dtgvPrestamo
                dtgvPrestamo.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("No se encontró ningún préstamo con el código proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida
            if (e.RowIndex >= 0)
            {
                Console.WriteLine("MI LISTA ." + listaPrestamo.Count);
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgvPrestamo.Rows[e.RowIndex];

                // Obtener los datos de la fila seleccionada
                string ID = filaSeleccionada.Cells["Id Codigo"].Value.ToString();
                string codigoLineaPrestamo = filaSeleccionada.Cells["Codigo Linea Prestamo"].Value.ToString();
                string nombreLibro = filaSeleccionada.Cells["Nombre Libro"].Value.ToString();
                string codigoLibro = filaSeleccionada.Cells["Codigo Libro"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string correo = filaSeleccionada.Cells["Correo"].Value.ToString();
                string fechaInicio = filaSeleccionada.Cells["Fecha Inicio"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string dui = filaSeleccionada.Cells["DUI"].Value.ToString();
                string fechaFin = filaSeleccionada.Cells["Fecha Fin"].Value.ToString();
                string monto = filaSeleccionada.Cells["Monto"].Value.ToString();
                string cuota = filaSeleccionada.Cells["Cuota"].Value.ToString();
                string estado = filaSeleccionada.Cells["Estado"].Value.ToString();

                // Verificar si el código de la línea de préstamo no está en el dtgvcancelar
                bool lineaRepetida = false;
                foreach (DataGridViewRow filaCancelar in dtgvcancelar.Rows)
                {
                    
                    string IDLinea = ""+filaCancelar.Cells["Id Codigo"].Value;
                    if (IDLinea == ID)
                    {
                        lineaRepetida = true;
                        break;
                    }
                }

                // Si la línea de préstamo no está repetida, agregarla al dtgvcancelar y a la listaPrestamo
                if (!lineaRepetida)
                {
                    // Agregar los datos al dtgvcancelar
                    tablacancelar.Rows.Add(ID, codigoLineaPrestamo,nombreLibro, codigoLibro, nombre, apellido, correo, fechaInicio, telefono, dui, fechaFin, monto, cuota, estado);

                    // Asignar la tabla como origen de datos del DataGridView dtgvcancelar
                    dtgvcancelar.DataSource = tablacancelar;
                    // Agregar los datos a la listaPrestamo (debes tener una lista definida a nivel de formulario para esto)
                    listaPrestamo.Add(new LineaPrestamos
                    {
                        Id_codigolineaprestamo = Convert.ToInt32(ID),
                        //Codigolinea_prestamos = ID,
                        Nombre_libro = nombreLibro,
                        Codigo_libro = codigoLibro,
                        Nombre = nombre,
                        Apellido = apellido,
                        Correo = correo,
                        Fecha_inicio = DateTime.Parse(fechaInicio),
                        Telefono = telefono,
                        Dui = dui,
                        Fecha_fin = DateTime.Parse(fechaFin),
                        Monto = decimal.Parse(monto),
                        Cuota = decimal.Parse(cuota),
                        Estado = estado,
                        Codigo =codigoLineaPrestamo
                    });
                }
                else
                {
                    MessageBox.Show("La línea de préstamo seleccionada ya está en la lista de cancelación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscarP.Text))
            {
                MessageBox.Show("Debe ingresa un codigo para buscar el prestamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaPrestamo == null || listaPrestamo.Count == 0)
            {
                MessageBox.Show("Debe agregar un registro linea de Prestamo, por favor dar click en una Linea de Registro de prestamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtestado.Text))
            {
                MessageBox.Show("Préstamo ya se encuentra Cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Obtener el código del préstamo
            string codigoPrestamo = txtbuscarP.Text;

            // Actualizar el estado de las líneas de préstamo en la lista listaPrestamo a "Cancelado"
            int reporte = 0;
            foreach (LineaPrestamos linea in listaPrestamo)
            {
                ctlPrestamos ctlPrestamo = new ctlPrestamos();
                if (linea.Estado.Equals("Cancelado"))
                {
                    //
                }
                else
                {
                    ctlPrestamo.ActualizarEstadoLineaPrestamo(linea.Id_codigolineaprestamo, linea.Codigo, "Cancelado");
                    codigoPrestamo = linea.Codigo;
                    reporte = 1;
                }
                
            }
            if (reporte==0)
            {
                MessageBox.Show("Préstamo ya se encuentra Cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Console.WriteLine("codigoPrestamo." + codigoPrestamo);
            // Actualizar el estado de los libros asociados a las líneas de préstamo canceladas a "Disponible"
            foreach (LineaPrestamos linea in listaPrestamo)
            {
                string codigoLibro = linea.Codigo_libro;
                cltLibro ctlLibro = new cltLibro();
                ctlLibro.ActualizarEstadoLibro(codigoLibro, "Disponible");
            }

            // Obtener todas las líneas de préstamo asociadas al préstamo correspondiente desde la base de datos
            ctlPrestamos ctlPrestamo2 = new ctlPrestamos();
            List<LineaPrestamos> lineasPrestamoValidar = ctlPrestamo2.ObtenerLineasPrestamoPorCodigo(codigoPrestamo);

            int lineasCanceladas = 0;

            Console.WriteLine("Contar las Lineas." + lineasPrestamoValidar.Count);
            // Verificar el estado de cada línea de préstamo
            foreach (LineaPrestamos linea in lineasPrestamoValidar)
            {
                if (linea.Estado == "Cancelado")
                {
                    lineasCanceladas++;
                }
            }

            // Actualizar el estado del préstamo según la cantidad de líneas activas y canceladas
            if (lineasCanceladas > 0 && lineasCanceladas < lineasPrestamoValidar.Count)
            {
                Console.WriteLine("Cambiar estado Prestamo a Parcialmente Aplicado.");
                // Todas las líneas de préstamo están canceladas, pero hay líneas parcialmente aplicadas
                ctlPrestamos ctlPrestamo4 = new ctlPrestamos();
                ctlPrestamo4.ActualizarEstadoPrestamo(codigoPrestamo, "Parcialmente Aplicado");
            }
            else if (lineasCanceladas == lineasPrestamoValidar.Count)
            {
                Console.WriteLine("Cambiar estado Prestamo a cancelar.");
                // Todas las líneas de préstamo están canceladas
                ctlPrestamos ctlPrestamo3 = new ctlPrestamos();
                ctlPrestamo3.ActualizarEstadoPrestamo(codigoPrestamo, "Cancelado");
            }
            else
            {
                Console.WriteLine("Cambiar estado Prestamo a Activo.");
                // Al menos una línea de préstamo está activa
                ctlPrestamos ctlPrestamo5 = new ctlPrestamos();
                ctlPrestamo5.ActualizarEstadoPrestamo(codigoPrestamo, "Activo");
            }

            // Limpiar el formulario después de la cancelación
            LimpiarFormulario();

            // Mostrar mensaje de éxito
            MessageBox.Show("Préstamo cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            limpiarListaCancelar();
        }

        private void LimpiarFormulario()
        {
            // Limpiar los campos de búsqueda
            txtbuscarP.Text = "";

            // Limpiar los campos de información del préstamo
            txtnombreP.Text = "";
            txtapellidoP.Text = "";
            txtcorreoP.Text = "";
            txttelP.Text = "";
            txtfechaInicioP.Text = "";
            txtfechaFinP.Text = "";
            txtduiP.Text = "";
            txtmontoP.Text = "";
            txtcuotaP.Text = "";

            // Limpiar los DataGridView
            dtgvPrestamo.DataSource = null;
            dtgvcancelar.DataSource = null;

            limpiarListaCancelar();
        }

        public void limpiarListaCancelar()
        {
            // Limpiar la lista listaPrestamo
            listaPrestamo.Clear();

            // Limpiar el origen de datos del DataGridView dtgvcancelar
            dtgvcancelar.DataSource = null;
            dtgvcancelar.Rows.Clear(); // Limpiar las filas

            // Crear una nueva tabla vacía para el DataGridView dtgvcancelar
            tablacancelar = new DataTable();
            CrearTabla(); // Vuelve a crear las columnas en la tabla

            // Asignar la tabla como origen de datos del DataGridView dtgvcancelar
            dtgvcancelar.DataSource = tablacancelar;
        }

        public void CrearTabla()
        {
            tablacancelar.Columns.Add("Id Codigo");
            tablacancelar.Columns.Add("Codigo Linea Prestamo");
            tablacancelar.Columns.Add("Nombre Libro");
            tablacancelar.Columns.Add("Codigo Libro");
            tablacancelar.Columns.Add("Nombre");
            tablacancelar.Columns.Add("Apellido");
            tablacancelar.Columns.Add("Correo");
            tablacancelar.Columns.Add("Fecha Inicio");
            tablacancelar.Columns.Add("Telefono");
            tablacancelar.Columns.Add("DUI");
            tablacancelar.Columns.Add("Fecha Fin");
            tablacancelar.Columns.Add("Monto");
            tablacancelar.Columns.Add("Cuota");
            tablacancelar.Columns.Add("Estado");
        }

        
    }
}
