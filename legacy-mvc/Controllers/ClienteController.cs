using System.Web.Mvc;
using legacy_mvc.Models;

namespace legacy_mvc.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            var model = new Cliente { Nome = "João" };
            return View(model);
        }
    }
}
