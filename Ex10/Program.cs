using System;
using System.Linq;

namespace Ex10
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] mark = new int[2,10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mark[i, j] = int.Parse(Console.ReadLine());
                }
            }
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < 10; i++)
            {
                sum1 += mark[0, i];
                sum2 += mark[1, i];
            }
            Console.WriteLine($"Average for group 1 is: {sum1 / 10}");
            Console.WriteLine($"Average for group 2 is: {sum2 / 10}");
        }
    }
}
