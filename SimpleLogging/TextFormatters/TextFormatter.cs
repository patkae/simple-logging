using System;
using SimpleLogging.Logging;

namespace PwC.Logging.Formatters
{
	public class TextFormatter : ITextFormatter
	{
		public string Format(LogEntry entry)
		{
			string message = entry.Message ?? "";

			if (entry.Exception != null)
			{
				if (message.Length > 0)
					message += ", ";

				message += Format(entry.Exception);
			}

			return String.Format("{0:yyyy-MM-dd hh:mm:ss.fff}\t{1}\t{2}\t{3}\t{4:d}\t{5}", DateTime.UtcNow, entry.Source, entry.Category, entry.Severity, entry.CorrelationId, message);
		}

		public string Format(Exception exception)
		{
			string message = "Exception: " + exception.Message + ", Stack Trace: " + exception.StackTrace;
			return message;
		}
	}
}
