using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = input.Split().ToList();
            List<double> intList = nums.ConvertAll(s => double.Parse(s));
            intList.Sort();
            Console.WriteLine(String.Join(" ", intList));
        }
    }
}
