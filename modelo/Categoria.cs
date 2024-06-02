using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    class Categoria
    {
        private int id_categoria;
        private String nombre;
        private String campo_clase;
        private String genero;
        private String tema_libro;

        

        // getter y setter
        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Campo_clase
        {
            get { return campo_clase; }
            set { campo_clase = value; }
        }
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public String Tema_libro
        {
            get { return tema_libro; }
            set { tema_libro = value; }
        }
    }
}
