using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            int aantalgetallen = 0;
            int nieuwgetal;
            int gemiddelde;

            Console.WriteLine("VOER GETAL IN DAN");
            nieuwgetal = int.Parse(Console.ReadLine());

            while (nieuwgetal != 0)
            {
                totaal = totaal + nieuwgetal;
                aantalgetallen = aantalgetallen + 1;
                Console.WriteLine("VOER NOG MEER GETALLEN IN DAN");
                nieuwgetal = int.Parse(Console.ReadLine());
                
            }

            gemiddelde = totaal / aantalgetallen;
            Console.WriteLine("GEMIDDELDE: " + gemiddelde);
            Console.ReadLine();

        }
    }
}
