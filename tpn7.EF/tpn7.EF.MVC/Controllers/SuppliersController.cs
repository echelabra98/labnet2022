using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using tpn7.EF.Entities;
using tpn7.EF.Logic;
using tpn7.EF.MVC.Models;

namespace tpn7.EF.MVC.Controllers
{
    public class SuppliersController : Controller
    {
        readonly SuppliersLogic SuppliersLogic = new SuppliersLogic();


        // GET: Customers
        public ActionResult Index()
        {
            List<SuppliersView> suppliersView = SuppliersLogic.GetAll().Select(s => new SuppliersView
            {
                Id = s.SupplierID,
                Description = s.CompanyName,
                Contacto = s.ContactName,
                ContactoTitle = s.ContactTitle,
                Direccion = s.Address,
                Ciudad = s.City,
            })
            .ToList();
            
            return View(suppliersView);
        }

        public ActionResult Insert()
        {
            return View("InsertUpdate");
        }

        [HttpPost]

        public ActionResult InsertUpdate(SuppliersView suppliersView)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("InsertUpdate", suppliersView);
                }

                var suppliersEntity = new Suppliers
                {
                    SupplierID = suppliersView.Id ?? 0,
                    CompanyName = suppliersView.Description,
                    ContactName = suppliersView.Contacto,
                    ContactTitle = suppliersView.ContactoTitle,
                    Address = suppliersView.Direccion,
                    City = suppliersView.Ciudad
                };

                if (suppliersView.Id == 0)
                {
                    SuppliersLogic.Add(suppliersEntity);
                }
                else
                {
                    SuppliersLogic.Update(suppliersEntity);
                }
                
                
                return RedirectToAction("Index");
            }
            catch
            {
               
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            SuppliersLogic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var supplier = SuppliersLogic.GetSupplierById(id);
            var supplierView = new SuppliersView
            {
                Id = supplier.SupplierID,
                Description = supplier.CompanyName,
                Contacto = supplier.ContactName,
                ContactoTitle = supplier.ContactTitle,
                Direccion = supplier.Address,
                Ciudad = supplier.City
            };

            return View("InsertUpdate", supplierView);
        }
    }
}
