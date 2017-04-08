using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string> { };
            string [] inputLine = Console.ReadLine().Split();
            while (inputLine[0] != "END")
            {
                if (inputLine[0] == "A") {
                    if (phonebook.ContainsKey(inputLine[1])) {
                        phonebook[inputLine[1]] = inputLine[2];
                    }
                    else {
                        phonebook.Add(inputLine[1], inputLine[2]);
                    }
                }
                else if (inputLine[0] == "S") {
                    if (phonebook.ContainsKey(inputLine[1])) {
                        Console.WriteLine("{0} -> {1}", inputLine[1], phonebook[inputLine[1]]);
                    }
                    else {
                        Console.WriteLine("Contact {0} does not exist.", inputLine[1]);
                    }
                }
                inputLine = Console.ReadLine().Split();
            }
        }
    }
}
