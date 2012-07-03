using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both)]
	public sealed class RuntimeBrokerErrorSettings : IErrorReportingSettings
	{
		public extern RuntimeBrokerErrorSettings();
		public extern void SetErrorOptions(ErrorOptions value);
		public extern ErrorOptions GetErrorOptions();
	}
}
