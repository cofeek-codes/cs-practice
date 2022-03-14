using System;
using System.IO;
using System.Text;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            FileStream any = new FileStream("any.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamReader reader = new StreamReader(any))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    i++;
                    reader.ReadLine();
                }
                any.Position = 0;
                string[] line = new string[i];
                for (int k = 0; k < i; k++)
                {
                    line[i] = reader.ReadLine();
                    char[] chars = line[i].ToCharArray();
                    for (int f = 0; f < chars.Length; f++)
                    {
                        counter++;
                    }
                    if (counter > max)
                    {
                        max = counter;
                    }
                }


            }
        }
    }
}
