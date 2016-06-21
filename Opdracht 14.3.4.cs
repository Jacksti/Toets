using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._4
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

            int som = getal1 + getal2 + getal3;
            int gemiddelde = som / 3;
            int product = getal1 * getal2 * getal3;
            int grootste;
            int kleinste;

            if (getal1 > getal2 & getal1 > getal3)
                grootste = getal1;
            else if (getal2 > getal1 & getal2 > getal3)
                grootste = getal2;
            else
                grootste = getal3;

            if (getal1 < getal2 & getal1 < getal3)
                kleinste = getal1;
            else if (getal2 < getal1 & getal2 < getal3)
                kleinste = getal2;
            else
                kleinste = getal3;

            Console.WriteLine("De som is: " + som);
            Console.WriteLine("Het gemiddelde is: " + gemiddelde);
            Console.WriteLine("Het product is: " + product);
            Console.WriteLine("Het grootste is: " + grootste);
            Console.WriteLine("Het kleinste is: " + kleinste);

            Console.ReadLine();
        }
    }
}
