using System;

namespace Problem7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = (Console.ReadLine().Split());
            int[] input = new int[inputLine.Length];
            int workingVal = 0;
            int workingFreq = 1;
            int finalInd = 0;
            int value = 0;
            int frequency = 1;
            for (int x = 0; x < inputLine.Length; x++)
            {
                input[x] = int.Parse(inputLine[x]);
            }
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - 1 == input[i - 1])
                {
                    value = input[i];
                    frequency++;
                    finalInd = i;
                }
                if (value != 0 && input[i] - 1 != input[i - 1])
                {
                    break;
                }
            }
            for (int x = finalInd + 1; x < input.Length; x++)
            {
                if (input[x] - 1 == input[x - 1])
                {
                    workingVal = input[x];
                    workingFreq++;
                }
                if (workingFreq > frequency)
                {
                    frequency = workingFreq;
                    value = workingVal;
                }
                if (input[x] - 1 != input[x - 1])
                {
                    workingFreq = 1;
                    workingVal = 0;
                }
            }
            if (value == 0 && frequency == 1)
            {
                value = input[0];
            }
            for (int i = value - frequency + 1; i <= value; i++)
            {
                Console.Write(i);
                if (i!=value)
                {
                    Console.Write(' ');
                }
            }
        }
    }
}
