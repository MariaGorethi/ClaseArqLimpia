using Practica_Gorethi.Bussines.Entities;
using Practica_Gorethi.Data.DTO_s;

namespace Practica_Gorethi.Bussines.Services
{
    public interface IBookService
    {
        int Insert(BookDTO bookDTO);
        List<Book> GetAll();
        Book GetByAutor(string nombreautor);

    }
}
