using System;
using System.Globalization;

namespace calculo_de_viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int t, v;
            double l;

            input = Console.ReadLine().Split(" ");
            t = int.Parse(input[0]);
            v = int.Parse(input[1]);

            l = t * v / 12.00;

            Console.WriteLine(l.ToString("N3", CultureInfo.InvariantCulture));
        }
    }
}
