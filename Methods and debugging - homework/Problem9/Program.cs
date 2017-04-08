using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());
            double thirdPointX = double.Parse(Console.ReadLine());
            double thirdPointY = double.Parse(Console.ReadLine());
            double fourthPointX = double.Parse(Console.ReadLine());
            double fourthPointY = double.Parse(Console.ReadLine());

            double firstLine = 0;
            double secondLine = 0;

            double firstPointDist = 0;
            double secondPointDist = 0;
            double thirdPointDist = 0;
            double fourthPointDist = 0;

            firstLine = Math.Sqrt((firstPointY - firstPointX)*(firstPointY - firstPointX)) + ((secondPointY - secondPointX)*(secondPointY - secondPointX));
            secondLine = Math.Sqrt((thirdPointY - thirdPointX)*(thirdPointY - thirdPointX)) + ((fourthPointY - fourthPointX)*(fourthPointY - fourthPointX));

            if (firstLine >= secondLine)
            {
                firstPointDist = Math.Sqrt(Math.Pow(firstPointX, 2) + Math.Pow(firstPointY, 2));
                secondPointDist = Math.Sqrt(Math.Pow(secondPointX, 2) + Math.Pow(secondPointY, 2));
                if (firstPointDist <= secondPointDist)
                {
                    Console.WriteLine("(" + firstPointX + ", " + firstPointY + ")" + "(" + secondPointX + ", " + secondPointY + ")");
                }
                else if (firstPointDist > secondPointDist)
                {
                    Console.WriteLine("(" + secondPointX + ", " + secondPointY + ")" + "(" + firstPointX + ", " + firstPointY + ")");
                }
            }

            else
            {
                thirdPointDist = Math.Sqrt(Math.Pow(thirdPointX, 2) + Math.Pow(thirdPointY, 2));
                fourthPointDist = Math.Sqrt(Math.Pow(fourthPointX, 2) + Math.Pow(fourthPointY, 2));
                if (thirdPointDist <= fourthPointDist)
                {
                    Console.WriteLine("(" + thirdPointX + ", " + thirdPointY + ")" + "(" + fourthPointX + ", " + fourthPointY + ")");
                }
                else if (thirdPointDist > fourthPointDist)
                {
                    Console.WriteLine("(" + fourthPointX + ", " + fourthPointY + ")" + "(" + thirdPointX + ", " + thirdPointY + ")");
                }
            }
        }
    }
}
