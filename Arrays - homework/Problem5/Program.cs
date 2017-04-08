using System;

namespace Problem5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstLine = (Console.ReadLine()).Split();
            string[] secondLine = (Console.ReadLine()).Split();
            char[] firstCharArr = new char[firstLine.Length];
            char[] secondCharArr = new char[secondLine.Length];
            for (int i = 0; i < firstLine.Length; i++)
            {
                firstCharArr[i] = Char.Parse(firstLine[i]);
            }
            for (int i = 0; i < secondLine.Length; i++)
            {
                secondCharArr[i] = Char.Parse(secondLine[i]);
            }
            for (int x = 0; x < firstLine.Length && x < secondLine.Length; x++) {
                if (firstCharArr[x] < secondCharArr[x] || firstLine.Length < secondLine.Length)
                {
                    Console.WriteLine(string.Join("", firstLine));
                    Console.WriteLine(string.Join("", secondLine));
                    break;
                }
                else if (firstCharArr[x] > secondCharArr[x] || firstLine.Length > secondLine.Length)
                {
                    Console.WriteLine(string.Join("", secondLine));
                    Console.WriteLine(string.Join("", firstLine));
                    break;
                }
                else {
                    Console.WriteLine(string.Join("", firstLine));
                    Console.WriteLine(string.Join("", secondLine));
                    break;
                }
            }
        }
    }
}
