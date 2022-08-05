using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pedidos.Controllers {
    public class MapasController : Controller {
        
        public ActionResult EstadosRepublicas() {
            return View();
        }
    }
}
