using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Demo1
{
    class MainApp
    {
        static void Main()
        {
            ColorManager colormanager = new ColorManager();
            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["red"].ShowInfo();
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["red"].ShowInfo();
            colormanager["flame"] = new Color(211, 34, 20);
            colormanager["red"].ShowInfo();

            Console.WriteLine();
            Console.WriteLine("Cloning color ...");
            Console.WriteLine();

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            color1.ShowInfo();
            Color color2 = colormanager["peace"].Clone() as Color;
            color2.ShowInfo();
            Color color3 = colormanager["flame"].Clone() as Color;
            color3.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Created new color without clone ... ");
            Console.WriteLine();
            Color color4 = new Color(111, 111, 111);
            color4.ShowInfo();
            // Wait for user
            Console.ReadKey();

            //Chú ý tới chi phí khởi tạo cao (chẳng hạn 1000000000 thuộc tính)
        }
    }
}
