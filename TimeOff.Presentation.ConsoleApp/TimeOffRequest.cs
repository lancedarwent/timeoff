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
		TimeOffType RequestType { get; }

		RequestStatusType Status { get; }

		User Requestor { get; set; }

		DateTime RequestDate { get; set; }

		DateTime? DecisionDate { get; set; }
	}
}
