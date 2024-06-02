using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    public class Usuario
    {
        private int id_usuario;
        private String nombre;
        private String apellido;
        private String correo;
        private String direccion;
        private String telefono;
        private String dui;
        private String username;
        private String contrasena;
        private String estado;

        // Getter y setter
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public String Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
