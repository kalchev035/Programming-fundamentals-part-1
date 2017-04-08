using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Problem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            int[] intArr = new int[inputLine.Length];
            List<int> list = new List<int>();
            for (int x = 0; x < inputLine.Length; x++) {
                intArr[x] = int.Parse(inputLine[x]);
                if (intArr[x] >= 0) {
                    list.Add(intArr[x]);
                }
            }
            list.Reverse();
            if (list.Count() > 0) {
                Console.WriteLine(String.Join(" ", list));
            }
            else {
                Console.WriteLine("empty");
            }
        }
    }
}
