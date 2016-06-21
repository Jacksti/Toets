using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je score: ");
            int score = int.Parse(Console.ReadLine());

            char cijfer;

            if (score > 90)
                cijfer = 'A';
            else if (score > 80)
                cijfer = 'B';
            else if (score > 70)
                cijfer = 'C';
            else if (score > 60)
                cijfer = 'B';
            else
                cijfer = 'F';

            Console.WriteLine("Je letter is: " + cijfer);

            if (cijfer.Equals('A') || cijfer.Equals('B') || cijfer.Equals('C'))
                Console.WriteLine("GESLAAGD");
            else
                Console.WriteLine("GEZAKT");

            Console.ReadLine();


                
        }
    }
}
