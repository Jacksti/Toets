using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ARRAY = new int[20];
            Random random = new Random();
            double Totaal = 0;
            double Teller = 0;

            for (int index = 0; index < 20; index = index + 1)
            {
                ARRAY[index] = random.Next(0, 200);
            }

            foreach (int nummer in ARRAY)
            {
                Console.WriteLine("Element " + nummer.ToString());
                Totaal = Totaal + nummer;
                Teller = Teller + 1;
            }

            double gemiddelde;
            gemiddelde = Totaal / Teller;
            Teller = 0;

            Console.WriteLine("Gemiddelde: " + gemiddelde);

            foreach (int nummer in ARRAY)
            {
                double verschil = gemiddelde - nummer;
                verschil = Math.Abs(verschil);
                Teller = Teller + 1;
                Console.WriteLine("Het verschil met getal {0} is {1}", Teller, verschil);
            }
            Console.ReadLine();
        }
    }
}
