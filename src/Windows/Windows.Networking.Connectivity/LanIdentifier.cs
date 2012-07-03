using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LanIdentifier : ILanIdentifier
	{
		public extern LanIdentifierData InfrastructureId
		{
			get;
		}
		public extern Guid NetworkAdapterId
		{
			get;
		}
		public extern LanIdentifierData PortId
		{
			get;
		}
	}
}
