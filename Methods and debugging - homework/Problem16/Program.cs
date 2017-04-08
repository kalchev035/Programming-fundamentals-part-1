﻿using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = "";
        long result = 0;
        while (opCode != "END")
        {
            opCode = Console.ReadLine();
            string[] codeArgs = opCode.Split(' ');


            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (operandOne * operandTwo);
                        Console.WriteLine(result);
                        break;
                    }
            }
        }
    }
}