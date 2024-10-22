namespace Practica_Gorethi.Data.Repositories
{
    public class AutorRepository
    {
        private readonly AppDBContext _dbContext;

        public AutorRepository(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
            _dbContext.Database.EnsureCreated();
        }

        
    }
}
