using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float time = (((hours * 60) + minutes) * 60) + seconds;
            Console.WriteLine(distance/time);
            Console.WriteLine((distance / 1000)/((time/60)/60));
            Console.WriteLine((distance / 1609)/((time / 60) / 60));
        }
    }
}
