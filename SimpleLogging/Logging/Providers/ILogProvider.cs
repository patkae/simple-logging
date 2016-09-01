using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLogging.Logging.Providers
{
	public interface ILogProvider
	{
		void Write(LogEntry entry);
	}
}
