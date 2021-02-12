using Microsoft.EntityFrameworkCore;

namespace Web_api_EF_in_memory.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
         : base(options)
        { }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
