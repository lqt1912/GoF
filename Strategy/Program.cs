using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.GoWithVehicle();

            car.SetVehicle(new GoFlying());
            car.GoWithVehicle();
            Console.WriteLine();
        }
    }
}
