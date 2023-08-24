using Microsoft.EntityFrameworkCore;
using PlatziEntityFramework.Model;

namespace PlatziEntityFramework
{
    public class WorkContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Work> Works { get; set; }

        public WorkContext(DbContextOptions<WorkContext> options) : base(options) { }
    }
}
