using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRead = Console.ReadLine();
            int var1 = Convert.ToInt32(stringToRead, 16);
            Console.WriteLine(var1);
        }
    }
}
