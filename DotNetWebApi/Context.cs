using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DotNetWebApi
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
                options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\OneDrive\Робочий стіл\Sofiia_S\DotNetWebApi\Data\DB.mdf"";Integrated Security=True");
        }

        public Context(DbContextOptions options): base(options)
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.User>().HasKey(o => new { o.Id });
            modelBuilder.Entity<Models.Project>().HasKey(o => new { o.Id });
        }

        public Context() : base()
        {
            this.Database.EnsureCreated();
        }

        public Microsoft.EntityFrameworkCore.DbSet<Models.User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Project> Products { get; set; }
    }
}
