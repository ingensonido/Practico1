using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Venta
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private long montoVenta;

        public long MontoVenta
        {
            get { return montoVenta; }
            set { montoVenta = value; }
        }

        private int vehiculo;

        public int Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }

        private int comprador;

        public int Comprador
        {
            get { return comprador; }
            set { comprador = value; }
        }

        


    }
}
