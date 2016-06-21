using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer getal in");
            int getal = int.Parse(Console.ReadLine());
            int aantalgetallen = 0;
            int som = 0;

            while (getal != 0)
            {
                if (aantalgetallen % 5 == 0)
                {
                    som = som + getal;
                    aantalgetallen = aantalgetallen + 1;
                }

                Console.WriteLine("HOI: " + som);
                Console.ReadLine();
            }
        }
    }
}
