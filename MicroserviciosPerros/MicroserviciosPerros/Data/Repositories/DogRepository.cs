using MicroserviciosPerros.Bussines.Entities;

namespace MicroserviciosPerros.Data.Repositories
{
    public class DogRepository
    {
        private readonly AppDBContext _dbContext;
        public DogRepository(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Dog dog) { 
            _dbContext.Dogs.Add(dog);
            var result = _dbContext.SaveChanges();
            return result>0 ? result : throw new Exception($"Fallo al Insertar {dog.Name}" );
        }

        public List<Dog> GetAll() { 
            return _dbContext.Dogs.ToList();
        }

        public int Delete(int id)
        {
            var result = _dbContext.Dogs.Find(id);
            if (result!= null)
            {
                _dbContext.Dogs.Remove(result);
                return _dbContext.SaveChanges();
            }throw new Exception($"El perro no existe {id}");
        }
    }
}
