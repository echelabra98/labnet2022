using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a 'Conteo de pasajeros', esta aplicación sirve para realizar un control de pasajeros para cada transporte! \n ");

            Console.WriteLine("Comenzaremos con el ingreso de los pasajeros que viajan en omnibus: \n ");


            Console.WriteLine("Ingrese la cantidad de pasajeros para el omnibus n°1");
            var pasajeros = int.Parse(Console.ReadLine());
            var omnibus1 = new Omnibus(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el omnibus n°2");
            pasajeros = int.Parse(Console.ReadLine());
            var omnibus2 = new Omnibus(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el omnibus n°3");
            pasajeros = int.Parse(Console.ReadLine());
            var omnibus3 = new Omnibus(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el omnibus n°4");
            pasajeros = int.Parse(Console.ReadLine());
            var omnibus4 = new Omnibus(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el omnibus n°5 ");
            pasajeros = int.Parse(Console.ReadLine());
            var omnibus5 = new Omnibus(pasajeros);

            Console.WriteLine("\n");


            Console.WriteLine("Prosiga a ingresar los pasajeros que viajan en taxi: \n ");

            Console.WriteLine("Ingrese la cantidad de pasajeros para el taxi n°1");
            pasajeros = int.Parse(Console.ReadLine());
            var taxi1 = new Taxi(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el taxi n°2");
            pasajeros = int.Parse(Console.ReadLine());
            var taxi2 = new Taxi(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el taxi n°3");
            pasajeros = int.Parse(Console.ReadLine());
            var taxi3 = new Taxi(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el taxi n°4");
            pasajeros = int.Parse(Console.ReadLine());
            var taxi4 = new Taxi(pasajeros);

            Console.WriteLine("Ingrese la cantidad de pasajeros para el taxi n°5");
            pasajeros = int.Parse(Console.ReadLine());
            var taxi5 = new Taxi(pasajeros);

            var listaTransporte = new List<TransportePublico>()
            {
                omnibus1,
                omnibus2,
                omnibus3,
                omnibus4,
                omnibus5,
                taxi1,
                taxi2,
                taxi3,
                taxi4,
                taxi5
            };

            var contOmnibus = 0;
            var contTaxi = 0;
            

            foreach (var transporte in listaTransporte)
            {
                contOmnibus++;

                if(contOmnibus <= 5)
                {
                    Console.WriteLine($"\n La cantidad de pasajeros del omnibus N° {contOmnibus} es de: {transporte.pasajeros} \n");
                }
                else
                {
                    contTaxi++;

                    Console.WriteLine($"\n La cantidad de pasajeros del taxi N° {contTaxi} es de: {transporte.pasajeros} \n ");
                }

            }

            Console.WriteLine("\n");

            Console.WriteLine("Muchas gracias por participar, la aplicación se cerrara luego de pulsar la tecla 'ESC '");

            Console.ReadKey();

            

        }
    }
}
