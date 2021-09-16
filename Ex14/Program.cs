using System;

namespace Ex14
{
    class Program
    {

        static bool isNumber(string text)
        {
            try
            {
                double num = double.Parse(text);
                return true;
            }
            catch (Exception e) 
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isNumber("23sete4"));
        }
    }
}
