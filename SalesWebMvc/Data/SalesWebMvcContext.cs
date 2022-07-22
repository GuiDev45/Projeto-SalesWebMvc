using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    //EntityFrameWork é a ferramenta de mapeamento objeto relacional para acesso a dados no banco de dados,
    //e esse EntityFrameWork tabalha com a classe DbContext, e esse SalesWebMvcContext é o contexto desse projeto.
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
    }
}
