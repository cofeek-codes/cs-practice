using System;

namespace first
{
    class Program
    {
        static int a, b, c, f;
        static void Read()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Read();
            if (a < b + c && b < a + c && c < a + b)
            {
                f = 1;
            }
            else
            {
                f = 0;
            }
            Console.WriteLine("Флаг: {0}", f);
        }

    }
}
