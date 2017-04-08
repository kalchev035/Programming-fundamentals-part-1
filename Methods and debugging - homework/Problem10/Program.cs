using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string instruction = Console.ReadLine();
            if (instruction == "face") {
                Console.WriteLine(Math.Sqrt((2*(side*side))).ToString("F"));
            }
            else if (instruction == "space")
            {
                Console.WriteLine((Math.Sqrt(3 * (side * side))).ToString("F"));
            }
            else if (instruction == "volume")
            {
                Console.WriteLine((side * side * side).ToString("F"));
            }
            else if (instruction == "area")
            {
                Console.WriteLine((6 * side * side).ToString("F"));
            }
        }
    }
}
