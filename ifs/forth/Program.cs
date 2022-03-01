using System;


namespace third
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
            if ((x <= -3 && x >= 2) || (y <= -1 && y >= 2))
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
