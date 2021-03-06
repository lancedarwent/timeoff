﻿namespace TimeOff.Presentation.ConsoleApp
{
	public enum RemunerationType
	{
		FullTimeSalary = 1,
		PartTimeHourly = 0,
		FullTimeHourly = 2,
		NonPaid = 3
	}

	public interface IApprover
	{
		void ApproveTimeOffRequest(User user, int hours);
	}

	public abstract class User
	{
		public int Id { get; set; }
		public string SocialSecurityNumber { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public RemunerationType PaymentType { get; set; }

		public User(string userName, string password)
		{
			this.UserName = userName;
			this.Password = password;
		}
	}

	public class Intern : User
	{
		public string Major { get; set; }
		public int Age { get; set; }

		public Intern(string userName, string password)
			: base(userName, password)
		{
			this.Major = string.Empty;
		}

		public Intern(string userName, string password, RemunerationType paymentType)
			: this(userName, password)
		{
			base.PaymentType = paymentType;
		}
	}

	public class Employee : User
	{
		public bool FullTime { get; set; }

		public Employee(string userName, string password)
			: base(userName, password)
		{
			base.PaymentType = RemunerationType.FullTimeSalary;
		}
	}

	public class Supervisor : User
	{
		public Supervisor(string userName, string password)
			: base(userName, password)
		{

		}

		public void DoReview<TEmployee>(TEmployee userToReview)
			where TEmployee : User
		{
			//TODO:
		}
	}

	public class SupervisorV2 : Supervisor
	{
		public SupervisorV2(string userName, string password) 
			: base(userName, password)
		{

		}

		public void Terminate<TUser>(TUser user)
			where TUser : Employee
		{
			//TODO
		}
	}

	public class Manager : User, IApprover
	{
		public Manager(string userName, string password)
			:base(userName, password)
		{

		}

		public void ApproveTimeOffRequest(User user, int hours)
		{
			//TODO:
		}
	}

}
