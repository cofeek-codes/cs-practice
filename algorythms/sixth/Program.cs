using System;

namespace sixth
{
    class Program
    {
        static float sum, per;
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада= ");
            sum = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите процент по вкладу= ");
            per = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Через год начислят {0:C3}", (sum * per / 100));
        }
    }
}
