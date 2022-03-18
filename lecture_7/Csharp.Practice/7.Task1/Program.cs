using System;

namespace _7.Task1
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            int?[] numr = new int?[n];  //Only nullable types. Non-nullable value types cannot be converted (see screenshot).
            for (int i = 0; i < n; i++)
            {
                numr[i] = null;
                Console.WriteLine($"Item{i} " + numr[i]);
            }
        }
    }
}
