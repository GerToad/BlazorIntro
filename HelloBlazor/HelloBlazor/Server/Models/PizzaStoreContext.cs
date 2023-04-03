using Microsoft.EntityFrameworkCore;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Models
{
    public class PizzaStoreContext
    {
    }
}
public class PizzaStoreContext : DbContext
{
    public DbSet<PizzaSpecial> Specials { get; set; }
    public PizzaStoreContext(DbContextOptions options)
    : base(options)
    {
    }
}
