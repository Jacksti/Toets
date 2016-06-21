using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BTW_PERCENTAGE = 0.19;

            int Prijs = int.Parse(Console.ReadLine());
            double BTW = Prijs * BTW_PERCENTAGE;
            double Prijsbtw = Prijs + BTW;
            Console.WriteLine("De prijs is: " + Prijs);
            Console.WriteLine("De BTW is: " + BTW);
            Console.WriteLine("Het totaal is: " + Prijsbtw);
            Console.ReadLine();
            
        }
    }
}
