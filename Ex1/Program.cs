using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (min < max)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.Write($"{i * i - 2 * i + 1} ");
                }
            }

        }
    }
}
