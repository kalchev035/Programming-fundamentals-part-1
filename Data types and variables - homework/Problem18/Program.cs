using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            List<string> outList = new List<string>();

            try
            {
                sbyte s = sbyte.Parse(inputNum.ToString());
                outList.Add("* sbyte");
            }
            catch (Exception)
            {
            }
            try
            {
                byte s = byte.Parse(inputNum.ToString());
                outList.Add("* byte");
            }
            catch (Exception)
            {
            }
            try
            {
                short s = short.Parse(inputNum.ToString());
                outList.Add("* short");
            }
            catch (Exception)
            {
            }
            try
            {
                ushort s = ushort.Parse(inputNum.ToString());
                outList.Add("* ushort");
            }
            catch (Exception)
            {
            }
            try
            {
                int s = int.Parse(inputNum.ToString());
                outList.Add("* int");
            }
            catch (Exception)
            {
            }
            try
            {
                uint s = uint.Parse(inputNum.ToString());
                outList.Add("* uint");
            }
            catch (Exception)
            {
            }
            try
            {
                long s = long.Parse(inputNum.ToString());
                outList.Add("* long");
            }
            catch (Exception)
            {
            }
            if (outList.Count > 0)
            {
                Console.WriteLine("{0} can fit in:", inputNum);
                Console.WriteLine(string.Join("\n", outList));
            }
            else
            {
                Console.WriteLine($"{inputNum} can't fit in any type");
            }
        }
    }
}
