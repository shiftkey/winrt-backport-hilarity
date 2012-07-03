using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToConnection)), Guid(288341960u, 62005, 20446, 141, 65, 155, 242, 124, 158, 154, 64), Version(100794368u)]
	internal interface IPlayToConnection
	{
		event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;
		event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;
		event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;
		PlayToConnectionState State
		{
			get;
		}
	}
}
