using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> recipient = new List<string>();
            List<string> recipMessage = new List<string>();
            List<string> frequency = new List<string>();
            List<string> freqMessage = new List<string>();

            string inputLine = Console.ReadLine();
            while (inputLine != "Hornet is Green")
            {
                string[] input = new string[3];
                string[] inputToAmend = inputLine.Split(new string[] { " <-> " }, StringSplitOptions.None);

                if (inputToAmend.Length == 2)
                {
                    input[0] = inputToAmend[0];
                    input[2] = inputToAmend[1];
                }
                if (input[0] != null && input[2] != null)
                {
                    if (Regex.IsMatch(input[0], @"^[0-9]+$") && (Regex.IsMatch(input[2], @"^[a-zA-Z0-9]+$")))
                    {

                        char[] charArray = input[0].ToCharArray();
                        Array.Reverse(charArray);
                        input[0] = new string(charArray);

                        recipient.Add(input[0]);
                        recipMessage.Add(input[2]);

                    }
                    else if ((!input[0].Any(char.IsDigit)) && (Regex.IsMatch(input[2], @"^[a-zA-Z0-9]+$")))
                    {

                        char[] charArray = input[2].ToCharArray();
                        for (int x = 0; x < charArray.Length; x++)
                        {
                            if (char.IsLower(charArray[x]) && char.IsLetter(charArray[x]))
                            {
                                charArray[x] = char.ToUpper(charArray[x]);
                            }
                            else if (char.IsUpper(charArray[x]) && char.IsLetter(charArray[x]))
                            {
                                charArray[x] = char.ToLower(charArray[x]);
                            }
                        }
                        input[2] = new string(charArray);
                        frequency.Add(input[2]);
                        freqMessage.Add(input[0]);

                    }
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (frequency.Count > 0)
            {
                for (int i = 0; i < frequency.Count; i++)
                {
                    Console.WriteLine("{0} -> {1}", frequency[i], freqMessage[i]);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (recipient.Count > 0)
            {
                for (int i = 0; i < recipient.Count; i++)
                {
                    Console.WriteLine("{0} -> {1}", recipient[i], recipMessage[i]);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}