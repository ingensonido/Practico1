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

            List<Comprador> listaDeClientes = new List<Comprador>()
            {
                new Comprador(1,"11.111.111-1","Alan","Brito"),
                new Comprador(2,"22.222.222-2","Elmo","Skard")
            };

            List<Vehiculo> listaDeVehiculos = new List<Vehiculo>();


            listaDeVehiculos.Add(new Vehiculo(1, "HYUNDAI", 1, 2018, "KY.GC.01", 0, 2000));
            listaDeVehiculos.Add(new Vehiculo(2, "MG3", 2, 2018, "KY.GC.02", 0, 4000));
            listaDeVehiculos.Add(new Vehiculo(3, "TOYOTA", 3, 2018, "KY.GC.03", 0, 6000));
            listaDeVehiculos.Add(new Vehiculo(4, "NISSAN", 1, 2018, "KY.GC.04", 0, 8000));
            listaDeVehiculos.Add(new Vehiculo(5, "YAMAHA", 1, 2012, "WK.09.14", 12000, 10000));

            Console.WriteLine("SISTEMA DE VENTAS DE VEHICULOS");
            Console.WriteLine("INGRESE SU RUT");
            String rut = Console.ReadLine();
            int valida = 0;
            int cont = 1;
            foreach (Comprador cliente in listaDeClientes)
            {
                String rutCliente = "No Existe";
                cont++;
                if (rut==cliente.Rut)
                {
                    rutCliente.Equals(cliente.Rut);
                    Console.WriteLine("Usuario Existe");
                    valida = 1;
                    break;
                }
                else
                {
                    valida = 0;
                }           
            }

            if (valida == 0)
            {
                Console.WriteLine("Rut No Existe");
                Console.WriteLine("Desea crear un nuevo cliente con el RUT: " + rut);
                Console.WriteLine("\n1- SI 0-NO");
                int opcionCrear = int.Parse(Console.ReadLine());
                switch (opcionCrear)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("Crear Usuario con rut " + rut);
                        Console.WriteLine("Ingrese Nombre");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido");
                        String apellido = Console.ReadLine();
                        Console.WriteLine("Esta correcto el usuario con: \nRUT " + rut + "\nNombre: " + nombre + "\nApellido: " + apellido);
                        Console.WriteLine("\n1- SI 2-NO");
                        int opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 0:
                                break;
                            case 1:
                                listaDeClientes.Add(new Comprador(cont, rut, nombre, apellido));
                                Console.WriteLine("Usuario creado Correctamente");
                                int codigoCliente = cont;

                                Console.WriteLine("El Cliente tiene el codigo: " + codigoCliente);
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }



            }
            Console.WriteLine("SELECCIONE UN TIPO DE VEHICULO");
            foreach(Tipo tipo in listaDeTipos)
            {
                Console.WriteLine(tipo.Codigo + " " + tipo.NombreTipo);
            }
            int codigoTipo = int.Parse(Console.ReadLine());

            Console.WriteLine("LISTADO DE VEHICULOS DISPONIBLES:");
            int cont2 = 0;
            foreach(Vehiculo vehiculo in listaDeVehiculos)
            {
                cont2++;
                if (vehiculo.Tipo == codigoTipo)
                {
                    Console.WriteLine("Marca: " + vehiculo.Marca + " Año: " + vehiculo.Anio);
                }      
            }
            if (cont == 0)
            {
                Console.WriteLine("No hay nada");
            }

            foreach (Vehiculo datov in listaDeVehiculos)
            {
                String nombreTipo = "No Existe";
                foreach (Tipo datot in listaDeTipos)
                {
                    if (datot.Codigo == datov.Tipo)
                    {
                        nombreTipo = datot.NombreTipo;
                    }
                }
                Console.WriteLine("Codigo: " + datov.Codigo + "-Tipo:" + nombreTipo);
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
