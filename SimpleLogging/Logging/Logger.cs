using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLogging.Logging.Providers;

namespace SimpleLogging.Logging
{
	/// <summary>
	/// Singleton logger using the provider pattern
	/// </summary>
	public class Logger : LoggerBase
	{
		#region Instance Members
		protected Logger() : base()
		{
		}

		protected Logger(string source) : base(source)
		{
		}

		protected override void Write(LogEntry entry)
		{
			_provider.Write(entry);
		}
		#endregion

		#region Static Members
		// Provider based logger example
		private static ILogProvider _provider = new TraceLogProvider();

		public static void SetProvider(ILogProvider provider)
		{
			_provider = provider;
		}

		private static ILogger _current = new Logger();

		public static ILogger Current
		{
			get { return _current; }
		}
		#endregion
	}
}
