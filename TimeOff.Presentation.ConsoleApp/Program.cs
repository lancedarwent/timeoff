using System;

namespace TimeOff.Presentation.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee brett = new Employee("bmacy@tot.com", "password123");

			TimeSpan ts;
			if (TimeSpan.TryParseExact("4:30", "HH:mm", null, out ts))
			{
				Console.WriteLine(ts);
				//success
			}
			else
			{
				Console.WriteLine("failed");
				//fail
			}

			//PTORequest request = new PTORequest(brett)

			Console.ReadLine();

		}

		public static void Approve(IApprover adminUser, Employee employee)
		{
			adminUser.ApproveTimeOffRequest(employee, 3);
		}
	}
}
