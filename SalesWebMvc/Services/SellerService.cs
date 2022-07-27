using SalesWebMvc.Data;
using SalesWebMvc.Models;

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
    }
}
