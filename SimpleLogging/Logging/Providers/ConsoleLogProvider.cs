using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLogging.Logging.TextFormatters;

namespace SimpleLogging.Logging.Providers
{
	public class ConsoleLogProvider : ILogProvider
	{
		private ITextFormatter _formatter = new TextFormatter();


		public void Write(LogEntry entry)
		{
			Console.WriteLine(_formatter.Format(entry));
		}
	}
}
