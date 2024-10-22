
using Practica_Gorethi.Bussines.Entities;
using Practica_Gorethi.Data.DTO_s;
using Practica_Gorethi.Data.Repositories;

namespace Practica_Gorethi.Bussines.Services
{
    public class BookServiceImpl : IBookService
    {
        private readonly BookRepository _bookRepository;
        private readonly AutorRepository _autorRepository;

        public BookServiceImpl(BookRepository bookRepository, AutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
            _bookRepository = bookRepository;
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetByAutor(string nombreautor)
        {
            try
            {

                return _bookRepository.GetBookAutor(nombreautor);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public int Insert(BookDTO dto)
        {
            Book books = new Book()
            {
                IdBook = dto.IdBook,
                 Name= dto.Name,
                Description = dto.Description,
                AutorId = dto.AutorId,
            };
            return _bookRepository.Insert(books);
        }
    }
}
