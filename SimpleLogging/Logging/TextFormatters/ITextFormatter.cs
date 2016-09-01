using System;

namespace SimpleLogging.Logging.TextFormatters
{
	public interface ITextFormatter
	{
		string Format(LogEntry entry);

		string Format(Exception exception);
	}
}
