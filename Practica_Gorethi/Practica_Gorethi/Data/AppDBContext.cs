using Microsoft.EntityFrameworkCore;
using Practica_Gorethi.Bussines.Entities;

namespace Practica_Gorethi.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Se puede hacer desde aqui
            //optionsBuilder.UseMySQL("server=localhost:port=3306");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
               .Property(x => x.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Book>()
               .Property(x => x.IdBook)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Autor>()
                .HasMany(t => t.Books)
                .WithOne(t => t.Autor)
                .HasForeignKey(t => t.AutorId);
            base.OnModelCreating(modelBuilder);
        }

    }
}
