using System;

namespace Ex12
{
    class Program
    {

        static string changeLetter(string text, char x, int index)
        {
            return text.Replace(text[index], x);
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine(changeLetter(text, x, index));
        }
    }
}
