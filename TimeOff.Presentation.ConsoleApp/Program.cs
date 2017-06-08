namespace TimeOff.Presentation.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp1 = new Employee("BOB!", "Password123");

			Supervisor sup1 = new Supervisor("Beth", "pass123");			

			Approve(new Manager(), emp1);
		}

		public static void Approve(IApprover adminUser, Employee employee)
		{
			adminUser.ApproveTimeOffRequest(employee, 3);
		}
	}
}
