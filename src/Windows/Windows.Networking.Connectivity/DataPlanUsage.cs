using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPlanUsage : IDataPlanUsage
	{
		public extern DateTime LastSyncTime
		{
			get;
		}
		public extern uint MegabytesUsed
		{
			get;
		}
	}
}
