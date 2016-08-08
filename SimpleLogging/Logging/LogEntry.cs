using System;

namespace SimpleLogging.Logging
{
	public class LogEntry
	{
		public LogEntry()
		{
			EventDateUtc = DateTime.UtcNow;
		}

		public LogEntry(string message, LogSeverity severity) : this(message, null, null, severity)
		{

		}

		public LogEntry(string message, string source, string category, LogSeverity severity)
		{
			Message = message;
			Severity = severity;
			Source = source;
			Category = category;
			EventDateUtc = DateTime.UtcNow;
		}

		#region properties

		/// <summary>
		/// The logged message body. Defaults to
		/// <c>String.Empty</c>.
		/// </summary>
		public string Message { get; set; }

		public LogSeverity Severity { get; set; }

		/// <summary>
		/// Date and time of the log entry. If not explicitly
		/// set, this property provides the timestamp of
		/// the object's creation.
		/// </summary>
		public DateTime EventDateUtc { get; set; }

		/// <summary>
		/// Allows to attach an exception to the message.
		/// Defaults to <c>null</c>.
		/// </summary>
		public Exception Exception { get; set; }

		public string Source { get; set; }

		public string Category { get; set; }

		public Guid CorrelationId { get; set; }
		#endregion
	}
}
