using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePerFlap = double.Parse(Console.ReadLine()) / 1000;
            int endurance = int.Parse(Console.ReadLine());
            int restTime = wingFlaps / endurance * 5;
            int time = (wingFlaps / 100) + restTime;
            double distance = wingFlaps * distancePerFlap;
            Console.WriteLine("{0} m.", String.Format("{0:0.00}", distance));
            Console.WriteLine("{0} s.", time);
        }
    }
}