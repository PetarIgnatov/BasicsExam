using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double price = 0.0;
            string sport = " ";

            if (typeOfGroup == "girls")
            {
                if (season == "Winter" )
                {
                    price += 9.60;
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    price += 7.20;
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    price += 15.00;
                    sport = "Volleyball";
                }
            }
            if (typeOfGroup == "boys")
            {
                if (season == "Winter")
                {
                    price += 9.60;
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    price += 7.20;
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    price += 15.00;
                    sport = "Football";
                }
            }
            if (typeOfGroup == "mixed")
            {
                if (season == "Winter")
                {
                    price += 10.00;
                    sport = "Ski";

                }
                else if (season == "Spring")
                {
                    price += 9.50;
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    price += 20.00;
                    sport = "Swimming";
                }
            }
            if (numberOfStudents >= 50)
            {
                price *= 0.50;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                price *= 0.85;
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 50)
            {
                price *= 0.95;
            }
            double totalPrice = price * numberOfNights * numberOfStudents;
            Console.WriteLine("{0} {1:f2} lv.", sport, totalPrice);
            }
        }
    }

