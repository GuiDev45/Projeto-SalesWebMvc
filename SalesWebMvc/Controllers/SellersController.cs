using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); //Vai retornar uma lista de Seller
            return View(list); //Passando essa lista como argumento
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost] //Anotação para ação de post
        [ValidateAntiForgeryToken] //Previnir ataques CSRF
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller); //Inserir no banco de dados
            return RedirectToAction(nameof(Index)); //Redirecionando para ação Index, é a ação que vai mostrar novamente a tela princípal
        }
    }
}
