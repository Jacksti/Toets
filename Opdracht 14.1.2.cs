using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer eerste getal in:");
            double Getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voer tweede getal in:");
            double Getal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voer derde getal in:");
            double Getal3 = int.Parse(Console.ReadLine());
            
            double Gemiddelde = (Getal1 + Getal2 + Getal3) / 3;
            Console.WriteLine("Het gemiddelde is:" + Gemiddelde);

            Console.ReadLine();
        }
    }
}
