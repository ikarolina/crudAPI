using crudApi.Model;
using Microsoft.EntityFrameworkCore;

namespace  crudApi.Repository
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}