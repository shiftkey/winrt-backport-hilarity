using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(InclinometerReadingChangedEventArgs)), Guid(1256791489u, 59371, 18744, 133, 17, 174, 13, 107, 68, 4, 56), Version(100794368u)]
	internal interface IInclinometerReadingChangedEventArgs
	{
		InclinometerReading Reading
		{
			get;
		}
	}
}
