using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintTaskConfigurationSaveRequestedDeferral)), Guid(3914978664u, 63273, 17572, 135, 29, 189, 6, 40, 105, 106, 51), Version(100794368u)]
	internal interface IPrintTaskConfigurationSaveRequestedDeferral
	{
		void Complete();
	}
}
