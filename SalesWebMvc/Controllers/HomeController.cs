using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
{
    //Todo controlador é uma subclasse de Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //IActionResult é um tipo genérico para todo resultado de uma ação, existem vários tipos específicos, olhar pdf.
        //Usar o IActionResult torna mais flexível, é melhor.
        public IActionResult Index()
        {
            return NotFound();//View é um método específico do ViewResult/IActionResult - tipo genérico.
            //Outro exemplo return NotFound(); serve para dizer que não foi encontrado, outro auxílio de resposta.
        }

        public IActionResult Privacy()//Essa ação serve apenas para a página Privacy.
        {
            ViewData["TESTE"] = "ViewData do HomeController";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}