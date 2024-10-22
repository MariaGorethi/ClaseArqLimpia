using Microsoft.EntityFrameworkCore;
using ReservacionesRestFul.Bussines.Entities;

namespace ReservacionesRestFul.Data
{
    /*Esta Clase representa al contexto
     * * (Conexión a la base de datos)*/
    public class AppDBContext:DbContext
    {
        public AppDBContext(){}
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        /*Declarando entidades*/
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Se puede hacer desde aqui
            //optionsBuilder.UseMySQL("server=localhost:port=3306");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*configurando pk*/
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Room>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Reservation>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            /*Configurando FK*/
            modelBuilder.Entity<Room>()
                .HasMany(t => t.Reservations)
                .WithOne(t => t.Room)
                .HasForeignKey(t => t.RoomId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
