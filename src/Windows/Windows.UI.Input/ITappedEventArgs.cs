using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(TappedEventArgs)), Guid(3483444964u, 9530, 19516, 149, 59, 57, 92, 55, 174, 211, 9), Version(100794368u)]
	internal interface ITappedEventArgs
	{
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point Position
		{
			get;
		}
		uint TapCount
		{
			get;
		}
	}
}
