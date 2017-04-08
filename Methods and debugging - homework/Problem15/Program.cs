using System;

public class Substring_broken
{
	public static void Main()
	{
		string text = Console.ReadLine();
		int jump = int.Parse(Console.ReadLine());
		bool hasMatch = false;
		for (int i = 0; i < text.Length; i++)
		{
            if (text[i] == 'p')
			{
                hasMatch = true;
                string textLeft = "";
                for (int x = i; x < text.Length; x++) {
                    textLeft += text[x];
                }
				int endIndex = jump + 1;
				if (endIndex > textLeft.Length)
				{
					endIndex = textLeft.Length;
				}
				string matchedString = textLeft.Substring(0, endIndex);
				Console.WriteLine(matchedString);
				i += jump;
			}
		}
		if (hasMatch == false)
		{
			Console.WriteLine("no");
		}
	}
}
