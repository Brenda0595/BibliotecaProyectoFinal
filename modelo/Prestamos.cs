using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    class Prestamos
    {
        private int id_codigoprestamo;
        private String nombre;
        private String apellido;
        private String correo;
        private String fecha_inicio;
        private String telefono;
        private String dui;
        private String fecha_fin;
        private String monto;
        private String cuota;
        private String estado;
        private String codigo;
        //private Libros codigo_libro;
        private Usuario codigo_usuario;

        //Getter  y setter
        public int Id_codigoprestamo
        {
            get { return id_codigoprestamo; }
            set { id_codigoprestamo = value; }
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
        public String Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
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
        public String Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public String Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public String Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Usuario Codigo_usuario
        {
            get { return codigo_usuario; }
            set { codigo_usuario = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
