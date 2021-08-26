using System;

namespace MonteCarloSimulation
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Random rand = new Random();
			
			int stake = Convert.ToInt32(Console.ReadLine());
			int goal = Convert.ToInt32(Console.ReadLine());
			int trials = Convert.ToInt32(Console.ReadLine());

			int wins = 0;
			int loss = 0;
			
			for (int i = 0; i < trials; i++)
			{
				int money = stake;
				while (money < 0 || money > goal)
				{
					if (rand.Next(0, 1) == 1)
					{
						money++;
					}
					else
					{
						money--;
					}
				}
				if (money >= goal)
				{
					wins++;
				}
				else
				{
					loss++;
				}
			}
			Console.WriteLine(100 * wins / trials);
		}
	}
}