namespace ProcessMonitor.Models
{
	public class ProcessModel
	{
		public int Id { get; set; }
		public string ProcessName { get; set; }
		public long VirtualMemorySize64 { get; set; }
	}
}
