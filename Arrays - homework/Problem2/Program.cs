using System;

namespace Problem2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int coeff = int.Parse(Console.ReadLine());
            int[] final = new int[input.Length];
            int[] sum = new int[input.Length];
            for (int y = 0; y<(input.Length); y++) {
                final[y] = int.Parse(input[y]);
            }
            for (int i = 0; i  < coeff; i++) {
                int lastElem = 0;
                lastElem = final[final.Length - 1];
                for (int z = final.Length - 1; z > 0; z--)
                {
                    final[z] = final[z - 1];
                }
                final[0] = lastElem;
                for (int z = 0; z < sum.Length; z++)
                {
                    sum[z] += final[z];
                }
            }
            for (int x = 0; x < sum.Length; x++) {
                Console.Write(sum[x]);
                if (x != sum.Length - 1) {
                    Console.Write(" ");
                }
            }
        }
    }
}
