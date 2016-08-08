using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PwC.Logging.Formatters;
using SimpleLogging.Logging;

namespace SimpleLogging.UnitTests
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
