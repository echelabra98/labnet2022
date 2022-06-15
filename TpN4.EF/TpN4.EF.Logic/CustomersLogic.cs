using System.Collections.Generic;
using System.Linq;
using TpN4.EF.Entities;

namespace TpN4.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers, string>
    {

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Add(Customers item)
        {
            context.Customers.Add(item);
            context.SaveChanges();
        }

        public void Update(Customers item)
        {
            var customerUpdate = context.Customers.Find(item.CustomerID);

            if (customerUpdate == null)
            {
                throw new LogicException("No se encontró el customer con ese id");
            }

            customerUpdate.CustomerID = item.CustomerID;

            customerUpdate.CompanyName = item.CompanyName;

            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var customer = context.Customers.Find(id);

            if (customer == null)
            {
                throw new LogicException("No se encontró el customer con ese id");
            }

            context.Customers.Remove(customer);

            context.SaveChanges();
        }
    }
}
