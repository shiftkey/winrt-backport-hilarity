using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(GyrometerReading)), Guid(3017203292u, 7908, 17775, 157, 231, 226, 73, 59, 92, 142, 3), Version(100794368u)]
	internal interface IGyrometerReading
	{
		double AngularVelocityX
		{
			get;
		}
		double AngularVelocityY
		{
			get;
		}
		double AngularVelocityZ
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
