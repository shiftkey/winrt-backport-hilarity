using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToConnectionTransferredEventArgs : IPlayToConnectionTransferredEventArgs
	{
		public extern PlayToSource CurrentSource
		{
			get;
		}
		public extern PlayToSource PreviousSource
		{
			get;
		}
	}
}
