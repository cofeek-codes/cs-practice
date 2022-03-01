using System;

namespace fifth
{
    class Program
    {
        static int x, y, f;
        static void Read()
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Read();
            if ((x <= -2 && x >= 1) || (y <= -1 && y >= 1))
            {
                f = 0;
            }
            else
            {
                f = 1;
            }
            Console.WriteLine("Флаг: {0}", f);
        }
    }
}
