using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class EnclosureLocation : IEnclosureLocation
	{
		public extern bool InDock
		{
			get;
		}
		public extern bool InLid
		{
			get;
		}
		public extern Panel Panel
		{
			get;
		}
	}
}
