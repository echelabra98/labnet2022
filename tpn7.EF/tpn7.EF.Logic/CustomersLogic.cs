using System.Collections.Generic;
using System.Linq;
using tpn7.EF.Entities;

namespace tpn7.EF.Logic
{
    public class CustomersLogic : BaseLogic, IAMBLogic<Customers, string>
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

        
    }
}
