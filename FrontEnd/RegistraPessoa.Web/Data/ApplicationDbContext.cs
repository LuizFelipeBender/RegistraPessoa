using Microsoft.EntityFrameworkCore;

namespace RegistraPessoa.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    Dbset
}
