using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine())*2;
            double eggsPrice = double.Parse(Console.ReadLine())*4;
            double berriesPrice = double.Parse(Console.ReadLine())/5;
            double doses = Math.Ceiling(guests/6);
            double receipt = doses * (bananaPrice + eggsPrice + berriesPrice);
            switch (receipt <= cash) {
                case true:
                    Console.WriteLine("Ivancho has enough money - it would cost {0}lv.", String.Format("{0:0.00}", (receipt)));
                    break;
                case false:
                    Console.WriteLine("Ivancho will have to withdraw money - he will need {0}lv more.", String.Format("{0:0.00}", (receipt - cash)));
                    break;
                default:
                    break;
            }
        }
    }
}
