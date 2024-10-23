using MicroserviciosPerros.Bussines.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroserviciosPerros.Data
{
    public class AppDBContext:DbContext
    {

        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) { }

        /*Registrar las entidades*/
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Autoincrement*/
            modelBuilder.Entity<Dog>()
               .Property(x => x.Id)
               .ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
    }
}
