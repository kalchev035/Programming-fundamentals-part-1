using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((2*width)+(2*height));
            Console.WriteLine(width*height);
            Console.WriteLine(Math.Sqrt((width*width) + (height*height)));
        }
    }
}
