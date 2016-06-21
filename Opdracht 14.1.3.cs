using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer aantal seconden in:");
            int Seconden = int.Parse(Console.ReadLine());
            int Uren = Seconden / 3600;
            Seconden = Seconden - (Uren * 3600);
            int Minuten = Seconden / 60;
            Seconden = Seconden - (Minuten * 60);
            Console.WriteLine(Uren + " Uren");
            Console.WriteLine(Minuten + " Minuten");
            Console.WriteLine(Seconden + " Seconden");
            Console.ReadLine();
        }
    }
}
