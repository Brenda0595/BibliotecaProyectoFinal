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

namespace BibliotecaProyecto.vista.establecimiento
{
    public partial class mttEstablecimientos : Form
    {
        public mttEstablecimientos()
        {
            InitializeComponent();
            LlenarDataGridViewEstablecimientos();
            dataGridView1.CellClick += dataGridView1_CellClick;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnBuscar.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Cambia el color de fondo del boton btnBuscar 
            btnAgregar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnActualizar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btnEliminar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
            txtCodigo.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
            txtId.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
            numdCantidad.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
            numdCantidadAgr.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            numdcantidadActual.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
        }

        private void LlenarDataGridViewEstablecimientos()
        {
            ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();
            List<Establecimiento> establecimientos = controladorEstablecimiento.ObtenerEstablecimientos();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (establecimientos != null && establecimientos.Count > 0)
            {
                DataTable tablaEstablecimientos = new DataTable();
                tablaEstablecimientos.Columns.Add("Cantidad");
                tablaEstablecimientos.Columns.Add("Codigo");
                tablaEstablecimientos.Columns.Add("CantidadAgr");
                tablaEstablecimientos.Columns.Add("CantidadActual");
                tablaEstablecimientos.Columns.Add("ID");

                foreach (Establecimiento establecimiento in establecimientos)
                {
                    tablaEstablecimientos.Rows.Add(establecimiento.Cantida, establecimiento.Codigo, establecimiento.CantidadAgr, establecimiento.CantidadActual, establecimiento.Id_establecimiento);
                }

                dataGridView1.DataSource = tablaEstablecimientos;
            }
            else
            {
                Console.WriteLine("La lista de establecimientos está vacía o nula.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["ID"].Value.ToString();
                numdCantidad.Value = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                numdCantidadAgr.Value = Convert.ToDecimal(row.Cells["CantidadAgr"].Value);
                numdcantidadActual.Value = Convert.ToDecimal(row.Cells["CantidadActual"].Value);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el campo de búsqueda no esté vacío
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el campo de búsqueda no esté vacío
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el establecimiento por el código
            string codigoABuscar = txtCodigo.Text;
            ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();
            Establecimiento establecimientoEncontrado = controladorEstablecimiento.BuscarEstablecimientoPorCodigo(codigoABuscar);

            // Si se encontró el establecimiento, llenar los campos del formulario
            if (establecimientoEncontrado != null)
            {
                txtId.Text = establecimientoEncontrado.Id_establecimiento.ToString();
                txtCodigo.Text = establecimientoEncontrado.Codigo;
                numdCantidad.Value = establecimientoEncontrado.Cantida;
                numdCantidadAgr.Value = establecimientoEncontrado.CantidadAgr;
                numdcantidadActual.Value = establecimientoEncontrado.CantidadActual;
            }
            else
            {
                MessageBox.Show("No se encontró ningún establecimiento con el código proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén completos antes de agregar
            if (CamposObligatorios())
            {
                if (Convert.ToInt32(numdcantidadActual.Value) > Convert.ToInt32(numdCantidadAgr.Value))
                {
                    MessageBox.Show("La cantidad Actual de libro no debe ser mayor a cantidad Agregada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Establecimiento nuevoEstablecimiento = new Establecimiento
                {
                    Cantida = Convert.ToInt32(numdCantidad.Value),
                    Codigo = txtCodigo.Text,
                    CantidadAgr = Convert.ToInt32(numdCantidadAgr.Value),
                    CantidadActual = Convert.ToInt32(numdcantidadActual.Value)
                };

                ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();

                // Verificar si el código ya existe antes de intentar agregar el establecimiento
                Establecimiento establecimientoExistente = controladorEstablecimiento.BuscarEstablecimientoPorCodigo(nuevoEstablecimiento.Codigo);
                if (establecimientoExistente != null)
                {
                    MessageBox.Show("Ya existe un establecimiento con el mismo código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctlEstablecimiento agregarExtablecimiento = new ctlEstablecimiento();
                bool exito = agregarExtablecimiento.CrearEstablecimiento(nuevoEstablecimiento);

                if (exito)
                {
                    MessageBox.Show("Establecimiento agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridViewEstablecimientos(); // Refrescar el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar establecimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numdcantidadActual.Value) > Convert.ToInt32(numdCantidadAgr.Value))
            {
                MessageBox.Show("La cantidad Actual de libro no debe ser mayor a cantidad Agregada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                Establecimiento establecimiento = new Establecimiento
                {
                    Id_establecimiento = Convert.ToInt32(txtId.Text),
                    Cantida = Convert.ToInt32(numdCantidad.Value),
                    Codigo = txtCodigo.Text,
                    CantidadAgr = Convert.ToInt32(numdCantidadAgr.Value),
                    CantidadActual = Convert.ToInt32(numdcantidadActual.Value)
                };

                ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();
                bool exito = controladorEstablecimiento.ActualizarEstablecimiento(establecimiento);

                if (exito)
                {
                    MessageBox.Show("Establecimiento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridViewEstablecimientos(); // Refrescar el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar establecimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un establecimiento para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este establecimiento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int id_establecimiento = Convert.ToInt32(txtId.Text);
                    ctlEstablecimiento controladorEstablecimiento = new ctlEstablecimiento();
                    bool exito = controladorEstablecimiento.EliminarEstablecimiento(id_establecimiento);

                    if (exito)
                    {
                        MessageBox.Show("Establecimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGridViewEstablecimientos(); // Refrescar el DataGridView
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar establecimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un establecimiento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CamposObligatorios()
        {
            // Verificar si los campos obligatorios están completos
            /*if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El campo ID es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }*/

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo Código es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numdCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad es obligatoria y debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numdCantidadAgr.Value == 0)
            {
                MessageBox.Show("La cantidad agregada es obligatoria y debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numdcantidadActual.Value == 0)
            {
                MessageBox.Show("La cantidad actual es obligatoria y debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtCodigo.Clear();
            numdCantidad.Value = 0;
            numdCantidadAgr.Value = 0;
            numdcantidadActual.Value = 0;
        }
    }
}
