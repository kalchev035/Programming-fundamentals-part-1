using System;

namespace Problem4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] marked = new bool[input + 1];
            marked[0] = false;
            marked[1] = false;
            int help = 0;
            for (int i = 2; i<marked.Length; i++) {
                marked[i] = true;
            }
            for (int y = 2; y < marked.Length; y++) {

                if (marked[y] == true) {
                    help = y;
                }
                for (int z = 2; help*z < marked.Length; z++) {
                    marked[help * z] = false;
                }
            }
            for (int i = 0; i<marked.Length; i++) {
                if (marked[i] == true) {
                    Console.Write(i);
                }
                if (i != (marked.Length - 1) && marked[i] == true) {
                    Console.Write(' ');
                }
            }
        }
    }
}
