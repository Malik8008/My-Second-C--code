using System;

namespace My_Third_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hasbullah", "Hardy", "Miraga", "Eli", "John" };

            foreach (string name in names)
            {
                int count = 0;
                foreach (char character in name)
                {
                    count++;
                }
                if (count > 5)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
