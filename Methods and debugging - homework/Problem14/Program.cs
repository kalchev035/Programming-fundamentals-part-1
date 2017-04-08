using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int cntr = 0;
            for (int x = 1; x <= inputNum; x++)
            {
                factorial = factorial * x;
            }
            string zerosStr = factorial.ToString();
            for (int i = zerosStr.Length - 1; i >= 0; i--)
            {
                if (zerosStr[i] == '0') {
                    cntr += 1;
                }
                else { 
                    break;
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
