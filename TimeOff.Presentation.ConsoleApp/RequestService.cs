using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOff.Presentation.ConsoleApp
{
	public interface IRequestService
	{
		bool SubmitRequest(TimeOffRequest request);

		bool ApproveRequest(TimeOffRequest request);

		bool SendConfirmation(TimeOffRequest request);
	}

	public class RequestService : IRequestService
	{
		public bool ApproveRequest(TimeOffRequest request)
		{
			throw new NotImplementedException();
		}

		public bool SendConfirmation(TimeOffRequest request)
		{
			throw new NotImplementedException();
		}

		public bool SubmitRequest(TimeOffRequest request)
		{
			throw new NotImplementedException();
		}

		public bool SubmitRequest<TBobApprover, TSupervisor>(TimeOffRequest request, TBobApprover approver, TSupervisor supervisor) 
			where TBobApprover : User, IApprover
			where TSupervisor : Supervisor, IApprover
		{
			supervisor.DoReview(approver);

			//TODO:
			
			return false;
		}

		public bool SubmitRequest<TApprover, TSupervisor>(TimeOffRequest request, TApprover approver, TSupervisor supervisor, string reason)
			where TApprover : Employee, IApprover
			where TSupervisor : SupervisorV2, IApprover
		{

			supervisor.Terminate(approver);

			return false;
		}
	}
}
