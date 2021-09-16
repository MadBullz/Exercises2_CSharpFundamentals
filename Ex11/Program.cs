using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] c = new Car[3];
            int[] y = new int[3];
            for (int i = 0; i < c.Length; i++)
            {
                string model = Console.ReadLine();
                int anyoFabricacion = int.Parse(Console.ReadLine());
                c[i] = new Car(model, anyoFabricacion);
                y[i] = anyoFabricacion;
            }
            Array.Sort(y, c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
