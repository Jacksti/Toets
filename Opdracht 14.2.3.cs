using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void SECONDENNAARUREN(int Totaalseconden, out int Uren, out int Minuten, out int Seconden)
        {
            const int SECONDENPERMINUUT = 60;
            const int SECONDENPERUUR = 3600;

            Minuten = Totaalseconden / SECONDENPERMINUUT;
            Seconden = Totaalseconden % SECONDENPERMINUUT;
            Uren = Minuten / SECONDENPERUUR;
            Minuten = Minuten % SECONDENPERUUR;




        }
        static void Main(string[] args)
        {
            Console.WriteLine("Voer het aantal seconden in:");
            int Totaalseconden = int.Parse(Console.ReadLine());
            int Uren, Minuten, Seconden;
            SECONDENNAARUREN(Totaalseconden, out Uren, out Minuten, out Seconden);
            Console.WriteLine("Dit is omgerekend: {0} uren, {1} minuten en {2} seconden.", Uren, Minuten, Seconden);
            Console.ReadLine();


        }
    }
}
