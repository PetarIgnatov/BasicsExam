using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());
            double rakiaPrice = whiskeyPrice * 0.50;
            double winePrice = rakiaPrice * 0.60;
            double beerPrice = rakiaPrice * 0.20;
            double total = rakiaPrice * rakia + wine * winePrice + beer * beerPrice + whiskeyPrice * whiskey;

            Console.WriteLine("{0:f2}",total);

        }
    }
}
