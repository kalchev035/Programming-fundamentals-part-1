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
            string stringToRead = Console.ReadLine();
            bool boolVar = Convert.ToBoolean(stringToRead);
            if (boolVar == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
