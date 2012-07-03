using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(PeerFinder)), Guid(2437626721u, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198), Version(100794368u)]
	internal interface IPeerFinderStatics
	{
		event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;
		event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;
		bool AllowBluetooth
		{
			get;
			set;
		}
		bool AllowInfrastructure
		{
			get;
			set;
		}
		bool AllowWiFiDirect
		{
			get;
			set;
		}
		IMap<string, string> AlternateIdentities
		{
			get;
		}
		string DisplayName
		{
			get;
			set;
		}
		PeerDiscoveryTypes SupportedDiscoveryTypes
		{
			get;
		}
		[DefaultOverload, Overload("Start")]
		void Start();
		[DefaultOverload, Overload("StartWithMessage")]
		void Start([In] string peerMessage);
		void Stop();
		IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();
		IAsyncOperation<StreamSocket> ConnectAsync([In] PeerInformation peerInformation);
	}
}
