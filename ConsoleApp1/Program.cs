using ConsoleApp1;
using System.Collections.Generic;
internal class Program {
    static void Main(string[] args)
    {
        // +> Posts of admin
        Post p1 = new Post("Just tried a new recipe for dinner and it was a huge success! Who else loves experimenting with new dishes in the kitchen?", new DateTime(2021, 3, 4), 0, 0);
        Post p2 = new Post("Feeling grateful for all the amazing people in my life who support and uplift me. You know who you are. ❤️", new DateTime(2021, 11,5), 0, 0);
        Post p3 = new Post("Can't believe it's already May! What's everyone looking forward to this month?", new DateTime(2020, 3, 4), 0, 0);
        Post p4 = new Post("Spent the weekend exploring a new hiking trail and the views were absolutely breathtaking. Highly recommend checking it out if you're in the area! 🌲⛰️", new DateTime(2022, 12, 6), 0, 0);
        Post p5 = new Post("Sometimes the smallest things can bring the greatest joy. Today, I'm thankful for sunshine, good coffee, and the company of loved ones. ☀️☕❤️", new DateTime(2021, 1, 2), 0, 0);

        List<Post> Posts = new List<Post> { p1, p2, p3, p4, p5 };

        // +> Notifications of admin
        Notification n1 = new Notification("John just tagged you in a photo!", new DateTime(2023, 1, 20), "Jhon");
        Notification n2 = new Notification("Tom just mentioned you in a comment: 'Thanks for the recommendation, Admin!'", new DateTime(2023, 5, 4), "Tom");
        Notification n3 = new Notification("Lisa just invited you to join the group 'Book Lovers United'.", new DateTime(2023, 2, 12), "Lisa");
        Notification n4 = new Notification("David just reacted to your post: '😂'", new DateTime(2023, 5, 2), "David");
        Notification n5 = new Notification("Your friend Ashley just went live in the 'Cooking Adventures' group.", new DateTime(2023, 3, 14), "Ashley");

        List<Notification> Notifications = new List<Notification> { n1, n2, n3, n4, n5 };


        // +> users 
        User u1 = new User("Hikmet", "Eminli", "eminli2004@gmail.com", "HikoBaba@12");
        User u2 = new User("Elgun", "Haqverdiyev", "novruzluqyds20@gmail.com", "Elgun45");
        User u3 = new User("Fazil", "Donmezov", "donmez90@gmail.com", "Fazil90");
        User u4 = new User("Nazim", "Nazimli", "Nazim2004@gmail.com", "Nazim1290");
        User u5 = new User("Cemil", "Selimli", "selim2004@gmail.com", "Selim1234");

        List<User> users = new List<User> { u1, u2, u3, u4, u5 };

        // +> admin
        Admin admin = new Admin("Admin", "admin2004@gmail.com", "admin2004", Posts, Notifications);

        // +> general posts
        Post gp1 = new Post("Just finished my first half marathon! It was tough, but crossing that finish line was such an incredible feeling. Big thanks to all my friends and family for cheering me on along the way!", new DateTime(2023, 2, 13), 0, 0);
        Post gp2 = new Post("Can't believe it's already been a year since I adopted my sweet pup. He's brought so much love and joy into my life. Happy gotcha day to my furry best friend!", new DateTime(2023, 2, 23), 0, 0);
        Post gp3 = new Post("Feeling frustrated with all the negativity and hate in the world lately. It's so important to remember that kindness and compassion can go a long way. Let's all try to spread a little more love today.", new DateTime(2023, 5, 24), 0, 0);

        List<Post> generalposts = new List<Post> { gp1, gp2, gp3 };

        // +> FaceBook
        Facebook facebook = new Facebook(admin, users, generalposts);

        facebook.start();
    }
}