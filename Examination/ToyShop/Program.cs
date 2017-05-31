using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzle = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTruck = int.Parse(Console.ReadLine());

            double puzzle = numberOfPuzzle * 2.60;
            double dolls = numberOfDolls * 3.0;
            double bears = numberOfBears * 4.1;
            double minions = numberOfMinions * 8.20;
            double trucks = numberOfTruck * 2.0;
            double tax = 0.10;

            int numberOfToys = numberOfPuzzle + numberOfDolls + numberOfBears + numberOfMinions + numberOfTruck;

            double profit = puzzle + dolls + bears + minions + trucks;

            if (numberOfToys >= 50)
            {
                profit *= 0.75;
            }

            profit = profit * (1 - tax);

            if (profit >= tripPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", profit - tripPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", tripPrice - profit);
            }
        }
    }
}
