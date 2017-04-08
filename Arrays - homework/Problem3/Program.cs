using System;

namespace Problem3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll((((Console.ReadLine())).Split()), int.Parse);
            int value = input.Length / 4;
            int[] line1 = new int[value * 2];
            int[] line2 = new int[value * 2];
            for (int x = 0, y = value - 1; x < value; x++, y--)
            {
                line1[x] = input[y];
            }
            for (int x = (value), y = input.Length - 1; x < value*2; x++, y--)
            {
                line1[x] = input[y];
            }
            for (int x = 0; x < value*2; x++) {
                line2[x] = input[x + value];
            }
            for (int x = 0; x<line1.Length; x++) {

                line2[x] += line1[x];
                Console.Write(line2[x]);
                if (x != ((line1.Length) - 1)) {
                    Console.Write(' ');
                }
            }
        }
    }
}
