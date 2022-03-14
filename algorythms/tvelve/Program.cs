using System;

namespace tvelve
{
    class Program
    {
        static double x1, y1, x2, y2, r, r1, sum, answer;
        static void Read()
        {
            Console.Write("Введите координаты точки x1= ");
            x1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите координаты точки x2= ");
            x2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите координаты точки y1= ");
            y1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите координаты точки y2= ");
            y2 = Convert.ToSingle(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Read();
            r = Math.Pow((x2 - x1), 2);
            r1 = Math.Pow((y2 - y1), 2);
            sum = r + r1;
            answer = Math.Pow(sum, 2);
            Console.WriteLine("Расстояние между точками= {0:##.###}");


        }
    }
}
