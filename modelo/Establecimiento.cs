using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto.modelo
{
    class Establecimiento
    {
        private int id_establecimiento;
        private int cantida;
        private String codigo;
        private int cantidadAgr;
        private int cantidadActual;

        // Getter y setter
        public int Id_establecimiento
        {
            get { return id_establecimiento; }
            set { id_establecimiento = value; }
        }
        public int Cantida
        {
            get { return cantida; }
            set { cantida = value; }
        }
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int CantidadAgr
        {
            get { return cantidadAgr; }
            set { cantidadAgr = value; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
            set { cantidadActual = value; }
        }
    }
}
