using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("LEG RICHTGETAL OP MIJN MOENDEJE");
           int richtgetal = int.Parse(Console.ReadLine());
           Console.WriteLine("VOER GETALLEN IN");
           int getal = int.Parse(Console.ReadLine());
           int aantalrichtgetallen = 0;

            while (getal != 0)
            {
                if (getal == richtgetal)
                    aantalrichtgetallen = aantalrichtgetallen + 1;

                Console.WriteLine("EN NOG MEER GETALLEN");
                getal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("HIER IS HET AANTAL GETALLEN " + aantalrichtgetallen);
            Console.ReadLine();
        }
    }
}
