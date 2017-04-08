using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            int linesCount = int.Parse(Console.ReadLine());
            for (int x = 0; x<linesCount; x++) {
                string inputLine = Console.ReadLine();
                int lastActivity = int.Parse(inputLine.Split('=')[0].Trim());
                string legionName = inputLine.Split('=')[1].Split(new string[] { " -> " }, StringSplitOptions.None)[0].Trim();
                string soldierType = inputLine.Split(new string[] { " -> " }, StringSplitOptions.None)[1].Split(':')[0].Trim();
                int soldierCount = int.Parse(inputLine.Split(new string[] { " -> " }, StringSplitOptions.None)[1].Split(':')[1].Trim());

            }
        }
    }
}
