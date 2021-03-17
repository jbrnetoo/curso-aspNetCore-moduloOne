using Microsoft.AspNetCore.Mvc;

namespace JB_AppModelo_Site.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("Produtos")]
    public class CadastroController : Controller 
    {
        [Route("Lista")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
