using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToConnectionErrorEventArgs : IPlayToConnectionErrorEventArgs
	{
		public extern PlayToConnectionError Code
		{
			get;
		}
		public extern string Message
		{
			get;
		}
	}
}
