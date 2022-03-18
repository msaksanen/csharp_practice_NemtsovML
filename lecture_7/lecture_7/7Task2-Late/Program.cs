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

            num[0] =(int) (num[0]) + 10;
            num[2] = (string) (num[2]) + ", guys!";

            foreach (object item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
