using System;
using System.IO;
using System.Text;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream numbers = new FileStream("numbers.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter writer = new StreamWriter(numbers))
            {
                for (int i = 0; i < 500; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}

