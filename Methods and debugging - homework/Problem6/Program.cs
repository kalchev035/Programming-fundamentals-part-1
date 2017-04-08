using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double divCount = 0;
            for (int i = 2; i <= (Math.Sqrt(number)); i++) {
                if (number % i == 0) {
                    divCount += 1;
                }
            }
            if (number == 0 || number == 1) {
                divCount = 2;
            }
            if (divCount < 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
