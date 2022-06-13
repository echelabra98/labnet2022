using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpN5.EF.Entities;

namespace TpN5.EF.Logic
{
    public class ProductsLogic : BaseLogic
    {
        //public List<Products> GetAll()
        //{
        //    return context.Products.ToList();
        //}

        public List<Products> SinStockProducts() => context.Products.Where(x => x.UnitsInStock == 0).ToList();

        public List<Products> StockProductsMayorATres() => context.Products.Where(x => x.UnitsInStock != null ).Where(x => x.UnitPrice > 3).ToList();

        public Products ProductPrimerElementos() => context.Products.FirstOrDefault(x => x.ProductID ==  789);

        public Products TraerPrimerProducto() => context.Products.First();

        public List<Products> ProductosOrdenadosPorNombre()
        {
            var query3 = (from productos in context.Products
                          orderby productos.ProductName ascending
                          select productos);
            return query3.ToList();
        }

        public List<Products> ProductosOrdenadosPorStock()
        {
            var query4 = (from productos in context.Products
                          orderby productos.UnitsInStock descending
                          select productos);
            return query4.ToList();

        }

        public List<Products> ProductsAndCategories()
        {
            var query5 = (from products in context.Products
                         join categories in context.Categories
                         on products.CategoryID equals categories.CategoryID
                         orderby categories.CategoryName descending
                         select products);
            return query5.ToList();
        }


        



    }
}
