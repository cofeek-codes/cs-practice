using System;

namespace eight
{
    class Program
    {
        static string name;
        static int age;
        const int todayDate = 2020;
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0}, ты родился в {1} году", name, (todayDate - age));

        }
    }
}
