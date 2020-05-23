using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class Factorial
    {
        public static void Init(int n)
        {
            int f = 1;
            for (int i = n; i > 1; i--)
            {
                f *= i;
            }

            Console.WriteLine(f);
        }
    }
}
