using BibliotecaProyecto.controlador;
using BibliotecaProyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto.vista.usuario
{
    public partial class mttUsuarios : Form
    {

        public mttUsuarios()
        {
            InitializeComponent();
            InitializeMyTextArea();
            LlenarDataGridViewUsuarios();

            // Suscribir el evento CellClick del DataGridView
            dtgvwUsuarios.CellClick += dtgvwUsuarios_CellClick;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btnagregar.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Cambia el color de fondo del boton btnBuscar 
            btnactualizar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            btneliminar.BackColor = ColorTranslator.FromHtml("#CCE2EB");
            // Cambiar el color de fondo y el color del texto para el TextBox txtNombre
              txtNombre.BackColor = ColorTranslator.FromHtml("#EAEAEA"); // Cambiar el color de fondo
              txtApellido.BackColor = ColorTranslator.FromHtml("#EAEAEA"); 
              txtCorreo.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              txtDireccion.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              txtTelefono.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              txtDui.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              txtUsuario.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              txtPassword.BackColor = ColorTranslator.FromHtml("#EAEAEA");
              cmbEstado.BackColor = ColorTranslator.FromHtml("#EAEAEA");
     }

        private void InitializeMyTextArea()
        {

            // Establecer la propiedad Multiline en true para permitir multiples lineas de texto
            txtDireccion.Multiline = true;

            // Establecer el tamaño y la posicion del control en el formulario
            txtDireccion.Size = new System.Drawing.Size(200, 50);
            //txtDireccion.Location = new System.Drawing.Point(50, 50);

            // Agregar el control al formulario
            this.Controls.Add(txtDireccion);

            //Llenar combobox
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Suspendido");
            cmbEstado.Items.Add("Eliminado");
            //cmbEstado.Items.Add("D");
            

            //Mascara de Telefono DUI y Correo
            txtTelefono.Mask = "0000-0000";
            txtDui.Mask = "00000000-0";
            //txtCorreo.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL@LLLLLLLLLLLL.LLLL";
        }

        private void LlenarDataGridViewUsuarios()
        {
            cltUsuarios controladorUsuario = new cltUsuarios();
            // Obtener la lista de usuarios
            List<Usuario> usuarios = controladorUsuario.ObtenerUsuarios();

            // Verificar si la lista de usuarios no es nula y tiene elementos
            if (usuarios != null && usuarios.Count > 0)
            {
                // Crear una tabla para almacenar los datos
                DataTable tablaUsuarios = new DataTable();

                tablaUsuarios.Columns.Add("Nombre");
                tablaUsuarios.Columns.Add("Apellido");
                tablaUsuarios.Columns.Add("Correo");
                tablaUsuarios.Columns.Add("Direccion");
                tablaUsuarios.Columns.Add("Telefono");
                tablaUsuarios.Columns.Add("DUI");
                tablaUsuarios.Columns.Add("Username");
                tablaUsuarios.Columns.Add("Contraseña");
                tablaUsuarios.Columns.Add("Estado");
                tablaUsuarios.Columns.Add("ID");

                // Llenar la tabla con los datos de los usuarios
                foreach (Usuario usuario in usuarios)
                {
                    tablaUsuarios.Rows.Add(usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Direccion, usuario.Telefono, usuario.Dui, usuario.Username,usuario.Contrasena, usuario.Estado,usuario.Id_usuario);
                }

                // Asignar la tabla como origen de datos del DataGridView
                dtgvwUsuarios.DataSource = tablaUsuarios;
            }
            else
            {
                // Si la lista está vacía o nula, mostrar un mensaje o realizar otra acción según sea necesario
                Console.WriteLine("La lista de usuarios está vacía o nula.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            bool camposllenos = CamposNoVacios();
            if (camposllenos == false)
            {
                return;
            }

            // Crear un objeto Usuario con los datos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Dui = txtDui.Text,
                Username = txtUsuario.Text,
                Contrasena = txtPassword.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            // Crear una instancia del controlador de usuarios
            cltUsuarios controladorUsuarios = new cltUsuarios();

            // Intentar agregar el nuevo usuario a la base de datos
            int resultado =controladorUsuarios.CrearUsuario(nuevoUsuario);
            if (resultado ==0)
            {
                // Si se agrega correctamente, actualizar el DataGridView
                LlenarDataGridViewUsuarios();
                MessageBox.Show("Usuario agregado correctamente.");
            }
            else if (resultado == 1)
            {
                MessageBox.Show("El nombre de usuario ya esta en uso. Por favor, elija otro.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Si hay un error, mostrar un mensaje de error
                MessageBox.Show("Error al agregar el usuario.");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dtgvwUsuarios.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                //DataGridViewRow filaSeleccionada = dtgvwUsuarios.SelectedRows[0];
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar un dato de la tabla para Actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener ID del usuario seleccionada
                int idusuario = int.Parse(txtId.Text);

                // Validación del correo electrónico con expresión regular
                string correo = txtCorreo.Text.Trim();
                // Patrón de expresión regular para validar el formato del correo electrónico
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(correo, pattern))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ;
                }


                // Crear un objeto Usuario con los datos de la fila seleccionada
                Usuario usuarioActualizar = new Usuario
                {
                    Id_usuario = idusuario,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Dui = txtDui.Text,
                    Username = txtUsuario.Text,
                    Contrasena = txtPassword.Text,
                    Estado = cmbEstado.SelectedItem.ToString()
                };

                // Crear una instancia del controlador de usuarios
                cltUsuarios controladorUsuarios = new cltUsuarios();

                // Intentar actualizar el usuario en la base de datos
                int resultado =controladorUsuarios.ActualizarUsuario(usuarioActualizar);
                if (resultado == 0)
                {
                    // Si se actualiza correctamente, actualizar el DataGridView
                    LlenarDataGridViewUsuarios();
                    MessageBox.Show("Usuario actualizado correctamente.");
                }
                else
                {
                    // Si hay un error, mostrar un mensaje de error
                    MessageBox.Show("Error al actualizar el usuario.");
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Seleccione un usuario para actualizar.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dtgvwUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario de la fila seleccionada
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Debe seleccionar un dato de la tabla para Actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener ID del usuario seleccionado
                int idUsuarioEliminar = int.Parse(txtId.Text);

                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Crear una instancia del controlador de usuarios
                    cltUsuarios controladorUsuarios = new cltUsuarios();

                    // Intentar eliminar el usuario de la base de datos
                    if (controladorUsuarios.EliminarUsuario(idUsuarioEliminar))
                    {
                        // Si se elimina correctamente, actualizar el DataGridView
                        LlenarDataGridViewUsuarios();
                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                    else
                    {
                        // Si hay un error, mostrar un mensaje de error
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }

        private bool CamposNoVacios()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string correo = txtCorreo.Text.Trim();
            // Verificar que todos los campos estén completos
            // Mostrar un mensaje de advertencia para cada campo faltante
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo Correo es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(correo, pattern))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo Dirección es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDui.Text))
            {
                MessageBox.Show("El campo DUI es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void dtgvwUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha hecho clic en una celda que no sea de encabezado
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgvwUsuarios.Rows[e.RowIndex];

                // Mostrar los valores en los campos TextBox
                txtId.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                txtDui.Text = filaSeleccionada.Cells["DUI"].Value.ToString();
                txtUsuario.Text = filaSeleccionada.Cells["Username"].Value.ToString();
                txtPassword.Text = filaSeleccionada.Cells["Contraseña"].Value.ToString();
                cmbEstado.SelectedItem = filaSeleccionada.Cells["Estado"].Value.ToString();
            }
        }
       
    }
}
