using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using tpn7.EF.Logic.PokeApi;
using tpn8.Web.Api.Models;

namespace tpn8.Web.Api.Controllers
{
    public class PokeController : Controller
    {
        // GET: Poke
        public async Task<ActionResult> Index()
        {
            var logic = new PokeLogic();

            var json = await logic.Pikachu();

            var pikachu = JsonConvert.DeserializeObject<Pokemon>(json);

            return View(pikachu);
        }

        
    }
}