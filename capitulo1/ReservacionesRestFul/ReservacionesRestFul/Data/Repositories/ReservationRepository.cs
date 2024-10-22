using Microsoft.EntityFrameworkCore;
using ReservacionesRestFul.Bussines.Entities;

namespace ReservacionesRestFul.Data.Repositories
{
    public class ReservationRepository
    {
        private readonly AppDBContext _dbContext;

        public ReservationRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Reservation reservation) { 
            _dbContext.Reservations.Add(reservation);
            var result = _dbContext.SaveChanges();
            return result;
        }

        public Reservation FindById(int id) {
            var result = _dbContext.Reservations.Find(id);
            return result != null ? result : throw new Exception($"No esxite {id} Reservacion");
        }

        public List<Reservation> GetAll() { 
            return _dbContext.Reservations
                .Include(t=> t.Room)
                .Include(t=> t.User).ToList();
        }
    }
}
