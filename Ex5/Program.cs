using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = min; i <= max; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            int count = min;
            while (count <= max)
            {
                Console.Write(count++ + " ");
            }
            Console.WriteLine();
            count = min;
            do
            {
                Console.Write(count++ + " ");
            } while (count <= max);
        }
    }
}
