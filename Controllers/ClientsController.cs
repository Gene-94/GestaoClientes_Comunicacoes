using Microsoft.AspNetCore.Mvc;

namespace Trabalho_Final.Controllers
{
    public class ClientsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Comprar_Cartao()
        {
            return View();
        }

        public async Task<IActionResult> Ver_Mensagens()
        {
            return View();
        }
    }
}
