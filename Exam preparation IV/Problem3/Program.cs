using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();
            string keys = Console.ReadLine();
            char[] key = keys.ToCharArray();
            string[] inputLine = Console.ReadLine().Split(' ');
            while (inputLine[0] != "final")
            {
                List<char> teamAList = new List<char>();
                for (int x = inputLine[0].IndexOf(keys) + keys.Length; x < inputLine[0].Length; x++)
                {
                    if (!(inputLine[0][x] == key[0] && inputLine[0][x + 1] == key[1]))
                    {
                        teamAList.Add(char.ToUpper(inputLine[0][x]));
                    }
                    else
                    {
                        break;
                    }
                }
                List<char> teamBList = new List<char>();
                for (int x = inputLine[1].IndexOf(keys) + keys.Length; x < inputLine[1].Length; x++)
                {
                    if (!(inputLine[1][x] == key[0] && inputLine[1][x + 1] == key[1]))
                    {
                        teamBList.Add(char.ToUpper(inputLine[1][x]));
                    }
                    else
                    {
                        break;
                    }
                }
                teamAList.Reverse();
                teamBList.Reverse();
                string teamA = string.Join("", teamAList.ToArray());
                string teamB = string.Join("", teamBList.ToArray());
                int teamAPoints = 0;
                int teamBPoints = 0;
                if (int.Parse((inputLine[2].Split(':')[0])) > int.Parse((inputLine[2].Split(':')[1])))
                {
                    teamAPoints = 3;
                }
                else if (int.Parse((inputLine[2].Split(':')[0])) < int.Parse((inputLine[2].Split(':')[1])))
                {
                    teamBPoints = 3;
                }
                else
                {
                    teamAPoints = 1;
                    teamBPoints = 1;
                }
                if (!goals.ContainsKey(teamA))
                {
                    goals.Add(teamA, int.Parse(inputLine[2].Split(':')[0]));
                    points.Add(teamA, teamAPoints);
                }
                else
                {
                    goals[teamA] += int.Parse(inputLine[2].Split(':')[0]);
                    points[teamA] += teamAPoints;
                }
                if (!goals.ContainsKey(teamB))
                {
                    goals.Add(teamB, int.Parse(inputLine[2].Split(':')[1]));
                    points.Add(teamB, teamBPoints);
                }
                else
                {
                    goals[teamB] += int.Parse(inputLine[2].Split(':')[1]);
                    points[teamB] += teamBPoints;
                }
                inputLine = Console.ReadLine().Split(' ');
            }
            var standings = points.OrderByDescending(i => i.Value).ThenBy(i => i.Key).ToDictionary(x => x.Key, x => x.Value);
            var myKeysA = standings.Keys.ToList();
            Console.WriteLine("League standings:");
            for (int x = 0; x < myKeysA.Count; x++)
            {
                Console.WriteLine("{0}. {1} {2}", x + 1, myKeysA[x], standings[myKeysA[x]]);
            }
            var goalMasters = goals.OrderByDescending(i => i.Value).ThenBy(i => i.Key).ToDictionary(x => x.Key, x => x.Value);
            var myKeysB = goalMasters.Keys.ToList();
            Console.WriteLine("Top 3 scored goals:");
            for (int x = 0; x < 3 && x < myKeysB.Count; x++)
            {
                Console.WriteLine("- {0} -> {1}", myKeysB[x], goalMasters[myKeysB[x]]);
            }
        }
    }
}