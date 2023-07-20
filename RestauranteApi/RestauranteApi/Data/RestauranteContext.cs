using Microsoft.EntityFrameworkCore;
using RestauranteApi.Models;

namespace RestauranteApi.Data;

public class RestauranteContext : DbContext
{
    public RestauranteContext(DbContextOptions<RestauranteContext> opts) : base(opts)
    {
    }

    public DbSet<Cliente> Clientes{ get; set; }
}
