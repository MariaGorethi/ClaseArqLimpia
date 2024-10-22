using Practica_Gorethi.Bussines.Entities;

namespace Practica_Gorethi.Data.DTO_s
{
    public class BookDTO
    {
        public int IdBook { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
