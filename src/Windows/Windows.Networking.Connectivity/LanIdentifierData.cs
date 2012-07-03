using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LanIdentifierData : ILanIdentifierData
	{
		public extern uint Type
		{
			get;
		}
		public extern IVectorView<byte> Value
		{
			get;
		}
	}
}
