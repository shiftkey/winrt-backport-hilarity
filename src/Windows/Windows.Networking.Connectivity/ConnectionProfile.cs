using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ConnectionProfile : IConnectionProfile
	{
		public extern NetworkAdapter NetworkAdapter
		{
			get;
		}
		public extern NetworkSecuritySettings NetworkSecuritySettings
		{
			get;
		}
		public extern string ProfileName
		{
			get;
		}
		public extern NetworkConnectivityLevel GetNetworkConnectivityLevel();
		public extern IVectorView<string> GetNetworkNames();
		public extern ConnectionCost GetConnectionCost();
		public extern DataPlanStatus GetDataPlanStatus();
		[DefaultOverload, Overload("GetLocalUsage")]
		public extern DataUsage GetLocalUsage([In] DateTime StartTime, [In] DateTime EndTime);
		[DefaultOverload, Overload("GetLocalUsagePerRoamingStates")]
		public extern DataUsage GetLocalUsage([In] DateTime StartTime, [In] DateTime EndTime, [In] RoamingStates States);
	}
}
