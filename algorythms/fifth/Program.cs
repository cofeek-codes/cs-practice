using System;

namespace fifth
{
    class Program
    {
        static int c, nom;

        static void Main(string[] args)
        {
            Console.Write("Номинал купюры= ");
            nom = Convert.ToInt32(Console.ReadLine());

            Console.Write("Количество купюр= ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма денег={0:C2}", (nom * c));

        }
    }
}
