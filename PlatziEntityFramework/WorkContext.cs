using Microsoft.EntityFrameworkCore;
using PlatziEntityFramework.Model;

namespace PlatziEntityFramework
{
    public class WorkContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Work> Works { get; set; }

        public WorkContext(DbContextOptions<WorkContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(Category => 
            {
                Category.ToTable("Category");
                Category.HasKey(p => p.CategoryID);

                Category.Property(p => p.Name).IsRequired().HasMaxLength(150);
                Category.Property(p => p.Description);
            });

        }
    }
}
