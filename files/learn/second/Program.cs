using System;
using System.IO;
using System.Text;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "blue", "red", "green", "white", "black" };

            FileStream col = new FileStream("colors.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter writer = new StreamWriter(col))
            {
                for (int i = 0; i < colors.Length; i++)
                {
                    writer.WriteLine(colors[i]);
                }
            }


        }
    }
}
