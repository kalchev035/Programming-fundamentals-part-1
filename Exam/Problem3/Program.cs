using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] defence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] attack = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> beehives = new List<int>(defence);
            List<int> hornets = new List<int>(attack);
            int hornetsSum = hornets.Sum();
            int hornetsCntr = 0;

            for (int i = 0; i < beehives.Count; i++)
            {
                hornetsSum = hornets.Sum();
                if (beehives[i] > hornetsSum || beehives[i] == hornetsSum)
                {
                    beehives[i] = beehives[i] - hornetsSum;
                    hornets[hornetsCntr] = 0;
                    hornetsCntr++;
                }
                else
                {
                    beehives[i] = beehives[i] - hornetsSum;
                }
                if (hornetsCntr == hornets.Count)
                {
                    break;
                }
            }

            beehives.RemoveAll(i => i <= 0);
            hornets.RemoveAll(i => i == 0);

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
