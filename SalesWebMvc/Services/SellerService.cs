using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Retorna do banco de dados todos os vendedores
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        //Método para inserir um novo vendedor/Seller no banco de dados
        public void Insert(Seller obj)
        {
            _context.Add(obj);//Adiciona
            _context.SaveChanges();//Confirma no banco de dados
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
