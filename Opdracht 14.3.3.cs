using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal1: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Getal2: ");
            int getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Getal3: ");
            int getal3 = int.Parse(Console.ReadLine());

            if(getal1 + getal2 > getal3)
            {
                Console.WriteLine("Getal1 en 2 zijn groter dan 3");
            }

            else
            {
                Console.WriteLine("Getal1 en 2 zijn kleiner dan 3");
            }

            Console.ReadLine();

        }
    }
}
