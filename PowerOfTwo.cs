using System;
namespace HelloWorld
{
	public class PowerOfTwo
	{
		public static void findPowerOfTwo()
		{
			int mult = 1;
 
			Console.WriteLine("Enter the 'N' Power Value");
			int Power_Value = Convert.ToInt32(Console.ReadLine());
			if (Power_Value < 0)
			{
				Console.WriteLine("The value should be greater than 0");
			}
			else if(Power_Value < 31)
			{
				Console.WriteLine("The value should be less than 31");
			}
			else
			{
				for (int i = 0; i < Power_Value; i++)
				{
					mult = mult * 2;

				}
			}
			Console.WriteLine("Power of 2 is" + mult);
		}
	}
}

