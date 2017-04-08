using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double comparisonNumber = 0.000001;
            if (Math.Abs(firstNumber - secondNumber) < comparisonNumber)
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
    }
}
