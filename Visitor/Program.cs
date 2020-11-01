using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayer physicalPlayer = new PhysicalPlayer();
            BasePlayer magicalPlayer = new MagicalPlayer();

            BaseMonster flea = new Flea();
            BaseMonster bat = new Bat();
            physicalPlayer.Attack(flea);
            physicalPlayer.Attack(bat);

            Console.WriteLine();

            magicalPlayer.Attack(flea);
            magicalPlayer.Attack(bat);
            
        }
    }
}
