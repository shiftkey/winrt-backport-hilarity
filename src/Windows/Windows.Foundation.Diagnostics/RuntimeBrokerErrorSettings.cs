using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Diagnostics
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class RuntimeBrokerErrorSettings : IErrorReportingSettings
	{
		public extern RuntimeBrokerErrorSettings();
		public extern void SetErrorOptions([In] ErrorOptions value);
		public extern ErrorOptions GetErrorOptions();
	}
}
