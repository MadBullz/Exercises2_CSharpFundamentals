using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 500; i++)
            {
                if (i % 15 == 0) Console.Write(i+" ");
            }
        }
    }
}
