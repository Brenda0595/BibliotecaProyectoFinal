using BibliotecaProyecto.controlador;
using BibliotecaProyecto.modelo;
using BibliotecaProyecto.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Color de fondo
            this.ForeColor = ColorTranslator.FromHtml("#000000"); // Color de texto
            // Cambiar el color de fondo de un botón específico
            btningresar.BackColor = ColorTranslator.FromHtml("#CCE2EB"); // Cambia el color de fondo del boton btnBuscar 
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                cltUsuarios cltusuario = new cltUsuarios();
                string usuario = txtusuario.Text;
                string contra = txtpassword.Text;
                // Verifica si los campos de usuario y contraseña están vacíos o contienen solo espacios en blanco
                if (string.IsNullOrWhiteSpace(usuario))
                {
                    MessageBox.Show("Por favor, ingrese su usuario.");
                    return; 
                }
                if (string.IsNullOrWhiteSpace(contra))
                {
                    MessageBox.Show("Por favor, ingrese su contraseña.");
                    return; 
                }

                Usuario usu = cltusuario.IsValidUser(usuario, contra);

                if (usu != null)
                {
                   // MessageBox.Show("Credenciales correctas");
                    // Cerrar el formulario actual
                    this.Hide();
                    BibliotecaProyecto.vista.Menu libros = new BibliotecaProyecto.vista.Menu(usu);
                    libros.Show();
                }else{
                    MessageBox.Show("Credenciales inválidas. Por favor, inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception){
                MessageBox.Show("Hubo un inconveniente en el proceso de logeo");
            }
            
        }

        private void limpiarForm()
        {
            txtusuario.Text = "";
            txtpassword.Text = "";
        }
    }
}
