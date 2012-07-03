using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(CompassReadingChangedEventArgs)), Guid(2400537008u, 59580, 19582, 176, 9, 78, 65, 223, 19, 112, 114), Version(100794368u)]
	internal interface ICompassReadingChangedEventArgs
	{
		CompassReading Reading
		{
			get;
		}
	}
}
