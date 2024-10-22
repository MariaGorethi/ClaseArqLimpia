using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SR
{//Principio 1 de una sola responsabilidad 
    public class User { 
        public string Email { get; set; }
        public string? Password { get; set; }
    }

    public class EncryptionService
    {
        public static string Encrypt(string data) {
            /*Encriptar Password*/
            var encoding = Encoding.UTF8.GetBytes(data);
            var sha256 = SHA256.HashData(encoding);
            var dataEncripted = Convert.ToHexString(sha256);
            return dataEncripted;
            /*End Encriptar Password*/
        }

    }

    public class UserRegistry
    {
        private List<User> _users = new List<User>();
        public bool Registry(User user) {
            if (user.Email.Length > 0 && user.Password.Length >=8)
            {   /*Encriptar Password*/
                var passwordEncripted = EncryptionService.Encrypt(user.Password);
                /*End Encriptar Password*/

                _users.Add(new User() {Email = user.Email, Password= passwordEncripted });
                return true;
            }
            return false;
        }

    }
}
