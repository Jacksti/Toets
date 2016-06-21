using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal1: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Getal2: ");
            int getal2 = int.Parse(Console.ReadLine());

            if ((getal1 % getal2) == 0)
                Console.WriteLine("JA");
            else if ((getal2 % getal1) == 0)
                Console.WriteLine("JA");
            else Console.WriteLine("NEE");

            Console.ReadLine();
        }
    }
