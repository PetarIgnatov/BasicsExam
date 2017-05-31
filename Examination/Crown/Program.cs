using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (2 * n) - 1;
            int high = (n / 2) + 4;
            int space = (width - 9) / 2;
            int dotsInTheMiddle = 1;
            int endDots = n / 2 - 1;

            Console.WriteLine("@" + new string(' ', (width - 3) / 2) + "@" + new string(' ', (width - 3) / 2) + "@");
            Console.WriteLine("**" + new string(' ', (width - 5) / 2) + "*" + new string(' ', (width - 5) / 2) + "**");

            for (int i = 1; i <= high - 6; i++)
            {
               
                Console.WriteLine("*" + new string('.', i) + "*" + new string(' ', space)
                    + "*" + new string('.',dotsInTheMiddle) + "*" + new string(' ', space) + "*" + new string('.', i) + "*");
                space -= 2;
                dotsInTheMiddle += 2;
            }
            Console.WriteLine("*" + new string('.', endDots) + "*" + new string('.', dotsInTheMiddle) + "*" + new string('.', endDots) + "*");
            Console.WriteLine("*" + new string('.', endDots + 1) + new string('*', n / 2 - 2) + "." + new string('*', n / 2 - 2) + new string('.', endDots + 1) + "*");
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));
        }
    }
}
