using JB_AppModelo_Site.Models;
using Microsoft.EntityFrameworkCore;

namespace JB_AppModelo_Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
