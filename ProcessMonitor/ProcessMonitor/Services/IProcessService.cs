using ProcessMonitor.Models;
using System.Collections.Generic;

namespace ProcessMonitor.Services
{
	public interface IProcessService
	{
		IEnumerable<ProcessModel> Get();
	}
}
