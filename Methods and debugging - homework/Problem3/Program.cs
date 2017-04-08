using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            char outputValue = number[number.Length - 1 ];
            if (outputValue == '0') {
                Console.WriteLine("zero");
            }
            else if (outputValue == '1') {
                Console.WriteLine("one");
            }
            else if (outputValue == '2')
            {
                Console.WriteLine("two");
            }
            else if (outputValue == '3')
            {
                Console.WriteLine("three");
            }
            else if (outputValue == '4')
            {
                Console.WriteLine("four");
            }
            else if (outputValue == '5')
            {
                Console.WriteLine("five");
            }
            else if (outputValue == '6')
            {
                Console.WriteLine("six");
            }
            else if (outputValue == '7')
            {
                Console.WriteLine("seven");
            }
            else if (outputValue == '8')
            {
                Console.WriteLine("eight");
            }
            else if (outputValue == '9')
            {
                Console.WriteLine("nine");
            }
        }
    }
}
