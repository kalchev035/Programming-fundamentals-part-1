using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int start = 1; start <= input; start++)
            {
                int divisibleCheck = 0;
                bool evenCheck = false;
                string stringToCheck = "";
                string number = start.ToString();
                char[] charArray = number.ToCharArray();
                Array.Reverse(charArray);
                for (int i = 0; i < charArray.Length; i++) {
                    int eachNum = int.Parse(charArray[i].ToString());
                    stringToCheck += charArray[i].ToString();
                    divisibleCheck += eachNum;
                    if (eachNum % 2 == 0) {
                        evenCheck = true;
                    }
                }
                if ((number == stringToCheck) && (divisibleCheck%7 == 0) && (evenCheck == true)) {
                    Console.WriteLine(start);
                }
            }
        }     
    }
}
