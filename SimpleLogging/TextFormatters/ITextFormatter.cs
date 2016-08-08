using System;
using SimpleLogging.Logging;

namespace PwC.Logging
{
	public interface ITextFormatter
	{
		string Format(LogEntry entry);

		string Format(Exception exception);
	}
}
