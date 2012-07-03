using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(MouseEventArgs)), Guid(4129663581u, 9044, 19655, 146, 48, 150, 148, 28, 150, 159, 222), Version(100794368u)]
	internal interface IMouseEventArgs
	{
		MouseDelta MouseDelta
		{
			get;
		}
	}
}
