using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("You cannot divide by 0");
                }
                else
                {
                    Console.WriteLine($"The division is {a/b}");
                    Console.WriteLine($"The rest is {a % b}");
                }
            }
        }
    }
}
