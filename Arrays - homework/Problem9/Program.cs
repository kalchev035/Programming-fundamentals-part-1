using System;

namespace Problem9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputLine = (Console.ReadLine());
            char[] input = inputLine.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", input[i], (int)input[i] - 97);
            }
        }
    }
}
