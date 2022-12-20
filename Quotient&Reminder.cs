using System;
namespace HelloWorld
{
	public class Quotient_Reminder
	{
		public static void find_Quotient_Reminder()
		{
			int dividend = 210, divisor = 20;

			int Quotient = (dividend / divisor);
			int Reminder = (dividend  %  divisor);

			//Console.WriteLine("Dividend :{0} Divisor:{1}", dividend, divisor);

			Console.WriteLine("Quotient={0}", Quotient);
			Console.WriteLine("Reminder= " + Reminder);

			//Console.ReadKey();
		}
	}
}

