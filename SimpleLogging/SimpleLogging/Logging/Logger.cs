using System;

namespace SimpleLogging.Logging
{
	public abstract class Logger
	{
		public string Source { get; set; }

		protected Logger()
		{
			Source = AppDomain.CurrentDomain.FriendlyName;
		}

		protected Logger(string source)
		{
			Source = source;
		}

		#region Core methods

		protected abstract void Write(LogEntry entry);

		protected virtual void EnsureDefaults(LogEntry entry)
		{
			if (entry.CorrelationId == Guid.Empty)
				entry.CorrelationId = System.Diagnostics.Trace.CorrelationManager.ActivityId;
		

			if (entry.Exception != null)
			{
				if (entry.Severity == LogSeverity.None)
					entry.Severity = LogSeverity.Error;

				if (String.IsNullOrEmpty(entry.Message))
					entry.Message = entry.Exception.Message;
			}

			if (entry.Severity == LogSeverity.None)
				entry.Severity = LogSeverity.Informational;
		}
		
		public void Log(string category, LogSeverity severity, Exception exception, string message, params object[] args)
		{
			var entry = new LogEntry(message, Source, category, severity)
			{
				Exception = exception
			};

			if (message != null && args != null && args.Length > 0)
			{
				entry.Message = String.Format(message, args);
			}

			EnsureDefaults(entry);
			Write(entry);
		}

		#endregion

		#region Default Log methods

		public void Log(string message, params object[] args)
		{
			Log(null, LogSeverity.None, null, message, args);
		}

		public void Log(Exception exception)
		{
			Log(null, LogSeverity.None, exception, null, null);
		}

		public void Log(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.None, exception, message, args);
		}

		public void Log(LogSeverity severity, Exception exception, string message, params object[] args)
		{
			Log(null, severity, exception, message, args);
		}

		#endregion

		#region LogCritical methods
		public void LogCritical(string message, params object[] args)
		{
			Log(null, LogSeverity.Critical, null, message, args);
		}

		public void LogCritical(Exception exception)
		{
			Log(null, LogSeverity.Critical, exception, null, null);
		}

		public void LogCritical(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.Critical, exception, message, args);
		}
		#endregion

		#region LogError methods
		public void LogError(string message, params object[] args)
		{
			Log(null, LogSeverity.Error, null, message, args);
		}

		public void LogError(Exception exception)
		{
			Log(null, LogSeverity.Error, exception, null, null);
		}

		public void LogError(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.Error, exception, message, args);
		}
		#endregion

		#region LogWarning methods
		public void LogWarning(string message, params object[] args)
		{
			Log(null, LogSeverity.Warning, null, message, args);
		}

		public void LogWarning(Exception exception)
		{
			Log(null, LogSeverity.Warning, exception, null, null);
		}

		public void LogWarning(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.Warning, exception, message, args);
		}
		#endregion

		#region LogInfo methods
		public void LogInfo(string message, params object[] args)
		{
			Log(null, LogSeverity.Informational, null, message, args);
		}

		public void LogInfo(Exception exception)
		{
			Log(null, LogSeverity.Informational, exception, null, null);
		}

		public void LogInfo(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.Informational, exception, message, args);
		}
		#endregion

		#region LogVerbose methods
		public void LogVerbose(string message, params object[] args)
		{
			Log(null, LogSeverity.Verbose, null, message, args);
		}

		public void LogVerbose(Exception exception)
		{
			Log(null, LogSeverity.Verbose, exception, null, null);
		}

		public void LogVerbose(Exception exception, string message, params object[] args)
		{
			Log(null, LogSeverity.Verbose, exception, message, args);
		}
		#endregion
	}
}
