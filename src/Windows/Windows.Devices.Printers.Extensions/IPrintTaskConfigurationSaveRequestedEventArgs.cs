using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintTaskConfigurationSaveRequestedEventArgs)), Guid(3765184633u, 3425, 18744, 145, 208, 150, 164, 91, 238, 132, 121), Version(100794368u)]
	internal interface IPrintTaskConfigurationSaveRequestedEventArgs
	{
		PrintTaskConfigurationSaveRequest Request
		{
			get;
		}
	}
}
