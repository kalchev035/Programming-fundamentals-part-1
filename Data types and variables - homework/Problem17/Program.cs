using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = startingNum; i<=finalNum; i++)
            {
                char character = (char)i;
                text = text + " " + character.ToString();
            }
            Console.WriteLine(text);
        }
    }
}
