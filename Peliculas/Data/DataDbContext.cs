using Microsoft.EntityFrameworkCore;
using Peliculas.Models;

namespace Peliculas.Data
{
    public class DataDbContext : DbContext
    {
     public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

     public DbSet<Category> Category { get; set; }

    }
 
}
