using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split('|',',',';',':','.','!','(',')','"','\\','/','[',']',' ');
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            for (int i = 0; i < inputLine.Length; i++) {
                int lowerCases = 0;
                int symbol = 0;
                char[] characters = inputLine[i].ToCharArray();
                for (int x = 0; x < characters.Length; x++) {
                    if (char.IsLower(characters[x])) {
                        lowerCases++;
                    }
                    else if (!char.IsLetter(characters[x])) {
                        symbol++;
                    }
                }
                if (symbol > 0) {
                    mixed.Add(inputLine[i]);
                }
                else if (lowerCases == 0 && characters.Length > 0)
                {
                    upper.Add(inputLine[i]);
                }
                else if (lowerCases == characters.Length && characters.Length > 0)
                {
                    lower.Add(inputLine[i]);
                }
                else if (characters.Length > 0)
                {
                    mixed.Add(inputLine[i]);
                }
            }
            Console.Write("Lower-case: ");
            Console.Write(String.Join(", ", lower));
            Console.Write("\n");
            Console.Write("Mixed-case: ");
            Console.Write(String.Join(", ", mixed));
            Console.Write("\n");
            Console.Write("Upper-case: ");
            Console.Write(String.Join(", ", upper));
            Console.Write("\n");
        }
    }
}
