using System;

namespace Problem11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            int[] input = new int[inputLine.Length];
            for (int x = 0; x < inputLine.Length; x++)
            {
                input[x] = int.Parse(inputLine[x]);
            }
            for (int y = 0; y < input.Length; y++) {
                int firstSum = 0;
                int secondSum = 0;
                for (int z = 0; z < y; z++)
                {
                    firstSum += input[z];
                }
                for (int i = y + 1; i < input.Length; i++)
                {
                    secondSum += input[i];
                }
                if (firstSum == secondSum) {
                    Console.WriteLine(y);
                    break;
                }
                else if (y == input.Length - 1) {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
