using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SimpleLogging.Logging.TextFormatters;

namespace SimpleLogging.Logging.Providers
{
	public class TraceLogProvider : ILogProvider
	{
		private ITextFormatter _formatter = new TextFormatter();

		public void Write(LogEntry entry)
		{
			Trace.WriteLine(_formatter.Format(entry));
		}
	}
}
