using System;
using System.Collections.Generic;
using System.Text;

namespace First
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
