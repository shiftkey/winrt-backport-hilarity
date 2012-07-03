using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[Version(100794368u)]
	public sealed class PrintTaskConfigurationSaveRequest : IPrintTaskConfigurationSaveRequest
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern void Cancel();
		public extern void Save([In] object printerExtensionContext);
		public extern PrintTaskConfigurationSaveRequestedDeferral GetDeferral();
	}
}
