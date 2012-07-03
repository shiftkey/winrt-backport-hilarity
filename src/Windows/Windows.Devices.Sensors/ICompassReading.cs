using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(CompassReading)), Guid(2190545192u, 20797, 19913, 183, 129, 94, 237, 251, 240, 45, 12), Version(100794368u)]
	internal interface ICompassReading
	{
		double HeadingMagneticNorth
		{
			get;
		}
		IReference<double> HeadingTrueNorth
		{
			get;
		}
		DateTime Timestamp
		{
			get;
		}
	}
}
