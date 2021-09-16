using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            int count = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                    count++;
                }
            }
            Console.WriteLine("Average numbers negatives is: "+sum/count);
            count = 0;
            sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    sum += a[i];
                    count++;
                }
            }
            Console.WriteLine("Average numbers positives is: " + sum / count);
        }
    }
}
