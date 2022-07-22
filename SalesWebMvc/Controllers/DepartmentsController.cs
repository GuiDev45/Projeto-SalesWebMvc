using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();//Criando uma lista de Department normal
            //Adicionando alguns dados a essa lista.
            list.Add(new Department {Id = 1, Name = "Eletronics"});
            list.Add(new Department { Id = 2, Name = "Fashion" });

            //Enviando os dados da lista para View, só colocar o nome da lista no método da View.
            return View(list);
        }
    }
}
