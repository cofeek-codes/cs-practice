using System;

namespace second
{
    class Program
    {
        static int a, b, c, d, minAB, minCD, max;
        static void Read()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
        }
        static void FirstLvlAB()
        {
            if (a < b)
            {
                minAB = a;
            }
            else
            {
                minAB = b;
            }
        }
        static void FirstLvlCD()
        {
            if (c < d)
            {
                minCD = c;
            }
            else
            {
                minCD = d;
            }
        }
        static void Main(string[] args)
        {
            Read();
            FirstLvlAB();
            FirstLvlCD();
            max = Math.Max(minAB, minCD);
            System.Console.WriteLine(max);

        }
    }
}
