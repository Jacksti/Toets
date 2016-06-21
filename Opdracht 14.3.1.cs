using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef getal 1: ");
            double getal1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal 2: ");
            double getal2 = double.Parse(Console.ReadLine());

            double grootstegetal;
            double kleinstegetal;

            if (getal1 > getal2)
            {
                grootstegetal = getal1;
                kleinstegetal = getal2;
            }
            else
            {
                kleinstegetal = getal1;
                grootstegetal = getal2;
            }
            Console.WriteLine("GROOTSTE: " + grootstegetal);
            Console.ReadLine();
            Console.WriteLine("KLEINSTE: " + kleinstegetal);
            Console.ReadLine();
        }
    }
}
