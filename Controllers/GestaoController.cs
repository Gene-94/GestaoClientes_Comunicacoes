using Microsoft.AspNetCore.Mvc;

namespace Trabalho_Final.Controllers
{
    public class GestaoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Clientes()
        {
            return View();
        }

        public async Task<IActionResult> Cartoes()
        {
            return View();
        }

        public async Task<IActionResult> Cliente(int id)
        {
            //.../Gestao/Cliente?id=23
            return View();
        }
    }
}
