using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberContainer nc = new NumberContainer();

            int currentIndex = 1;
            for(Iterator iter = nc.GetIterator(); iter.HasNext();)
            {
                Console.WriteLine($"Current index: {currentIndex++} : {iter.Next()}");
            }
        }
    }
}
