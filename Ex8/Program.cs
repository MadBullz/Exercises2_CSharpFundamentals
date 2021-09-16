using System;
using System.Linq;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(a.Contains(num) ? $"The number {num} exist" : $"The number {num} does not exist");
        }
    }
}
