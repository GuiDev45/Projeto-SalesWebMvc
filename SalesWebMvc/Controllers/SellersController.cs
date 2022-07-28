﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); //Vai retornar uma lista de Seller
            return View(list); //Passando essa lista como argumento
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel); //Quando a tela de cadastro for acionada pela primeira vez vai retornar esse objeto,
                                    //com os departments populados
        }
        
        [HttpPost] //Anotação para ação de post
        [ValidateAntiForgeryToken] //Previnir ataques CSRF
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller); //Inserir no banco de dados
            return RedirectToAction(nameof(Index)); //Redirecionando para ação Index, é a ação que vai mostrar novamente a tela princípal
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value); //Pegar o valor do id caso exista, tem que ser Value

            //Se esse id não existir
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
