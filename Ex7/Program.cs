using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a >= 0 ? "A is positive" : "A is negative");
            Console.WriteLine(b >= 0 ? "B is positive" : "B is negative");
            Console.WriteLine(a >= 0 && b >= 0? "Both are positive" : "They are opposite");
        }
    }
}
