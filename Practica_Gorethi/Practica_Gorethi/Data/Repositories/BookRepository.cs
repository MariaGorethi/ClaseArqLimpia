using Practica_Gorethi.Bussines.Entities;

namespace Practica_Gorethi.Data.Repositories
{
    public class BookRepository
    {
        private readonly AppDBContext _dbContext;

        public BookRepository(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Book book) {
            _dbContext.Add(book);
            var result = _dbContext.SaveChanges();
            return result;
        }

        public List<Book> GetAll() {
            return _dbContext.Books.ToList();
        }

        public Book GetBookAutor(string nombreautor) {
            return _dbContext.Books.Find(nombreautor);
        }
    }
}
