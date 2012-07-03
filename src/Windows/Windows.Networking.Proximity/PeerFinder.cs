using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
namespace Windows.Networking.Proximity
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPeerFinderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class PeerFinder
	{
		public static extern event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested
		{
			add;
			remove;
		}
		public static extern event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged
		{
			add;
			remove;
		}
		public static extern bool AllowBluetooth
		{
			get;
			set;
		}
		public static extern bool AllowInfrastructure
		{
			get;
			set;
		}
		public static extern bool AllowWiFiDirect
		{
			get;
			set;
		}
		public static extern IMap<string, string> AlternateIdentities
		{
			get;
		}
		public static extern string DisplayName
		{
			get;
			set;
		}
		public static extern PeerDiscoveryTypes SupportedDiscoveryTypes
		{
			get;
		}
		[DefaultOverload, Overload("Start")]
		public static extern void Start();
		[DefaultOverload, Overload("StartWithMessage")]
		public static extern void Start([In] string peerMessage);
		public static extern void Stop();
		public static extern IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();
		public static extern IAsyncOperation<StreamSocket> ConnectAsync([In] PeerInformation peerInformation);
	}
}
