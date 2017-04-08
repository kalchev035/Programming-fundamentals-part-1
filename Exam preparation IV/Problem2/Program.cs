using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            string[] instruction = Console.ReadLine().Split(' ');
            while (instruction[0] != "end") {
                switch (instruction[0]) {
                    case "exchange":
                        if (int.Parse(instruction[1]) >= 0 && int.Parse(instruction[1]) < input.Length) {
                            int[] tmp = new int[input.Length];
                            for (int x = 0, y=input.Length - int.Parse(instruction[1]) - 1; x<input.Length; x++, y++) {
                                if (x <= int.Parse(instruction[1]))
                                {
                                    tmp[y] = input[x];
                                }
                                else {
                                    tmp[x - int.Parse(instruction[1]) - 1] = input[x];
                                }
                            }
                            input = tmp;
                        }
                        else
                        {
                            Console.Write("Invalid index\n");
                        }
                        break;
                    case "max":
                        var list = new List<int>(input);
                        bool check = false;
                        int max = list.Max();
                        if (instruction[1] == "even")
                        {
                            while (max%2!=0 && list.Count > 0) {
                                list.Remove(max);
                                if (list.Count > 0) {
                                    max = list.Max();
                                }
                            }
                            for (int z = input.Length - 1; z >= 0 ; z--)
                            {
                                if (input[z] == max && max%2 == 0)
                                {
                                    Console.Write(z + "\n");
                                    check = true;
                                    break;
                                }
                            }
                        }
                        else if (instruction[1] == "odd")
                        {
                            while (max % 2 == 0 && list.Count > 0)
                            {
                                list.Remove(max);
                                if (list.Count > 0)
                                {
                                    max = list.Max();
                                }

                            }
                            for (int z = input.Length - 1; z >= 0; z--)
                            {
                                if (input[z] == max && max % 2 != 0)
                                {
                                    Console.Write(z + "\n");
                                    check = true;
                                    break;
                                }
                            }
                        }
                        if (check == false) {
                            Console.Write("No matches\n");
                        }
                        break;
                    case "min":
                        list = new List<int>(input);
                        check = false;
                        max = list.Min();
                        if (instruction[1] == "even")
                        {
                            while (max % 2 != 0 && list.Count > 0)
                            {
                                list.Remove(max);
                                if (list.Count > 0)
                                {
                                    max = list.Min();
                                }
                            }
                            for (int z = input.Length - 1; z >= 0; z--)
                            {
                                if (input[z] == max && max % 2 == 0)
                                {
                                    Console.Write(z + "\n");
                                    check = true;
                                    break;
                                }
                            }
                        }
                        else if (instruction[1] == "odd")
                        {
                            while (max % 2 == 0 && list.Count > 0)
                            {
                                list.Remove(max);
                                if (list.Count > 0)
                                {
                                    max = list.Min();
                                }

                            }
                            for (int z = input.Length - 1; z >= 0; z--)
                            {
                                if (input[z] == max && max % 2 != 0)
                                {
                                    Console.Write(z + "\n");
                                    check = true;
                                    break;
                                }
                            }
                        }
                        if (check == false)
                        {
                            Console.Write("No matches\n");
                        }
                        break;
                    case "first":
                        int cntr = 0;
                        if (instruction[2] == "even" && int.Parse(instruction[1]) <= input.Length)
                        {
                            for (int p = 0; p < input.Length; p++)
                            {
                                if (cntr == 0 && input[p] % 2 == 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write("[{0}", input[p]);
                                    cntr++;
                                }
                                else if (input[p] % 2 == 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write(", {0}", input[p]);
                                    cntr++;
                                }
                            }
                            if (cntr > 0)
                            {
                                Console.Write("]\n");
                            }
                            else
                            {
                                Console.Write("[]\n");
                            }
                        }
                        else if (instruction[2] == "odd" && int.Parse(instruction[1]) <= input.Length)
                        {
                            for (int p = 0; p < input.Length; p++)
                            {
                                if (cntr == 0 && input[p] % 2 != 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write("[{0}", input[p]);
                                    cntr++;
                                }
                                else if (input[p] % 2 != 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write(", {0}", input[p]);
                                    cntr++;
                                }
                            }
                            if (cntr > 0)
                            {
                                Console.Write("]\n");
                            }
                            else
                            {
                                Console.Write("[]\n");
                            }
                        }
                        else {
                            Console.Write("Invalid count\n");
                        }
                        break;
                    case "last":
                        cntr = 0;
                        if (instruction[2] == "even" && int.Parse(instruction[1]) <= input.Length)
                        {
                            for (int p = input.Length - 1; p >= 0; p--)
                            {
                                if (cntr == 0 && input[p] % 2 == 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write("[{0}", input[p]);
                                    cntr++;
                                }
                                else if (input[p] % 2 == 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write(", {0}", input[p]);
                                    cntr++;
                                }
                            }
                            if (cntr > 0)
                            {
                                Console.Write("]\n");
                            }
                            else
                            {
                                Console.Write("[]\n");
                            }
                        }
                        else if (instruction[2] == "odd" && int.Parse(instruction[1]) <= input.Length)
                        {
                            for (int p = input.Length - 1; p >= 0; p--)
                            {
                                if (cntr == 0 && input[p] % 2 != 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write("[{0}", input[p]);
                                    cntr++;
                                }
                                else if (input[p] % 2 != 0 && cntr < int.Parse(instruction[1]))
                                {
                                    Console.Write(", {0}", input[p]);
                                    cntr++;
                                }
                            }
                            if (cntr > 0)
                            {
                                Console.Write("]\n");
                            }
                            else
                            {
                                Console.Write("[]\n");
                            }
                        }
                        else
                        {
                            Console.Write("Invalid count\n");
                        }
                        break;
                    default:
                        break;
                }
                instruction = Console.ReadLine().Split(' ');
            }
            Console.Write("[");
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1)
                {
                    Console.Write("{0}, ", input[i]);
                }
                else {
                    Console.Write("{0}]", input[i]);
                }
            }
        }
    }
}
