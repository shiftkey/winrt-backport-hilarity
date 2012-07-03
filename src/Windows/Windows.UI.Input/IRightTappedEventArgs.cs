using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(RightTappedEventArgs)), Guid(1287602365u, 44922, 18998, 148, 118, 177, 220, 225, 65, 112, 154), Version(100794368u)]
	internal interface IRightTappedEventArgs
	{
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		Point Position
		{
			get;
		}
	}
}
