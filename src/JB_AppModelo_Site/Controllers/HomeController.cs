using JB_AppModelo_Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace JB_AppModelo_Site.Controllers
{
    public class HomeController : Controller 
    {

        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View();
        }
    }
}
