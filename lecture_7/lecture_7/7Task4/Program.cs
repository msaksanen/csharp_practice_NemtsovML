using System;

namespace _7Task4
{
    class Program
    {
        static void Main()
        {
            short s1 = 120;
            object o1 = s1;
            System.SByte sb = (sbyte)((short)(o1));
            System.Console.WriteLine($"Short s1={s1}  {s1.GetType()}. Sbyte sb={sb} {sb.GetType()} ");
        }
    }
}
