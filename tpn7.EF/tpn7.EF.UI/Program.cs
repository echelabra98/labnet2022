using System;
using tpn7.EF.Entities;
using tpn7.EF.Logic;

namespace tpn7.EF.UI
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

                while (num1 > 0 && num1 < 4)
                {
                    string nombreCompania;
                    switch (num1)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el ID de la persona \n");
                            var customID = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre de la compañía \n");
                            nombreCompania = Console.ReadLine();

                            customersLogic.Add(new Customers
                            {
                                CustomerID = customID,
                                CompanyName = nombreCompania,
                            });

                            Console.WriteLine("Se ha agregado un nuevo cliente \n");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el ID del cliente que quiere actualizar \n");
                            var IdCliente = Console.ReadLine();

                            Console.WriteLine("Ingrese el nombre de la compañía \n");
                            nombreCompania = Console.ReadLine();


                            customersLogic.Update(new Customers
                            {
                                CustomerID = IdCliente,
                                CompanyName = nombreCompania,
                            });

                            Console.WriteLine("Se ha actualizado un registro \n");
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el ID del cliente que quiere borrar \n");

                            var customerId = Console.ReadLine();

                            customersLogic.Delete(customerId);

                            Console.WriteLine("El cliente ha sido borrado \n");
                            break;
                        default:
                            Console.WriteLine($"El numero ingresado {num1} no corresponde a ninguna acción disponible \n");
                            break;
                    }
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
