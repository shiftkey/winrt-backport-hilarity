using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(AccelerometerShakenEventArgs)), Guid(2516517329u, 18984, 20277, 152, 232, 129, 120, 170, 228, 8, 74), Version(100794368u)]
	internal interface IAccelerometerShakenEventArgs
	{
		DateTime Timestamp
		{
			get;
		}
	}
}
