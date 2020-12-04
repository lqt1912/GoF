using System;

namespace Mediator
{
    public abstract class IUser 
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public abstract void SendMessage(string message);
    }
    public class User:IUser
    {
        public override void SendMessage(string message)
        {
            ChatRoom.SendMessageAsNormal(this, message);
        }
    }

    public class Admin : IUser
    {
        public override void SendMessage(string message)
        {
            ChatRoom.SendMessageAsAdmin(this, message);
        }
    }
    public class ChatRoom
    {
        public static void SendMessageAsNormal(IUser user, string message)
        {
            Console.WriteLine($"[{DateTime.Now}]-[ NORMAL ] [{user.Name}] : {message}");
        }

        public static void SendMessageAsAdmin(IUser user, string message)
        {
            Console.WriteLine($"[{DateTime.Now}]-[ ADMIN ][{user.Name}] : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IUser user = new Admin()
            {
                Name = "Le Quoc Thang",
                Type="ADMIN"
            };

            IUser user2 = new User()
            {
                Name = "Dang Thanh Quyen"
            };
            IUser user3 = new User()
            {
                Name = "Nguyen Duc Phuc"
            };

            user.SendMessage("Hello everybody");
            user2.SendMessage("Goodbye everyone");
            user3.SendMessage("What's up ? ");


        }
    }
}
