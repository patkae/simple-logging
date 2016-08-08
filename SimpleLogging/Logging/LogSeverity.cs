namespace SimpleLogging.Logging
{
	/// <summary>
	/// Event log log severity. Any exception in the application will be logged in event log under event severity as Error
	/// Although ILogger interface will expose methods for developers to writeevent logs under warning, Informational.
	/// </summary>
	public enum LogSeverity
	{
		None = 0,
		Critical = 30,
		Error = 40,
		Warning = 50,
		Informational = 80,
		Verbose = 100
	}
}
