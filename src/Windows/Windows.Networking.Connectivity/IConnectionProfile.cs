using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(ConnectionProfile)), Guid(1908020284u, 22926, 18896, 132, 235, 143, 235, 174, 220, 193, 149), Version(100794368u)]
	internal interface IConnectionProfile
	{
		NetworkAdapter NetworkAdapter
		{
			get;
		}
		NetworkSecuritySettings NetworkSecuritySettings
		{
			get;
		}
		string ProfileName
		{
			get;
		}
		NetworkConnectivityLevel GetNetworkConnectivityLevel();
		IVectorView<string> GetNetworkNames();
		ConnectionCost GetConnectionCost();
		DataPlanStatus GetDataPlanStatus();
		[DefaultOverload, Overload("GetLocalUsage")]
		DataUsage GetLocalUsage([In] DateTime StartTime, [In] DateTime EndTime);
		[DefaultOverload, Overload("GetLocalUsagePerRoamingStates")]
		DataUsage GetLocalUsage([In] DateTime StartTime, [In] DateTime EndTime, [In] RoamingStates States);
	}
}
