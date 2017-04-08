using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalText = "";
            double startNum = double.Parse(Console.ReadLine());
            double endNum = double.Parse(Console.ReadLine());
            for (double cntr = startNum; cntr <= endNum; cntr++) {
                double divCount = 0;
                for (int i = 2; i <= (Math.Sqrt(cntr)); i++)
                {
                    if (cntr % i == 0)
                    {
                        divCount += 1;
                    }
                }
                if (cntr == 0 || cntr == 1)
                {
                    divCount = 2;
                }
                if (divCount < 1)
                {
                    finalText = finalText + cntr + ", ";
                }
            }
            Console.WriteLine(finalText.Substring(0, finalText.Length - 2));
        }
    }
}
