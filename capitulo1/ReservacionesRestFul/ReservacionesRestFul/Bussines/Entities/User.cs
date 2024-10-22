using System.CodeDom;
using System.Text.Json.Serialization;

namespace ReservacionesRestFul.Bussines.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }

        public User(int id, string name, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;  
        }
        public User() { }



    }
}
