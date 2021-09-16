using System;

namespace Ex15
{
    class Program
    {

        static void Double(ref int num)
        {
            num *= 2;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Double(ref num);
            Console.WriteLine(num);
        }
    }
}
