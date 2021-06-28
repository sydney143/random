using Microsoft.EntityFrameworkCore;
namespace Random.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) :base(options) { }

        public DbSet<Recipe> Recipes {get;set;}
    }
}