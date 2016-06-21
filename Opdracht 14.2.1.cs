using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._2._1
{
    class Program
    {
        static double VraagGebrokenGetal()
        {
            Console.WriteLine("Voer een gebroken getal in: ");
            double gebrokengetal = double.Parse(Console.ReadLine());
            return gebrokengetal;
        }

        static double BerekenBTW(double poep)
        {
            const double BTW_PERCENTAGE = 0.19;
            double btw = poep * BTW_PERCENTAGE;
            return btw;        
        }
        static void Main(string[] args)
        {
            double prijs = VraagGebrokenGetal();
            double btw = BerekenBTW(prijs);
            Console.WriteLine("De prijs is: " + prijs);
            Console.WriteLine("De BTW is: " + btw);
            Console.WriteLine("Het totaal is: " + (prijs + btw));
            Console.ReadLine();
        }
    }
}
