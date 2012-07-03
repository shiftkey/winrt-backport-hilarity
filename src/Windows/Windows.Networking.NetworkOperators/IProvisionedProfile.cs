using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(ProvisionedProfile)), Guid(561447136u, 33282, 4575, 173, 185, 244, 206, 70, 45, 145, 55), Version(100794368u)]
	internal interface IProvisionedProfile
	{
		void UpdateCost([In] NetworkCostType value);
		void UpdateUsage([In] ProfileUsage value);
	}
}
