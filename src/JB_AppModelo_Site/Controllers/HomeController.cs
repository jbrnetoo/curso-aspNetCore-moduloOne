using Microsoft.AspNetCore.Mvc;

namespace JB_AppModelo_Site.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
