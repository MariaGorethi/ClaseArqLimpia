using ReservacionesRestFul.Bussines.Entities;

namespace ReservacionesRestFul.Data.Repositories
{
    public class RoomRepository
    {
        private readonly AppDBContext _dbContext;//contexto de base de datos

        //inyectar contexto de base de datos
        public RoomRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Inser(Room room) { 
            _dbContext.Rooms.Add(room);
            var result = _dbContext.SaveChanges();
            return result;
        }

        public Room FindById(int id)
        {
            var room = _dbContext.Rooms.Find(id);
            return room != null ? room :
                throw new Exception($"No existe {room}");
        }

        public int Update(Room room) { 
            var rSearch = _dbContext.Rooms.Find(room.Id);
            if (rSearch != null) { 
                _dbContext.Update(room);
                return _dbContext.SaveChanges();
            }
            throw new Exception($"No existe {room.Id}");
        }
        public List<Room> GetAvailable() { 
            return _dbContext.Rooms.Where(t =>t.Available).ToList();
        }
    
    }
}
