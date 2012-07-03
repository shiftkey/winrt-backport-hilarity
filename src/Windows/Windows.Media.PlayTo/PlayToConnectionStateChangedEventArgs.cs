using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToConnectionStateChangedEventArgs : IPlayToConnectionStateChangedEventArgs
	{
		public extern PlayToConnectionState CurrentState
		{
			get;
		}
		public extern PlayToConnectionState PreviousState
		{
			get;
		}
	}
}
