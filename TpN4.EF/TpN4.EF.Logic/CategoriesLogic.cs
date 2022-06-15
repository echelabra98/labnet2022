using System.Collections.Generic;
using System.Linq;
using TpN4.EF.Entities;

namespace TpN4.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories, int>
    {

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Categories item)
        {
            context.Categories.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = context.Categories.Find(id);

            if (category == null)
            {
                throw new LogicException("No se encontró el customer con ese id");
            }
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public void Update(Categories item)
        {
            var categoryUpdate = context.Customers.Find(item.CategoryID);

            if (categoryUpdate == null)
            {
                throw new LogicException("No se encontró el customer con ese id");
            }

            categoryUpdate.CategoryID = item.CategoryID;

            categoryUpdate.CategoryName = item.CategoryName;

            context.SaveChanges();
        }
    }
}
