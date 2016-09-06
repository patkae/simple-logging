using SimpleLogging.Logging;

namespace SimpleLogging.UnitTests.FunctionLogger
{
	public class LogFunction
	{
		public LogEntry Entry { get; set; }

		public void WriteLog(LogEntry entry)
		{
			Entry = entry;
		}
	}
}
