using System;

namespace first
{
    class Program
    {
        static int a, b;

        static void Main(string[] args)
        {

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0}+{1}={1}+{0}", a, b);
        }
    }
}
