using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef jaartal (0 is stoppen): ");
            int jaartal = int.Parse(Console.ReadLine());

            while (jaartal != 0)
            {
                if (jaartal < 0)
                    Console.WriteLine("BOVEN 0 AUB ");
                else if (jaartal % 400 == 0)
                    Console.WriteLine("Het jaar {0} is een schrikkeljaar", jaartal);
                else if (jaartal % 4 == 0)
                    Console.WriteLine("Het jaar {0} is een schrikkeljaar", jaartal);
                else Console.WriteLine("Het jaar {0} is geen schrikkeljaar", jaartal);
                Console.WriteLine("Geef mij meer jaren");
                jaartal = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
