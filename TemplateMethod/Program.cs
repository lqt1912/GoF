using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MakingCakeTemplate chef = new MakingGrapesCake();
            chef.GetChefInformation();
            chef.CreateCake();

            Console.WriteLine();
            chef = new MakingApplesCake();
            chef.GetChefInformation();
            chef.CreateCake();
        }
    }
}
