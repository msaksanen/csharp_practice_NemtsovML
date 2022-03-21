using System;

namespace _7.Task2
{
    class Program
    {
        static void Main()
        {
            Object[] num = new Object[3];
            int n = 32;
            char a = 'A';
            string st = "Hello";
            num[0] = n;
            num[1] = a;
            num[2] = st;
            foreach (object item in num)
            {
                Console.WriteLine(item);
            }

            num[0] = n + 10;
            num[2] = st + ", guys!";

            foreach (object item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
