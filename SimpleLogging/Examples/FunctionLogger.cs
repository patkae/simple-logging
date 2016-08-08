using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLogging.Logging;

namespace SimpleLogging.Examples
{
	public class FunctionLogger : Logger
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
