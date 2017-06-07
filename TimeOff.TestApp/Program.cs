﻿namespace TimeOff.TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp1 = new Employee("BOB!", "Password123");

			Supervisor sup1 = new Supervisor("Beth", "pass123");			

			Approve(new Boss(), emp1);
		}

		public static void Approve(IAdmin adminUser, Employee employee)
		{
			adminUser.ApproveTimeOffRequest(employee, 3);
		}
	}
}