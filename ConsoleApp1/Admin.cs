using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Admin
    {

        public static int ID { get; set; } = 0;
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Post> Posts { get; set; }
        public List<Notification> Notifications { get; set; }

        // => Constructor of `Admin` class
        public Admin(string? username, string? email, string? password, List<Post> posts, List<Notification> notifications)
        {
            Username = username;
            Email = email;
            Password = password;
            Posts = posts;
            Notifications = notifications;
        }

        // +> checking username(or email) and password
        public bool IsAdmin() {
            string? emailname;
            Console.Write("Enter username(or email): ");
            emailname = Console.ReadLine();

            string? password;
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            if (emailname == Email || emailname == Username && password == Password)
                return true;
            else
                return false;
        }

    }
}
