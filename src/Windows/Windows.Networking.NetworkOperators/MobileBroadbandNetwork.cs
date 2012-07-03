using System;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class MobileBroadbandNetwork : IMobileBroadbandNetwork
	{
		public extern string AccessPointName
		{
			get;
		}
		public extern uint ActivationNetworkError
		{
			get;
		}
		public extern NetworkAdapter NetworkAdapter
		{
			get;
		}
		public extern NetworkRegistrationState NetworkRegistrationState
		{
			get;
		}
		public extern uint PacketAttachNetworkError
		{
			get;
		}
		public extern DataClasses RegisteredDataClass
		{
			get;
		}
		public extern string RegisteredProviderId
		{
			get;
		}
		public extern string RegisteredProviderName
		{
			get;
		}
		public extern uint RegistrationNetworkError
		{
			get;
		}
		public extern void ShowConnectionUI();
	}
}
