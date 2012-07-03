using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SensorRotationMatrix : ISensorRotationMatrix
	{
		public extern float M11
		{
			get;
		}
		public extern float M12
		{
			get;
		}
		public extern float M13
		{
			get;
		}
		public extern float M21
		{
			get;
		}
		public extern float M22
		{
			get;
		}
		public extern float M23
		{
			get;
		}
		public extern float M31
		{
			get;
		}
		public extern float M32
		{
			get;
		}
		public extern float M33
		{
			get;
		}
	}
}
