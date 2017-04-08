using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int x = 1; x <= inputNum; x++) {
                factorial = factorial * x;
            }
            Console.WriteLine(factorial);
        }
    }
}
