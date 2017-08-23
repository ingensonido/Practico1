using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Comprador
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private String rut;

        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;
        public String Apellido
                {
                    get { return apellido; }
                    set { apellido = value; }
                }
        public Comprador(int codigo, string rut, string nombre, string apellido)
        {
            Codigo = codigo;
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
