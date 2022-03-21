using System;

namespace _7.Task3
{
    class Program
    {
        static void Main()
        {
            int n = 13;
            Random rnd = new Random();
            int max;
            int[] numr = new int[n]; //random array
            for (int i = 0; i < n ; i++)
            {
                numr[i] = rnd.Next(0, 100);
                Console.WriteLine($"Item [{i}] is: {numr[i]}");
            }

            max = numr[0];

            for (int i = 0; i <n ; i++)
            {
                if  (max < numr[i]) max = numr[i];
            }
            Console.WriteLine($"Max is: {max}");
        }
    }
}
