using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class DivisibleByThree
    {
        public static void CountDivisibleByThree(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0) count++;
            }

            Console.WriteLine(count);
        }
    }
}
