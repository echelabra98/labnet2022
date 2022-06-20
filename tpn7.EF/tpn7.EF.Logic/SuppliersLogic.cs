using System.Collections.Generic;
using System.Linq;
using tpn7.EF.Entities;

namespace tpn7.EF.Logic
{
    public class SuppliersLogic : BaseLogic, IAMBLogic<Suppliers, int>
    {
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Add(Suppliers item)
        {
            context.Suppliers.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplier = context.Suppliers.Find(id);

            if (supplier == null)
            {
                throw new LogicException("No se encontró el supplier con ese id");
            }
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }

        public void Update(Suppliers item)
        {
            var supplierUpdate = context.Suppliers.Find(item.SupplierID);

            if (supplierUpdate == null)
            {
                throw new LogicException("No se encontró el supplier con ese id");
            }

            supplierUpdate.SupplierID = item.SupplierID;

            supplierUpdate.CompanyName = item.CompanyName;

            supplierUpdate.ContactName = item.ContactName;

            supplierUpdate.ContactTitle = item.ContactTitle;

            supplierUpdate.Address = item.Address;

            supplierUpdate.City = item.City;

            context.SaveChanges();
        }

        public Suppliers GetSupplierById(int id)
        {
            return context.Suppliers.Find(id);
        }
    }
}
