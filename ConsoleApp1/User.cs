using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {

        // => Fields of user
        public static int ID { get; set; } = 0;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; } 
        public string? Password { get; set; }

        // => Constructor of user
        public User(string? name, string? surname, string? email, string? password)
        {
            ID++;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }

    }
}
