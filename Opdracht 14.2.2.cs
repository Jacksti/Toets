using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._2._2
{
    class Program
    {
        static double BerekenSom(double getal1, double getal2, double getal3)
        {
            double som = getal1 + getal2 + getal3;
            return som;

      
        }

        static double BerekenGemiddelde(double getal)
        {
            double gemiddelde = getal / 3;
            return gemiddelde;
            
        }

        static double VraagGebrokenGetal()
        {
            Console.WriteLine("Voer een gebroken getal in.");
            double GebrokenGetal = double.Parse(Console.ReadLine());
            return GebrokenGetal;
        }

        static void Main(string[] args)
        {
            double getal1 = VraagGebrokenGetal();
            double getal2 = VraagGebrokenGetal();
            double getal3 = VraagGebrokenGetal();

            double som = BerekenSom(getal1, getal2, getal3);
            double gemiddelde = BerekenGemiddelde(som);
            Console.WriteLine("Het gemiddelde is: " + gemiddelde);
            Console.ReadLine();
            
        }
    }
}
