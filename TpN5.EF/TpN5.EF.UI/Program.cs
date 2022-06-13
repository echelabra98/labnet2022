using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpN5.EF.Entities;
using TpN5.EF.Logic;

namespace TpN5.EF.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            OrdersLogic ordersLogic = new OrdersLogic();


            Console.WriteLine("Query para devolver customer \n");

            foreach (Customers customer in customerLogic.ObtenerCustomer())
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine("Query para devolver todos los productos sin stock \n");

            foreach (Products products in productsLogic.SinStockProducts())
            {
                Console.WriteLine(products.ProductName);
            }

            Console.WriteLine("Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad \n");

            foreach (Products products in productsLogic.StockProductsMayorATres())
            {
                Console.WriteLine(products.ProductName);
            }

            Console.WriteLine("Query para devolver todos los customers de la Región WA \n");

            foreach (Customers customer in customerLogic.CustomersRegionWA())
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine("Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789 \n");

            var product789 = productsLogic.ProductPrimerElementos();

            Console.WriteLine(product789);

            Console.WriteLine("Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula. \n");

            foreach (var customer in customerLogic.CustomersNombres())
            {
                Console.WriteLine(customer.ToUpper());
                Console.WriteLine(customer.ToLower());
            }

            Console.WriteLine("Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997. \n");

            foreach (var orders in ordersLogic.OrdersAndCustomers())
            {
                Console.WriteLine(orders.CustomerID);
            }

            Console.WriteLine("Query para devolver los primeros 3 Customers de la  Región WA \n");

            foreach (var customer in customerLogic.PrimerosTresClientes())
            {
                Console.WriteLine(customer.CustomerID);
            }

            Console.WriteLine("Query para devolver lista de productos ordenados por nombre \n");

            foreach (var products in productsLogic.ProductosOrdenadosPorNombre())
            {
                Console.Write(products.ProductName);
            }

            Console.WriteLine("Query para devolver lista de productos ordenados por unit in stock de mayor a menor \n");

            foreach (var products in productsLogic.ProductosOrdenadosPorStock())
            {
                Console.Write(products.ProductName);
            }

            Console.WriteLine("Query para devolver las distintas categorías asociadas a los productos \n");

            foreach (var products in productsLogic.ProductsAndCategories())
            {
                Console.WriteLine(products.CategoryID);
            }

            Console.WriteLine("Query para devolver el primer elemento de una lista de productos \n");

            var primerProducto = productsLogic.TraerPrimerProducto();

            Console.WriteLine(primerProducto.ProductName);

            Console.WriteLine("Query para devolver los customer con la cantidad de ordenes asociadas \n");

            foreach (var customers in customerLogic.CustomersAndOrdenesAsociadas())
            {
                Console.WriteLine(customers.Orders.Count());
            }


            Console.ReadKey();
        }
    }
}
