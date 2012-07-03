using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToConnection : IPlayToConnection
	{
		public extern event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred
		{
			add;
			remove;
		}
		public extern PlayToConnectionState State
		{
			get;
		}
	}
}
