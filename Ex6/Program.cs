using System;
using System.Linq;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {a.Sum()}");
            Console.WriteLine($"Median: {a.Sum()/a.Length}");
            Console.WriteLine($"Max: {a.Max()}");
            Console.WriteLine($"Min: {a.Min()}");


        }
    }
}
