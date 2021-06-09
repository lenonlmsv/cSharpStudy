using Microsoft.EntityFrameworkCore;

namespace _05_mvc_example_app.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localDb)\mssqllocaldb;Database=_05_mvc_example_app;Integrated Security=true");
        }
    }
}