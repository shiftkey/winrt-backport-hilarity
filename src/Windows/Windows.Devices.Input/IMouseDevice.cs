using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(MouseDevice)), Guid(2297295960u, 62152, 18932, 190, 31, 194, 86, 179, 136, 188, 17), Version(100794368u)]
	internal interface IMouseDevice
	{
		event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;
	}
}
