using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLogging.Logging;

namespace SimpleLogging.Examples
{
	/// <summary>
	/// Logger using a function to write the entry
	/// </summary>
	public class FunctionLogger : LoggerBase
	{
		private Action<LogEntry> _logAction;

		public FunctionLogger(Action<LogEntry> logAction)
		{
			_logAction = logAction;
		}

		protected override void Write(LogEntry entry)
		{
			_logAction(entry);
		}
	}
}
