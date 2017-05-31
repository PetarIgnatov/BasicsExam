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
            int sum = specialNumber;

            for (int a = n; a >= 1; a--)
            {
                for (int b = m; b >= 1; b--)
                {
                    for (int c = l; c >= 1; c--)
                    {
                        int newNumber = Convert.ToInt32(string.Format("{0}{1}{2}", a, b, c));

                        if (newNumber % 3 == 0)
                        {
                            sum += 5;
                        }
                        else if (newNumber % 10 == 5 )
                        {
                            sum -= 2;
                        }
                        else if (newNumber % 2 == 0)
                        {
                            sum *= 2;
                        }

                        if (sum >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", sum);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No! {0} is the last reached special number.", sum);
        }
    }
}
