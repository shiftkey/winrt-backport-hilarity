using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[Version(100794368u)]
	public sealed class PrintTaskConfiguration : IPrintTaskConfiguration
	{
		public extern event TypedEventHandler<PrintTaskConfiguration, PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested
		{
			add;
			remove;
		}
		public extern object PrinterExtensionContext
		{
			get;
		}
	}
}
