using System;
namespace HelloWorld
{
	public class LeapYear
	{
		public static void isLeapYear()
		{
            Console.WriteLine("Input an year : ");
            int checkYear = Convert.ToInt32(Console.ReadLine());

            if ((checkYear % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", checkYear);
            else if ((checkYear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", checkYear);
            else if ((checkYear % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", checkYear);
            else
                Console.WriteLine("{0} is not a leap year.\n", checkYear);
        }
	}
}

