using System;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandNetwork)), Guid(3412300428u, 777, 19638, 168, 193, 106, 90, 60, 142, 31, 246), Version(100794368u)]
	internal interface IMobileBroadbandNetwork
	{
		string AccessPointName
		{
			get;
		}
		uint ActivationNetworkError
		{
			get;
		}
		NetworkAdapter NetworkAdapter
		{
			get;
		}
		NetworkRegistrationState NetworkRegistrationState
		{
			get;
		}
		uint PacketAttachNetworkError
		{
			get;
		}
		DataClasses RegisteredDataClass
		{
			get;
		}
		string RegisteredProviderId
		{
			get;
		}
		string RegisteredProviderName
		{
			get;
		}
		uint RegistrationNetworkError
		{
			get;
		}
		void ShowConnectionUI();
	}
}
