using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double fans = int.Parse(Console.ReadLine());
            int  sectorA = 0;
            int  sectorB = 0;
            int  sectorV = 0;
            int  sectorG = 0;

            for (int i = 0; i < fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                if (sector == 'A')
                {
                    sectorA++;
                }
                else if (sector == 'B')
                {
                    sectorB++;
                }
                else if (sector == 'V')
                {
                    sectorV++;
                }
                else if (sector == 'G')
                {
                    sectorG++;
                }
            }
            Console.WriteLine("{0:f2}%", sectorA / fans * 100);
            Console.WriteLine("{0:f2}%", sectorB / fans * 100);
            Console.WriteLine("{0:f2}%", sectorV / fans * 100);
            Console.WriteLine("{0:f2}%", sectorG / fans * 100);
            Console.WriteLine("{0:f2}%", fans / capacity * 100);
        }
    }
}
