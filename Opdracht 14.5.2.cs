using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_14._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ARRAY = new int[20];
            Random random = new Random();
            int teller = 0;
            int totaal = 0;

            for (int index = 0; index < 20; index = index + 1)
            {
                ARRAY[index] = random.Next(0, 150);
                
            }

            foreach (int nummer in ARRAY)
            {
                Console.WriteLine("Element " + nummer.ToString());
                totaal = totaal + nummer;
                teller = teller + 1;
                
            }
            
            int kleinste = ARRAY.Min();
            Console.WriteLine("De kleinste is: " + kleinste);
            
            int hoevaak = 0;
            
            foreach (int nummer in ARRAY)
            {
                if (nummer == kleinste)
                    hoevaak = hoevaak + 1;
            }
            Console.WriteLine("ZO VAAK DUS: " + hoevaak);
            Console.ReadLine();

            }            
        }
    }
