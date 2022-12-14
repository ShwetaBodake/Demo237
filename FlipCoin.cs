using System;
namespace HelloWorld
{
	public class FlipCoin
	{
		public static void FlipTheCoin()
		{
			Console.WriteLine("Please Enter the value for number of flips");
			int flip = Convert.ToInt32(Console.ReadLine());
			int tailcount=0;
			int headcount=0;

			if (flip > 0)
			{
				for (int i = 1; i <= flip; i++)
				{
					Random random = new Random();

					int number = random.Next(2);
					Console.WriteLine(number);

					if (number == 0)
					{
						tailcount++;
					}
					else
					{
						headcount++;
					}

				}

				Console.WriteLine("HeadCount is " + headcount);
                Console.WriteLine("Tailcount is " + tailcount);

				int headPersentage = headcount * 100 / flip;
                int tailPersentage = tailcount * 100 / flip;
				Console.WriteLine("HeadPercentage is " + headPersentage);
                Console.WriteLine("TailPercentage is " + tailPersentage);
            }
			else
			{
				Console.WriteLine("Please Enter Correct number ");
			}

		}
	}
}

