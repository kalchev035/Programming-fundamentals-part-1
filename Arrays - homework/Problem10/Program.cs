using System;

namespace Problem10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            int[] input = new int[inputLine.Length];
            int diff = int.Parse(Console.ReadLine());
            int cntr = 0;
            for (int x = 0; x < inputLine.Length; x++)
            {
                input[x] = int.Parse(inputLine[x]);
            }
            for (int y = 0; y < input.Length; y++) {
                for (int z = 0; z < input.Length; z++) {
                    if (input[y] - input[z] == diff && y!=z) {
                        cntr++;
                    }
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
