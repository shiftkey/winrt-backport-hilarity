using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPlanStatus : IDataPlanStatus
	{
		public extern IReference<uint> DataLimitInMegabytes
		{
			get;
		}
		public extern DataPlanUsage DataPlanUsage
		{
			get;
		}
		public extern IReference<ulong> InboundBitsPerSecond
		{
			get;
		}
		public extern IReference<uint> MaxTransferSizeInMegabytes
		{
			get;
		}
		public extern IReference<DateTime> NextBillingCycle
		{
			get;
		}
		public extern IReference<ulong> OutboundBitsPerSecond
		{
			get;
		}
	}
}
