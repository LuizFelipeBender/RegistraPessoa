using Microsoft.EntityFrameworkCore;
using RegistraPessoa.Api.Model.Base.PessoaBase;

namespace RegistraPessoa.Api.Model.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa>? Pessoas { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}