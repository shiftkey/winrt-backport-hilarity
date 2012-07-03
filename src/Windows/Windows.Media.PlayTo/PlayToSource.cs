using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToSource : IPlayToSource
	{
		public extern PlayToConnection Connection
		{
			get;
		}
		public extern PlayToSource Next
		{
			get;
			set;
		}
		public extern void PlayNext();
	}
}
