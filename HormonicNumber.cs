using System;
namespace HelloWorld
{
	public class HormonicNumber
	{
		public static void findHormonicNumber()
		{
			double sum = 0.0;

			Console.WriteLine("Enter Hormonic Value ");
			int Hormonic_Number = Convert.ToInt32(Console.ReadLine());

			for (double i = 1; i <= Hormonic_Number; i++)
			{
				//Console.WriteLine("1/" + i + "+ ");
				sum = sum + (1 / i);
			}
			Console.WriteLine("The sum is "+sum);
		}
	}
}

