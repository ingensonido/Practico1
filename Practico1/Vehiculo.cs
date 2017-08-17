using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Vehiculo
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string tipo;

        public string Tipo

        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string patente;

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        private int kilometro;

        public int Kilometro
        {
            get { return kilometro; }
            set { kilometro = value; }
        }

    }
}
