using System;

namespace first
{
    class Program
    {
        static float a, b, c;

        static void Main(string[] args)
        {

            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" <{0:#.#}+{1:#.#}>+{2:#.#}={0:#.#}+<{1:#.#}+{2:#.#}>", a, b, c);
        }
    }
}
