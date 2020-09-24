using System;
using System.Runtime.InteropServices;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Demo 1: Image to NewImage \n ");
            Image oldImage = new Image();
            oldImage.SetImageName("testtttt.img");
            Console.WriteLine("OldImage's Name: {0}", oldImage.GetImageName());

            Console.WriteLine(" \n After adapting to NewImage ........... \n ");
            var newImage = new ImageToNewImageAdapter(oldImage);

            Console.WriteLine("NewImage's name: {0}", newImage.GetImageNameWithoutExtension()) ;
            Console.WriteLine("NewImage's extension: {0}", newImage.GetImageExtension());

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("\n Demo 2: NewImage to Image \n ");
            NewImage.NewImage newImageAngain = new NewImage.NewImage();
            newImageAngain.SetImageExtension("extension");
            newImageAngain.SetImageNameWithoutExtension("name");

            Console.WriteLine("New Image's Name: {0}, New Image's Extension: {1}", newImageAngain.GetImageNameWithoutExtension(), newImageAngain.GetImageExtension());

            Console.WriteLine(" \n After adapting to Image ........... \n ");
            var oldImageAgain = new NewImageToImageAdapter(newImageAngain);
            Console.WriteLine("old Image's Name: {0}", oldImageAgain.GetImageName());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
