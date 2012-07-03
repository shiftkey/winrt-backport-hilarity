using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Static(typeof(IUssdSessionStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class UssdSession : IUssdSession
	{
		public extern IAsyncOperation<UssdReply> SendMessageAndGetReplyAsync([In] UssdMessage message);
		public extern void Close();
		public static extern UssdSession CreateFromNetworkAccountId([In] string networkAccountId);
		public static extern UssdSession CreateFromNetworkInterfaceId([In] string networkInterfaceId);
	}
}
