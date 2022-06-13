using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpN5.EF.Entities;

namespace TpN5.EF.Logic
{
    public class OrdersLogic : BaseLogic
    {

        public List<Orders> OrdersAndCustomers()
        {
            var query1 = from orders in context.Orders
                   join customers in context.Customers
                   on orders.CustomerID equals customers.CustomerID
                   where customers.Region == "WA" && orders.OrderDate > new DateTime(1997, 1, 1)
                   orderby orders.OrderDate descending
                   select orders;
            return query1.ToList();
        }

        


    }
}
