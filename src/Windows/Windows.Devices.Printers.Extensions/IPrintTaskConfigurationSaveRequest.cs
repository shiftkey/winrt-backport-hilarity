using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintTaskConfigurationSaveRequest)), Guid(4004458443u, 25118, 19298, 172, 119, 178, 129, 204, 224, 141, 96), Version(100794368u)]
	internal interface IPrintTaskConfigurationSaveRequest
	{
		DateTime Deadline
		{
			get;
		}
		void Cancel();
		void Save([In] object printerExtensionContext);
		PrintTaskConfigurationSaveRequestedDeferral GetDeferral();
	}
}
