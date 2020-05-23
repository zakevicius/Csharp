using System;

namespace Learn
{
    class MaxFinderPlus
    {
        public static void Init()
        {
            int max = 0;

            Console.WriteLine("Enter the numbers separated by comma");
            
            foreach (char item in Console.ReadLine())
            {
                int num = (int) char.GetNumericValue(item);
                if (num == -1) continue;
                max = Math.Max(max, num);
            }

            Console.WriteLine(max);
        }
    }
}
