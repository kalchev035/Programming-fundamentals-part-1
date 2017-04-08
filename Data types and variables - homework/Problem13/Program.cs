using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Convert.ToString(Console.ReadLine());
            if (input.ToUpper() == "A" || input.ToUpper() == "E" || input.ToUpper() == "I" || input.ToUpper() == "O" || input.ToUpper() == "U") {
                Console.WriteLine("vowel");
            }
            else if (input == "0" || input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9") {
                Console.WriteLine("digit");
            }
            else {
                Console.WriteLine("other");
            }
        }
    }
}
