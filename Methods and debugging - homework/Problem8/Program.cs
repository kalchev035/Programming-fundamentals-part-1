using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());
            double firstPointDist = 0;
            double secondPointDist = 0;
            firstPointDist = Math.Sqrt(Math.Pow(firstPointX, 2) + Math.Pow(firstPointY, 2));
            secondPointDist = Math.Sqrt(Math.Pow(secondPointX, 2) + Math.Pow(secondPointY, 2));
            if (firstPointDist <= secondPointDist)
            {
                Console.WriteLine("(" + firstPointX + ", " + firstPointY + ")");
            }
            else if (firstPointDist > secondPointDist)
            {
                Console.WriteLine("(" + secondPointX + ", " + secondPointY + ")");
            }
        }
    }
}
