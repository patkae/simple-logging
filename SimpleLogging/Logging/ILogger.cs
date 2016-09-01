using System;

namespace SimpleLogging.Logging
{
	public interface ILogger
	{
		void Log(string category, LogSeverity severity, Exception exception, string message, params object[] args);
		void Log(string message, params object[] args);
		void Log(Exception exception);
		void Log(Exception exception, string message, params object[] args);
		void Log(LogSeverity severity, Exception exception, string message, params object[] args);
		void LogCritical(string message, params object[] args);
		void LogCritical(Exception exception);
		void LogCritical(Exception exception, string message, params object[] args);
		void LogError(string message, params object[] args);
		void LogError(Exception exception);
		void LogError(Exception exception, string message, params object[] args);
		void LogWarning(string message, params object[] args);
		void LogWarning(Exception exception);
		void LogWarning(Exception exception, string message, params object[] args);
		void LogInfo(string message, params object[] args);
		void LogInfo(Exception exception);
		void LogInfo(Exception exception, string message, params object[] args);
		void LogVerbose(string message, params object[] args);
		void LogVerbose(Exception exception);
		void LogVerbose(Exception exception, string message, params object[] args);
	}
}