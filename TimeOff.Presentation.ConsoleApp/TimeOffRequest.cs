using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOff.Presentation.ConsoleApp
{
	public enum RequestStatusType
	{
		Submitted,
		SentToApprover,
		//TODO: Add additional states; something to the effect of "in the chain of approvers"
		Approved,
		Denied,
		InReview
	}

	public enum TimeOffType
	{
		PTO = 0,
		Vacation = 1,
		FloatingHoliday = 2,
		UnpaidLeave = 3,
		JuryDuty = 4,
		MilitaryService = 5,
		Other = 6
	}

	public enum TimeOffIncrements
	{
		QuarterHour,
		Hours,
		Days
	}

	public abstract class TimeOffRequest
	{
		public TimeOffType RequestType { get; set; }

		public int NumberOfHours { get; protected set; }

		public TimeOffIncrements Increments { get; set; }

		public RequestStatusType Status { get; protected set; }

		public User Requestor { get; set; }

		public DateTime RequestDate { get; set; }

		public DateTime? DecisionDate { get; set; }
	}

	public class PTORequest
		: TimeOffRequest
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		
		public PTORequest(User requestor, DateTime startDate, DateTime endDate)
		{
			base.RequestType = TimeOffType.PTO;
			base.Increments = TimeOffIncrements.QuarterHour;
			base.Requestor = requestor;

			this.StartDate = startDate;
			this.EndDate = endDate;

			base.NumberOfHours = (startDate - endDate).Hours;

			base.Status = RequestStatusType.Submitted;
		}

		public PTORequest(User requestor, DateTime[,] dateRanges)
		{

		}
	}

	public class VacationRequest
		: TimeOffRequest
	{

	}

	public class FloatingHoliday
		: TimeOffRequest
	{

	}

	public class UnpaidRequest
		: TimeOffRequest
	{

	}




}
