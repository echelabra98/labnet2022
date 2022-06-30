using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using tpn7.EF.Entities;
using tpn7.EF.Logic;

namespace tpn8.Creacion.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SuppliersController : ApiController
    {
        private readonly SuppliersLogic logic = new SuppliersLogic();

        // GET: api/Suppliers
        public List<Suppliers> GetSuppliers()
        {
            var suppliers = logic.GetAll();
            return suppliers;
        }

        // GET: api/Suppliers/5
        [ResponseType(typeof(Suppliers))]
        public IHttpActionResult GetSuppliers(int id)
        {
            Suppliers suppliers = logic.GetSupplierById(id);
            if (suppliers == null)
            {
                return NotFound();
            }

            return Ok(suppliers);
        }

        // PUT: api/Suppliers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSuppliers(int id, Suppliers suppliers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != suppliers.SupplierID)
            {
                return BadRequest();
            }

            logic.Update(suppliers);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Suppliers
        [ResponseType(typeof(Suppliers))]
        public IHttpActionResult PostSuppliers(Suppliers suppliers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            logic.Add(suppliers);

            return CreatedAtRoute("DefaultApi", new { id = suppliers.SupplierID }, suppliers);
        }

        // DELETE: api/Suppliers/5
        [ResponseType(typeof(Suppliers))]
        public IHttpActionResult DeleteSuppliers(int id)
        {
            Suppliers suppliers = logic.GetSupplierById(id);
            if (suppliers == null)
            {
                return NotFound();
            }

            logic.Delete(id);

            return Ok(suppliers);
        }

    }
}