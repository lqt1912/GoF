using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILaptop officeLaptop = new OfficeLaptop();

            Console.WriteLine(officeLaptop.UpgradeLaptop());

            Console.WriteLine();
            Console.WriteLine("Laptop decorator here ..");
            Console.WriteLine();
            KeyboardModDecorator keyboardModDecorator = new KeyboardModDecorator(officeLaptop);
            Console.WriteLine(keyboardModDecorator.UpgradeLaptop());
            Console.WriteLine(keyboardModDecorator.KeycapMod());
           

            Console.WriteLine();
            Console.WriteLine("Upgrade Sound for officelaptop");

            SoundModDecorator soundModDecorator1 = new SoundModDecorator(keyboardModDecorator);
            Console.WriteLine(soundModDecorator1.UpgradeLaptop());
            Console.WriteLine(soundModDecorator1.BoostSound());

        }
    }
}
