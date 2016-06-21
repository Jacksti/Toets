using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer getal in dan: ");
            int getal = int.Parse(Console.ReadLine());

            if (getal > 4)
            {
                Console.WriteLine("MASJEL");
            }
            else
            {
                if (getal == 1)
                    Console.WriteLine("KLAVER");
                else if (getal == 2)
                    Console.WriteLine("RUIT");
                else if (getal == 3)
                    Console.WriteLine("SCHOPPEN");
                else if (getal == 4)
                    Console.WriteLine("HARTEN");

                Console.ReadLine();
                                           
            }
        }
    }
}
