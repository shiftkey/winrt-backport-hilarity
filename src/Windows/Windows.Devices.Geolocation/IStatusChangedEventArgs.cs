using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(StatusChangedEventArgs)), Guid(877908698u, 35987, 16657, 162, 5, 154, 236, 252, 155, 229, 192), Version(100794368u)]
	internal interface IStatusChangedEventArgs
	{
		PositionStatus Status
		{
			get;
		}
	}
}
