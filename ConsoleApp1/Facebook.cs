using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Facebook
    {

        public Admin admin { get; set; }
        public List<User> users{ get; set; }
        public List<Post> generalposts { get; set; }

        // => Constructor of Facebook
        public Facebook(Admin admin, List<User> users, List<Post> generalposts)
        {
            this.admin = admin;
            this.users = users;
            this.generalposts = generalposts;
        }

        // +> start
        public void start() {// function scope
            // +> Asking user or admin ?
            ConsoleKeyInfo key;
            while (true) {// 1st while
                Console.Clear();
                Console.WriteLine("[1] - Admin");
                Console.WriteLine("[2] - User");
                Console.Write("Choice here...");
                key = Console.ReadKey();
                // +> admin
                if (key.Key == ConsoleKey.D1)
                {
                    while (true)
                    {// 2nd while
                        Console.Clear();
                        // +> It is admin
                        if (admin.IsAdmin())
                        {
                            Console.Clear();
                            Console.WriteLine("Access is successful");
                            Thread.Sleep(2000);
                        }
                        // +> It is not
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("username(or email) or password is wrong try again !");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("[1] - Back");
                        Console.WriteLine("Any key to continue...");
                        Console.Write("Choice here...");
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.D1)
                            break;
                    }// 2nd while

                }

                // +> user
                else if (key.Key == ConsoleKey.D2) {// function scope
                    int userindex = 0;
                    bool exist = false;
                    while (true)
                    {// 1st while
                        Console.Clear();
                        string? emailname;
                        Console.Write("Enter username(or email): ");
                        emailname = Console.ReadLine();

                        string? password;
                        Console.Write("Enter password: ");
                        password = Console.ReadLine();

                        // +> Looping through users
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].IsUser(emailname, password))
                            {
                                userindex = i;
                                exist = true;
                                break;
                            }
                        }
                        if (exist)
                        {
                            while (true)
                            {// 2nd while
                                Console.Clear();
                                Console.WriteLine($"Welcome {users[userindex].Name} {users[userindex].Surname} to Facebook");
                                Console.WriteLine("[1] - See Posts");
                                Console.WriteLine("Any key to back");
                                Console.Write("Choice here...");
                                key = Console.ReadKey();

                                if (key.Key == ConsoleKey.D1)
                                {
                                    Console.Clear();
                                    for (int i = 0; i < generalposts.Count; i++) {
                                        while (true)
                                        {// 3rd while
                                            Console.Clear();
                                            Console.WriteLine(generalposts[i].ToString());
                                            Console.WriteLine("[1] - Like");
                                            Console.WriteLine("[2] - Next");
                                            Console.WriteLine("[3] - Back");
                                            Console.WriteLine("[4] - Exit");
                                            Console.Write("Choice here...");
                                            key = Console.ReadKey();

                                            // like
                                            if (key.Key == ConsoleKey.D1)
                                            {

                                            }

                                            // next
                                            else if (key.Key == ConsoleKey.D2)
                                            {
                                                if (i == generalposts.Count - 1)
                                                {
                                                    i = -1;
                                                }
                                                break;
                                            }

                                            // back
                                            else if (key.Key == ConsoleKey.D3)
                                            {
                                                if (i == 0)
                                                {
                                                    i = -1;
                                                    break;
                                                }
                                                else
                                                {
                                                    i -= 2;
                                                    break;
                                                }
                                            }

                                            // exit
                                            else if (key.Key == ConsoleKey.D4) 
                                            {
                                                i = generalposts.Count - 1;
                                                break;
                                            }

                                        }// 3rd while
                                    }
                                }
                                else
                                    break;

                            }// 2nd while
                        }
                        else {
                            Console.Clear();
                            Console.WriteLine("User not found ! Try again !");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("[1] - Back");
                        Console.WriteLine("Any key to continue...");
                        Console.Write("Choice here...");
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.D1)
                            break;
                    }// 1st while
                }// function scope
            
            
            
            }// 1st while
        
        
        
        
        }// function scope







    }
}
