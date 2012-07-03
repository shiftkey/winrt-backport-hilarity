using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(HoldingEventArgs)), Guid(737629637u, 59289, 16820, 187, 64, 36, 47, 64, 149, 155, 113), Version(100794368u)]
	internal interface IHoldingEventArgs
	{
		HoldingState HoldingState
		{
			get;
		}
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
