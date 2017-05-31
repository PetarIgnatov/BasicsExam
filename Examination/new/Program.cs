using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sumOfSpecialNumber = 0;

            for (int a = n; a >= 1; a--)
            {
                for (int b = m; b >= 1; b--)
                {
                    for (int c = l; c >= 1; c--)
                    {
                        
                        if ((a + b + c) % 3 == 0)
                        {
                            Console.WriteLine(abc);   
                        }
                       else if (c == 5 )
                       {
                           sumOfSpecialNumber -= 2;
                       }
                       else if (c % 2 == 0)
                       {
                           sumOfSpecialNumber *= 2;
                       }
                       
                       if (sumOfSpecialNumber >= controlNumber)
                       {
                          Console.WriteLine("Yes! Control number was reached! Current special number is {специалното число}.", sumOfSpecialNumber);
                           return;
                       }
                    }
                }
            }

            Console.WriteLine("No! {0} is the last reached special number.",sumOfSpecialNumber);
        }
    }
}
