using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = input.Split().ToList();
            List<int> intList = nums.ConvertAll(s => int.Parse(s));
            List<int> newList = new List<int>();
            for (int i = 0; i < intList.Count; i++) {
                if (Math.Sqrt(intList[i]) == (int)Math.Sqrt(intList[i])) {
                    newList.Add(intList[i]);
                }
            }
            newList.Sort();
            newList.Reverse();
            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
