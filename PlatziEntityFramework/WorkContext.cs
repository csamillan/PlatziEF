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
                Category.Property(p => p.Weigth);
            });

            modelBuilder.Entity<Work>(Work =>
            {
                Work.ToTable("Work");
                Work.HasKey(p => p.WorkId);

                Work.HasOne(p => p.Category).WithMany(p => p.Works).HasForeignKey(p => p.CategoryId); //HasOne y withMany hace referencia a la coleccion creada en categoria y relacionarla con tarea para asi crear una clave foranea

                Work.Property(p => p.Title).IsRequired().HasMaxLength(200);
                Work.Property(p => p.Description).HasMaxLength(200);
                Work.Property(p => p.Priority);
                Work.Property(p => p.DateCreate);
                Work.Property(p => p.comentary).HasMaxLength(150);

                Work.Ignore(p => p.Summary); //Se utiliza cuando no qieres que un campo no lo mapee

            });
        }
    }
}
