using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLogging.Logging;
using SimpleLogging.Logging.Providers;
using SimpleLogging.Logging.TextFormatters;

namespace SimpleLogging.UnitTests.ProviderModel
{
	public class TestLogProvider : ILogProvider
	{
		private ITextFormatter _formatter = new TextFormatter();

		public LogEntry Entry { get; set; }

		public void Write(LogEntry entry)
		{
			Entry = entry;
		}
	}
}
