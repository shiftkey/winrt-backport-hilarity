using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[ExclusiveTo(typeof(SensorRotationMatrix)), Guid(171792999u, 8948, 17298, 149, 56, 101, 208, 189, 6, 74, 166), Version(100794368u)]
	internal interface ISensorRotationMatrix
	{
		float M11
		{
			get;
		}
		float M12
		{
			get;
		}
		float M13
		{
			get;
		}
		float M21
		{
			get;
		}
		float M22
		{
			get;
		}
		float M23
		{
			get;
		}
		float M31
		{
			get;
		}
		float M32
		{
			get;
		}
		float M33
		{
			get;
		}
	}
}
