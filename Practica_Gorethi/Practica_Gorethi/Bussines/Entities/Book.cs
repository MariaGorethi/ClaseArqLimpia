using System.Text.Json.Serialization;

namespace Practica_Gorethi.Bussines.Entities
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }

        public Book(int id, string name, string description, int autorid)
        {
            IdBook = id;
            Name = name;
            Description = description;
            AutorId = autorid;
        }

        public Book()
        {
        }
    }
}
