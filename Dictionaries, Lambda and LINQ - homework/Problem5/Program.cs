using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var notebook = new Dictionary<string, List<string>> { };
            string inputLine = Console.ReadLine();
            string key = inputLine.Split(':')[0].Trim();
            List<string> values = new List<string>();
            for (int y = 0; y < inputLine.Split(':')[1].Trim(' ').Split(',').Length; y++)
            {
                values.Add(inputLine.Split(':')[1].Trim(' ').Split(',')[y].Trim(' '));
            }
            while (key != "JOKER")
            {
                if (!notebook.ContainsKey(key))
                {
                    notebook.Add(key, values);
                }
                else
                {
                    for (int i = 0; i < values.Count; i++)
                        notebook[key].Add(values[i]);
                }
                inputLine = Console.ReadLine();
                key = inputLine.Split(':')[0].Trim();
                values = new List<string>();
                if (inputLine != "JOKER")
                {
                    for (int y = 0; y < inputLine.Split(':')[1].Trim(' ').Split(',').Length; y++)
                    {
                        values.Add(inputLine.Split(':')[1].Trim(' ').Split(',')[y].Trim(' '));
                    }
                }
            }
            List<string> newList = new List<string>();
            var list = notebook.Keys.ToList();
            for (int z = 0; z < list.Count; z++)
            {
                newList = new List<string>();
                for (int y = 0; y < notebook[list[z]].Count; y++)
                {
                    if (!newList.Contains(notebook[list[z]][y]))
                    {
                        newList.Add(notebook[list[z]][y]);
                    }
                    else
                    {
                        newList.Remove(notebook[list[z]][y]);
                    }
                }
                notebook[list[z]] = newList;
            }

            for (int x = 0; x < list.Count; x++)
            {
                for (int y = 0; y < notebook[list[x]].Count; y++)
                {
                    switch (notebook[list[x]][y][notebook[list[x]][y].Length - 1])
                    {
                        case 'S':
                            if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "J")
                            {
                                notebook[list[x]][y] = "44";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "Q")
                            {
                                notebook[list[x]][y] = "48";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "K")
                            {
                                notebook[list[x]][y] = "52";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "A")
                            {
                                notebook[list[x]][y] = "56";
                            }
                            else {
                                notebook[list[x]][y] = (4*int.Parse(notebook[list[x]][y].Substring(0, (notebook[list[x]][y].Length - 1)))).ToString();
                            }
                            break;
                        case 'H':
                            if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "J")
                            {
                                notebook[list[x]][y] = "33";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "Q")
                            {
                                notebook[list[x]][y] = "36";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "K")
                            {
                                notebook[list[x]][y] = "39";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "A")
                            {
                                notebook[list[x]][y] = "42";
                            }
                            else
                            {
                                notebook[list[x]][y] = (3 * int.Parse(notebook[list[x]][y].Substring(0, (notebook[list[x]][y].Length - 1)))).ToString();
                            }
                            break;
                        case 'D':
                            if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "J")
                            {
                                notebook[list[x]][y] = "22";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "Q")
                            {
                                notebook[list[x]][y] = "24";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "K")
                            {
                                notebook[list[x]][y] = "26";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "A")
                            {
                                notebook[list[x]][y] = "28";
                            }
                            else
                            {
                                notebook[list[x]][y] = (2 * int.Parse(notebook[list[x]][y].Substring(0, (notebook[list[x]][y].Length - 1)))).ToString();
                            }
                            break;
                        case 'C':
                            if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "J")
                            {
                                notebook[list[x]][y] = "11";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "Q")
                            {
                                notebook[list[x]][y] = "12";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "K")
                            {
                                notebook[list[x]][y] = "13";
                            }
                            else if (notebook[list[x]][y].Substring(0, notebook[list[x]][y].Length - 1) == "A")
                            {
                                notebook[list[x]][y] = "14";
                            }
                            else
                            {
                                notebook[list[x]][y] = notebook[list[x]][y].Substring(0, (notebook[list[x]][y].Length - 1));
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            
            for (int x = 0; x < list.Count; x++)
            {
                    Console.WriteLine("{0}: {1}", list[x], notebook[list[x]].Sum(y => Convert.ToInt32(y)));
                
            }
        }
    }
}
