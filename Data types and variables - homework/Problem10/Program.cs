using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries*100;
            decimal days = Math.Floor((decimal) (years * 365.2422));
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine(centuries + " centuries = " + years +  " years = " + days + " days = " + hours + " hours = " + minutes +" minutes = " + seconds +" seconds = " + miliseconds +" milliseconds = " + microseconds +" microseconds = " + nanoseconds +" nanoseconds");
        }
    }
}
