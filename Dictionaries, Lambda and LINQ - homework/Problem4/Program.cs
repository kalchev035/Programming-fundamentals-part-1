using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var notebook = new Dictionary<string, string> { };
            string inputLine = Console.ReadLine();
            List<string> keys = new List<string>();
            keys.Add(inputLine);
            int cntr = 0;
            while (inputLine != "stop")
            {
                if (cntr % 2 == 0)
                {
                    if (!notebook.ContainsKey(keys[cntr]))
                    {
                        notebook.Add(inputLine, "");
                    }
                }
                else
                {
                    notebook[keys[cntr - 1]] = inputLine;
                }
                inputLine = Console.ReadLine();
                keys.Add(inputLine);
                cntr++;
            }
            var list = notebook.Keys.ToList();
            for (int x = 0; x < list.Count; x++)
            {
                if (notebook[list[x]].Split('.').Last() != "us" && notebook[list[x]].Split('.').Last() != "uk")
                {
                    Console.WriteLine("{0} -> {1}", list[x], notebook[list[x]]);
                }
            }
        }
    }
}
