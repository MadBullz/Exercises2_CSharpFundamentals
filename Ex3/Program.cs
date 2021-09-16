using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Attempt #{0}", i);
                int login = int.Parse(Console.ReadLine());
                int password = int.Parse(Console.ReadLine());
                if (login == 12 && password == 1234)
                {
                    Console.WriteLine("Login successful!");
                    return;
                }
                else Console.WriteLine("Login failed\n");
            }
        }
    }
}
