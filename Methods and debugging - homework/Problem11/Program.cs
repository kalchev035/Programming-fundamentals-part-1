using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            string instruction = Console.ReadLine();
            if (instruction == "triangle") {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(((side*height)/2).ToString("F"));
            }
            else if (instruction == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine((side*side).ToString("F"));
            }
            else if (instruction == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine((width*height).ToString("F"));
            }
            else if (instruction == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine((Math.PI*radius*radius).ToString("F"));
            }
        }
    }
}
