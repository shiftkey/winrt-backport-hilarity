using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(InclinometerReading)), Guid(2672095317u, 46838, 18815, 177, 39, 26, 119, 94, 80, 20, 88), Version(100794368u)]
	internal interface IInclinometerReading
	{
		float PitchDegrees
		{
			get;
		}
		float RollDegrees
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
		float YawDegrees
		{
			get;
		}
	}
}
