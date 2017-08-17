using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Tipo> listaDeTipos = new List<Tipo>()
            {
                new Tipo(1,"Auto"),
                new Tipo(2,"Camioneta"),
                new Tipo(3,"Moto")
            };

            IEnumerable<Comprador> listaDeClientes = new List<Comprador>()
            {
                new Comprador(1,"11.111.111-1","Alan","Brito"),
                new Comprador(2,"22.222.222-2","Elmo","Skard")
            };

            IEnumerable<Vehiculo> listaDeVehiculos = new List<Vehiculo>()
            {
                new Vehiculo(1,"HYUNDAI", 1, 2018, "KY.GC.01", 0),
                new Vehiculo(2,"MG3", 2, 2018, "KY.GC.02",0),
                new Vehiculo(3,"TOYOTA",3,2018,"KY.GC.03",0),
                new Vehiculo(4,"NISSAN",1,2018,"KY.GC.04",0),
            };

            Console.WriteLine("SISTEMA DE VENTAS DE VEHICULOS");
            Console.WriteLine("SELECCIONE UN TIPO DE VEHICULO");
            foreach(Tipo tipo in listaDeTipos)
            {
                Console.WriteLine(tipo.Codigo + " " + tipo.NombreTipo);
            }
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("LISTADO DE VEHICULOS DISPONIBLES:");
            int cont = 0;
            foreach(Vehiculo vehiculo in listaDeVehiculos)
            {
                if (vehiculo.Tipo == codigo)
                {
                    cont++;
                    Console.WriteLine("Marca: " + vehiculo.Marca + " Año: " + vehiculo.Anio);
                }      
            }
            if (cont == 0)
            {
                Console.WriteLine("No hay nada");
            }

            //foreach (Comprador cliente in comprador)
            //{
            //    Console.WriteLine(cliente.Codigo + " " + cliente.Rut + " " + cliente.Nombre + " " + cliente.Apellido);
            //}


            //foreach (Tipo tipo in tipos)
            //{
            //    Console.WriteLine(tipo.NombreTipo);
            //}

            Console.ReadKey();
        }
    }
}
