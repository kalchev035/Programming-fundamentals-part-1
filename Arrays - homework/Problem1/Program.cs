using System;

namespace Problem1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputLineOne = Console.ReadLine().ToLower();
            string [] inputArrOne = inputLineOne.Split();
            string inputLineTwo = Console.ReadLine().ToLower();
            string[] inputArrTwo = inputLineTwo.Split();
            int length = 0;
            if (inputArrOne.Length > inputArrTwo.Length) {
                length = inputArrTwo.Length - 1;
            }
            else {
                length = inputArrOne.Length - 1;
            }
            int up = 0;
            for (int x = 0; x < length; x++)
            {
                if (inputArrOne[x] == inputArrTwo[x]) {
                    up++;
                }
                else
                {
                    break;
                }
            }
            int down = 0;
            for (int x = length; x >=0 ; x--)
            {
                if (inputArrOne.Length > inputArrTwo.Length)
                {
                    if (inputArrOne[x + (inputArrOne.Length - inputArrTwo.Length)] == inputArrTwo[x])
                    {
                        down++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (inputArrOne[x] == inputArrTwo[x + (inputArrTwo.Length - inputArrOne.Length)])
                    {
                        down++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int biggerCntr = 0;
            string instruction = "";
            if (up >= down) {
                biggerCntr = up;
                instruction = "up";
            }
            else {
                biggerCntr = down;
                instruction = "down";
            }

            Console.WriteLine(biggerCntr);
            switch (biggerCntr)
            {
                case 0:
                    {
                        Console.WriteLine("No common words at the left and right");
                        break;
                    }
                default:
                    {
                        if (instruction == "up")
                        {
                            Console.WriteLine("The largest common end is at the left: ");
                            for (int y = 0; y < biggerCntr; y++)
                            {
                                Console.Write(inputArrOne[y]);
                            }
                        }
                        else
                        {
                            int x = 1;
                            Console.WriteLine("The largest common end is at the right: ");
                            for (int y = inputArrOne.Length - 1; y >= 0 && x <= biggerCntr; y--)
                            {
                                Console.Write(inputArrOne[y]);
                                x++;
                            }
                        }
                        break;
                    }
                                }


        }
    }
}
