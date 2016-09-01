using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLogging.Examples;
using SimpleLogging.Logging;

namespace SimpleLogging.UnitTests.FunctionLogger
{
	[TestClass]
	public class FunctionLoggerTests
	{
		[TestMethod]
		public void LogTest()
		{
			var func = new LogFunction();
			var logger = new Examples.FunctionLogger(func.WriteLog);

			var expected = new LogEntry()
			{
				Source = AppDomain.CurrentDomain.FriendlyName
			};

			expected.Severity = LogSeverity.Critical;
			expected.Message = "Critical Message";
			logger.LogCritical(expected.Message);
			AssertEntry(expected, func.Entry, "LogCritical");

			expected.Severity = LogSeverity.Error;
			expected.Message = "Error Message";
			logger.LogError(expected.Message);
			AssertEntry(expected, func.Entry, "LogError");

			expected.Severity = LogSeverity.Warning;
			expected.Message = "Warning Message";
			logger.LogWarning(expected.Message);
			AssertEntry(expected, func.Entry, "LogWarning");

			expected.Severity = LogSeverity.Informational;
			expected.Message = "Info Message";
			logger.LogInfo(expected.Message);
			AssertEntry(expected, func.Entry, "LogInfo");

			expected.Severity = LogSeverity.Verbose;
			expected.Message = "Verbose Message";
			logger.LogVerbose(expected.Message);
			AssertEntry(expected, func.Entry, "LogVerbose");
		}

		private void AssertEntry(LogEntry expected, LogEntry actual, string message)
		{
			Assert.AreEqual(expected.Category, actual.Category, message + " Category");
			Assert.AreEqual(expected.CorrelationId, actual.CorrelationId, message + " CorrelationId");
			Assert.AreEqual(expected.Message, actual.Message, message + " Message");
			Assert.AreEqual(expected.Severity, actual.Severity, message + " Severity");
			Assert.AreEqual(expected.Source, actual.Source, message + " Source");

			Assert.AreEqual(expected.Exception, actual.Exception, message + " Exception");
		}
	}
}
