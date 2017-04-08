using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = input.Split().ToList();
            List<double> intList = nums.ConvertAll(s => double.Parse(s));
            for (int i = 0; i < intList.Count - 1; i++) {
                if (intList[i] == intList[i + 1]) {
                    intList[i] *= 2;
                    intList.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", intList));
        }
    }
}
