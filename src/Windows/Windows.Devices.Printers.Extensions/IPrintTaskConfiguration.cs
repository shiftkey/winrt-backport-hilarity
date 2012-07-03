using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintTaskConfiguration)), Guid(3821151313u, 15012, 18565, 146, 64, 49, 31, 95, 143, 190, 157), Version(100794368u)]
	internal interface IPrintTaskConfiguration
	{
		event TypedEventHandler<PrintTaskConfiguration, PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested;
		object PrinterExtensionContext
		{
			get;
		}
	}
}
