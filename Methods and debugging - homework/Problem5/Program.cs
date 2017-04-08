using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int seqNum = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 1;
            for (int i = 1; i <= seqNum; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
