using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(Inclinometer)), Guid(4063151441u, 39984, 17722, 139, 73, 60, 62, 235, 51, 203, 97), Version(100794368u)]
	internal interface IInclinometerStatics
	{
		Inclinometer GetDefault();
	}
}
