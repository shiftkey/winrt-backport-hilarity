using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(SensorQuaternion)), Guid(3385182247u, 50972, 18151, 157, 163, 54, 161, 147, 178, 50, 188), Version(100794368u)]
	internal interface ISensorQuaternion
	{
		float W
		{
			get;
		}
		float X
		{
			get;
		}
		float Y
		{
			get;
		}
		float Z
		{
			get;
		}
	}
}
