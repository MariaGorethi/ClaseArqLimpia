using System.Text.Json.Serialization;

namespace Practica_Gorethi.Bussines.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nacionality { get; set; }
         
        public Autor(int id, string name, string nacionality)
        {
            Id = id;
            Name = name;
            Nacionality = nacionality;
        }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; }
    }
}
