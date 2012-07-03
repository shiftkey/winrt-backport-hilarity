using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[Version(100794368u)]
	public struct PointerDeviceUsage
	{
		public uint UsagePage;
		public uint Usage;
		public int MinLogical;
		public int MaxLogical;
		public int MinPhysical;
		public int MaxPhysical;
		public uint Unit;
		public float PhysicalMultiplier;
	}
}
