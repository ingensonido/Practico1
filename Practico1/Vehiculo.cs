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

        private int tipo;

        public int Tipo

        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int anio;

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
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
        public Vehiculo(int codigo, string marca, int tipo, int anio, string patente, int kilometro)
        {
            Codigo = codigo;
            Marca = marca;
            Tipo = tipo;
            Anio = anio;
            Patente = patente;
            Kilometro = kilometro;
        }
    }
}
