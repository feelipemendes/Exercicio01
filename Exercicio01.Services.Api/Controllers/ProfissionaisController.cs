using Microsoft.AspNetCore.Mvc;

namespace Exercicio01.Services.Api.Controllers
{
    public class ProfissionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
