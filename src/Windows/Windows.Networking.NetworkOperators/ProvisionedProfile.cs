using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class ProvisionedProfile : IProvisionedProfile
	{
		public extern void UpdateCost([In] NetworkCostType value);
		public extern void UpdateUsage([In] ProfileUsage value);
	}
}
