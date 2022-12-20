using System;
namespace HelloWorld
{
	public class SwapNumbers
	{
		public static void DisplaySwapNumbers()
		{
			int a = 6, b = 5;
			Console.WriteLine("Before swap a= " + a + " b= " + b);
			a = a * b;
			b = a / b;
			a = a / b;

			Console.WriteLine("After swap a= " + a + " b= " + b);


		}
	}
}

