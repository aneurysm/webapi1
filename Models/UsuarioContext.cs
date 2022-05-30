using Microsoft.EntityFrameworkCore;

namespace UsuariosApi.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options): base(options){}

        public DbSet<Usuario> Usuarios { get; set; }

    }
}