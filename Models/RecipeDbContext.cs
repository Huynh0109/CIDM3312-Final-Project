using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final_Project.Models
{
  public class RecipeDbContext : DbContext
  {
    public RecipeDbContext (DbContextOptions<RecipeDbContext> options)
              : base(options)
            {
            }
            public DbSet<User> Users { get; set; } = default!;
            public DbSet<Recipe> Recipes { get; set; } = default!;
            public DbSet<Tag> Tags { get; set; } = default!;
            public DbSet<Category> Categories { get; set; } = default!;
  }
}