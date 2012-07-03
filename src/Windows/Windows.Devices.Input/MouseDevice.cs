using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IMouseDeviceStatics), 100794368u), Version(100794368u)]
	public sealed class MouseDevice : IMouseDevice
	{
		public extern event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved
		{
			add;
			remove;
		}
		public static extern MouseDevice GetForCurrentView();
	}
}
