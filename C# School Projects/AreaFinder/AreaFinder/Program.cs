using System;

namespace AreaFinder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int cases = Convert.ToInt32(Console.ReadLine()); int count = 0;
            for (int i = 0; i < cases; i++)
            {
                float y = rand.Next(10);
                if (y < myFxn(3))
                {
                    count++;
                }
            }
            Console.WriteLine((double) count / cases * 100);
        }

        public static float myFxn(float x)
        {
            return x; // Math.Sin(x);
        }
    }
}