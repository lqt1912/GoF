using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILaptop gamingLaptop = new GamingLaptop();
            ILaptop officeLaptop = new OfficeLaptop();

            Console.WriteLine(gamingLaptop.UpgradeLaptop());
            Console.WriteLine(officeLaptop.UpgradeLaptop());

            Console.WriteLine();
            Console.WriteLine("Laptop decorator here ..");
            Console.WriteLine();
            KeyboardModDecorator keyboardModDecorator = new KeyboardModDecorator(gamingLaptop);
            Console.WriteLine(keyboardModDecorator.UpgradeLaptop());

            SoundModDecorator soundModDecorator = new SoundModDecorator(officeLaptop);
            Console.WriteLine(soundModDecorator.UpgradeLaptop());

            Console.WriteLine();
            Console.WriteLine("Upgrade Keyboard for officelaptop");
            SoundModDecorator soundModDecorator1 = new SoundModDecorator(keyboardModDecorator);
            Console.WriteLine(soundModDecorator1.UpgradeLaptop());

        }
    }
}
