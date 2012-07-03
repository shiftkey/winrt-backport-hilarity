using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(MouseCapabilities)), Guid(3164987427u, 32217, 19307, 154, 146, 85, 212, 60, 179, 143, 115), Version(100794368u)]
	internal interface IMouseCapabilities
	{
		int HorizontalWheelPresent
		{
			get;
		}
		int MousePresent
		{
			get;
		}
		uint NumberOfButtons
		{
			get;
		}
		int SwapButtons
		{
			get;
		}
		int VerticalWheelPresent
		{
			get;
		}
	}
}
