using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    class Libros
    {
        private int id_libro;
        private String nombre;
        private String autor;
        private String fecha;
        private String pais;
        private String fecha_ingreso;
        private String codigo;
        private int disponible;
        private String existencia;
        private String estado;
        private Establecimiento establecimiento;
        private Categoria categoria;

        // getter y setter
        public int Id_libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public String Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public String Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        internal Establecimiento Establecimiento
        {
            get { return establecimiento; }
            set { establecimiento = value; }
        }

        internal Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

    }
}
