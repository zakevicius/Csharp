using System;

/*
Write a program and ask the user to enter the width and height of an image. 
Then tell if the image is landscape or portrait.
*/

namespace Learn.Conditionals
{
    class PictureOrientation
    {
        public static string DetermineOrientation(int h, int w)
        {
            return (h < w) ? "Landscape" : "Portrait";
        }

        public static void Start()
        {
            Console.WriteLine("Enter height");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DetermineOrientation(h, w));
        }
    }
}
