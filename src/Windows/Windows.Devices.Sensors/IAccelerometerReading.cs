using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(AccelerometerReading)), Guid(3120462539u, 54097, 16559, 139, 182, 122, 169, 174, 100, 31, 183), Version(100794368u)]
	internal interface IAccelerometerReading
	{
		double AccelerationX
		{
			get;
		}
		double AccelerationY
		{
			get;
		}
		double AccelerationZ
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
