using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split('|');
            List<string> list = new List<string>();
            for (int x = inputLine.Length - 1; x >= 0; x--) {
                string[] workingStr = inputLine[x].Split();
                for (int y = 0; y < workingStr.Length; y++)
                {
                    if (workingStr[y] != "") {
                        list.Add(workingStr[y]);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
