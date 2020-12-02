using System;

namespace Mediator
{
    public class User
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public void SendMessage(string message)
        {
            if(Type == "ADMIN")
                ChatRoom.SendMessageAsAdmin(this, message);
            else ChatRoom.SendMessageAsNormal(this, message);
        }

    }
    public class ChatRoom
    {
        public static void SendMessageAsNormal(User user, string message)
        {
            Console.WriteLine($"[{DateTime.Now}]-[ NORMAL ] [{user.Name}] : {message}");
        }

        public static void SendMessageAsAdmin(User user, string message)
        {
            Console.WriteLine($"[{DateTime.Now}]-[ ADMIN ][{user.Name}] : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User()
            {
                Name = "Le Quoc Thang",
                Type="ADMIN"
            };

            User user2 = new User()
            {
                Name = "Dang Thanh Quyen"
            };
            User user3 = new User()
            {
                Name = "Nguyen Duc Phuc"
            };

            user.SendMessage("Hello everybody");
            user2.SendMessage("Goodbye everyone");
            user3.SendMessage("What's up ? ");


        }
    }
}
