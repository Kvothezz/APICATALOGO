using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        DbSet<Categoria>? Categorias { get; set; }
        DbSet<Produto>? Produtos { get; set; }

    }
}
