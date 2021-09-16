using System;

namespace Ex13
{
    class Program
    {

        static bool isAlphabetic(string text)
        {
            return !(text.Equals(text.ToUpper()) || text.Equals(text.ToLower()));
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(isAlphabetic(text));
        }
    }
}
