using System;
using System.Linq;

namespace Problem8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            int[] input = new int[inputLine.Length];
            int[] frequency = new int[inputLine.Length];
            for (int x = 0; x < inputLine.Length; x++) {
                input[x] = int.Parse(inputLine[x]);
            }
            for (int y = 0; y < input.Length; y++) {
                int cntr = 0;
                for (int z = 0; z < input.Length; z++) {
                    if (input[y] == input[z]) {
                        cntr++;
                    }
                }
                frequency[y] = cntr;
            }
            int maxValue = frequency.Max();
            for (int i = 0; i < input.Length; i++) {
                if (frequency[i] == maxValue) {
                    Console.WriteLine(input[i]);
                    break;
                }
            }
        }
    }
}
