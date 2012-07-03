using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(PointerPoint)), Guid(3918868861u, 29334, 17113, 130, 51, 197, 190, 115, 183, 74, 74), Version(100794368u)]
	internal interface IPointerPoint
	{
		uint FrameId
		{
			get;
		}
		bool IsInContact
		{
			get;
		}
		PointerDevice PointerDevice
		{
			get;
		}
		uint PointerId
		{
			get;
		}
		Point Position
		{
			get;
		}
		PointerPointProperties Properties
		{
			get;
		}
		Point RawPosition
		{
			get;
		}
		ulong Timestamp
		{
			get;
		}
	}
}
