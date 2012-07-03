using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class MouseEventArgs : IMouseEventArgs
	{
		public extern MouseDelta MouseDelta
		{
			get;
		}
	}
}
