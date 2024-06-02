using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    class LineaPrestamos
    {
        private int id_codigolineaprestamo;
        private string codigolinea_prestamos;
        private string nombre_libro;
        private string codigo_libro;
        private string nombre;
        private string apellido;
        private string correo;
        private DateTime fecha_inicio;
        private string telefono;
        private string dui;
        private DateTime fecha_fin;
        private decimal monto;
        private decimal cuota;
        private string estado;
        private string codigo;

        // Getter y Setter
        public int Id_codigolineaprestamo
        {
            get { return id_codigolineaprestamo; }
            set { id_codigolineaprestamo = value; }
        }

        public string Codigolinea_prestamos
        {
            get { return codigolinea_prestamos; }
            set { codigolinea_prestamos = value; }
        }

        public string Nombre_libro
        {
            get { return nombre_libro; }
            set { nombre_libro = value; }
        }

        public string Codigo_libro
        {
            get { return codigo_libro; }
            set { codigo_libro = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public DateTime Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public DateTime Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public decimal Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
