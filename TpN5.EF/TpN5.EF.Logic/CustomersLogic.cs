using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpN5.EF.Entities;

namespace TpN5.EF.Logic
{
    public class CustomersLogic : BaseLogic
    {

        public List<Customers> ObtenerCustomer() => context.Customers.ToList();

        public List<Customers> CustomersRegionWA() => context.Customers.Where(x => x.Region == "WA").ToList();

        public List<string> CustomersNombres() => context.Customers.Select(x => x.CompanyName).ToList();

        public List<Customers> PrimerosTresClientes()
        {
            var query2 = (from customers in context.Customers
                         where customers.Region == "WA"
                         orderby customers.CustomerID
                         select customers).Take(3);
            return query2.ToList();
        }

        public List<Customers> CustomersAndOrdenesAsociadas()
        {
            var query6 = from customers in context.Customers
                         join orders in context.Orders
                         on customers.CustomerID equals orders.CustomerID
                         where customers.Orders.Count() > 0
                         orderby orders.OrderDate descending
                         select customers;
            return query6.ToList();
        }






    }
}
