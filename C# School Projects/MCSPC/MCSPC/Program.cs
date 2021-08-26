using System;

namespace MCSPC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            int trials = Convert.ToInt32(Console.ReadLine());

            int wins1 = 0;
            int wins2 = 0;

            int[] dice2 = new int[12];
            
            for (int i = 0; i < trials; i++)
            {
                for (int z = 0; z < 6; z++)
                {
                    if (rand.Next(7) == 1)
                    {
                        wins1++;
                        break;
                    }
                }

                for (int j = 0; j < 12; j++)
                {
                    dice2[j] = rand.Next(7);
                    
                }

                int amount = 0;
                foreach (int x in dice2)
                {
                    if (x == 1)
                    {
                        amount++;
                        if (amount >= 2)
                        {
                            wins2++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine((double) wins1 / trials);
            Console.WriteLine((double) wins2 / trials);
        }
    }
}