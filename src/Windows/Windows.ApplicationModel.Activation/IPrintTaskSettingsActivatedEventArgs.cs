using System;
using Windows.Devices.Printers.Extensions;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3996164297u, 52822, 18533, 186, 142, 137, 84, 172, 39, 17, 7), Version(100794368u)]
	public interface IPrintTaskSettingsActivatedEventArgs : IActivatedEventArgs
	{
		PrintTaskConfiguration Configuration
		{
			get;
		}
	}
}
