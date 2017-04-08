using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictureCount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadFactor = long.Parse(Console.ReadLine());
            double totalTime = 0;
            totalTime = (pictureCount * filterTime) + (Math.Ceiling(double.Parse(pictureCount.ToString()) * filterFactor / 100) * uploadFactor);
            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string answer = string.Format("{00:D1}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine(answer);
        }
    }
}
