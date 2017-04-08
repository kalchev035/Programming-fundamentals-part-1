using System;
using System.Collections.Generic;

public class BePositive_broken
{
	public static void Main()
	{
		int countSequences = int.Parse(Console.ReadLine());
        var outPutlist = new List<int>();
        var cntrs = new List<int>();

        for (int i = 0; i < countSequences; i++)
		{
			string[] input = Console.ReadLine().Split(' ');
			var numbers = new List<int>();
            int cntr = 0;
			for (int j = 0; j < input.Length; j++)
			{
				if (input[j] != "")
				{
					int num = int.Parse(input[j]);
					numbers.Add(num);
				}
			}

			bool found = false;

			for (int j = 0; j < numbers.Count; j++)
			{
				int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    found = true;
                    cntr += 1;
                    outPutlist.Add(currentNum);

                }
                else if ((currentNum < 0) && (j + 1 < numbers.Count))
                {
                    currentNum += numbers[j + 1];
                    if (currentNum >= 0)
                    {
                        found = true;
                        cntr += 1;
                        outPutlist.Add(currentNum);
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
			}
            cntrs.Add(cntr);
		}
        int joinedWordsCount = 0;
        for (int x = 0; x < cntrs.Count; x++) {
            var joinedWords = new List<string>();
            for (int y = 0; y < cntrs[x]; y++) {
                joinedWords.Add(outPutlist[y + joinedWordsCount].ToString());
            }
            joinedWordsCount += (joinedWords.Count);
            if (string.Join(" ", joinedWords) != "")
            {
                Console.WriteLine(string.Join(" ", joinedWords));
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}