using System.Collections.Generic;
using System.Linq;
using ProcessMonitor.Models;

namespace ProcessMonitor.Services
{
	public class ProcessService : IProcessService
	{
		public IEnumerable<ProcessModel> Get()
		{
			var processes = System.Diagnostics.Process.GetProcesses()
				.Select(o => new ProcessModel { Id = o.Id, ProcessName = o.ProcessName, VirtualMemorySize64 = o.VirtualMemorySize64 })
				.OrderByDescending(o => o.VirtualMemorySize64);

			return processes;
		}
	}
}
