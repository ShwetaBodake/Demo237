using System;
namespace HelloWorld
{
	public class EvenOddProgram
	{
		public static void FindEvenOddProgram()
		{
			Console.WriteLine("Enter the Number :-");
			int number = Convert.ToInt32(Console.ReadLine());

			if ((number % 2) == 0)
				Console.WriteLine("Given number is Even");
			else
				Console.WriteLine("Given number is Odd");
		}
	}
}

