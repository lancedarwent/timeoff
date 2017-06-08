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


	}

	public class RequestService : IRequestService
	{


	}
}
