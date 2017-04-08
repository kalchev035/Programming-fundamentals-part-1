using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                bool result = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        result = false;
                        break;
                    }
                }
                if (i >= 2) {
                    Console.WriteLine($"{i} -> {result}");
                } 
            }
        }
    }
}
