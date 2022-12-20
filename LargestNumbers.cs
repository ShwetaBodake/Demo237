using System;
namespace HelloWorld
{
	public class LargestNumbers
	{
		public static void DisplayLargestNumbers()
		{
			Console.WriteLine("Enter the 1st number :-");
			int First = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number :-");
            int Second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number :-");
            int Third= Convert.ToInt32(Console.ReadLine());

			if (First > Second)
			{
				if (First > Third)
				{
					Console.WriteLine("First number is Largest number");
				}
				else
				{
					Console.WriteLine("Third number is the Largest number");
				}
			}
			else if (Second > Third)
			{
				Console.WriteLine("The Second number is Largest number");
			}
			else
			{
				Console.WriteLine("Third number is Largest number");
			}
        }
	}
}

