using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[Version(100794368u)]
	public sealed class PrintTaskConfigurationSaveRequestedDeferral : IPrintTaskConfigurationSaveRequestedDeferral
	{
		public extern void Complete();
	}
}
