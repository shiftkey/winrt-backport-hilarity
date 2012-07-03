using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(DataPlanStatus)), Guid(2541390732u, 14469, 16627, 136, 81, 66, 205, 43, 213, 104, 187), Version(100794368u)]
	internal interface IDataPlanStatus
	{
		IReference<uint> DataLimitInMegabytes
		{
			get;
		}
		DataPlanUsage DataPlanUsage
		{
			get;
		}
		IReference<ulong> InboundBitsPerSecond
		{
			get;
		}
		IReference<uint> MaxTransferSizeInMegabytes
		{
			get;
		}
		IReference<DateTime> NextBillingCycle
		{
			get;
		}
		IReference<ulong> OutboundBitsPerSecond
		{
			get;
		}
	}
}
