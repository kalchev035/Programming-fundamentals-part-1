using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = input.Split().ToList();
            List<int> intList = nums.ConvertAll(s => int.Parse(s));
            int[] counterArr = new int[1001];
            intList.Sort();
            for (int i = 0; i < intList.Count; i++)
            {
                counterArr[intList[i]] += 1;
            }
            for (int i = 0; i < counterArr.Length; i++)
            {
                if (counterArr[i] != 0) {
                    Console.WriteLine("{0} -> {1}", i, counterArr[i]);
                }
            }
        }
    }
}
