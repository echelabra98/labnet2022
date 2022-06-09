using System;
using TpN4.EF.Entities;
using TpN4.EF.Logic;

namespace TpN4.EF.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customersLogic = new CustomersLogic();

            Console.WriteLine("Bienvenido a la sección de clientes! Ingrese el número correspondiente a la acción que desea realizar \n");
            Console.WriteLine("N° 1 para agregar un nuevo cliente \n");
            Console.WriteLine("N° 2 para actualizar un registro \n");
            Console.WriteLine("N° 3 para borrar un cliente \n");

            try
            {
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"El numero ingresado fue: {num1} \n");

                if (num1 == 1)
                {
                    Console.WriteLine("Ingrese el ID de la persona \n");
                    var customID = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la compañía \n");
                    var nombreCompañía = Console.ReadLine();

                    customersLogic.Add(new Customers
                    {
                        CustomerID = customID,
                        CompanyName = nombreCompañía,
                    });

                    Console.WriteLine("Se ha agregado un nuevo cliente \n");
                }
                else if (num1 == 2)
                {
                    Console.WriteLine("Ingrese el ID del cliente que quiere actualizar \n");
                    var IdCliente = Console.ReadLine();

                    Console.WriteLine("Ingrese el nombre de la compañía \n");
                    var nombreCompañía = Console.ReadLine();


                    customersLogic.Update(new Customers
                    {
                        CustomerID = IdCliente,
                        CompanyName = nombreCompañía,
                    });

                    Console.WriteLine("Se ha actualizado un registro \n");

                }
                else if (num1 == 3)
                {
                    Console.WriteLine("Ingrese el ID del cliente que quiere borrar \n");

                    var customerId = Console.ReadLine();

                    customersLogic.Delete(customerId);

                    Console.WriteLine("El cliente ha sido borrado \n");
                }
                else
                {
                    Console.WriteLine($"El numero ingresado {num1} no corresponde a ninguna acción disponible \n");
                }
            }
            catch (LogicException e)
            {
                var tipoExcepcion = e.GetType();
                var mensajeExcepcion = e.Message;
                Console.WriteLine($" Se ha producido una excepcion de tipo: {tipoExcepcion}\n Detalle de la excepcion:  {mensajeExcepcion}  \n");
            }
            catch (Exception e)
            {
                var tipoExcepcion = e.GetType();
                var mensajeExcepcion = e.Message;
                Console.WriteLine($" Se ha producido una excepcion de tipo: {tipoExcepcion}\n Detalle de la excepcion:  {mensajeExcepcion}  \n");
            }

            Console.WriteLine("Información actual de los clientes \n");

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"ID: {customer.CustomerID}");
                Console.WriteLine($"Nombre de Compañía: {customer.CompanyName} \n ");
            }

            Console.ReadKey();
        }
    }
}

