using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToConnectionTransferredEventArgs)), Guid(4209187130u, 1667, 18393, 141, 240, 24, 203, 180, 137, 132, 216), Version(100794368u)]
	internal interface IPlayToConnectionTransferredEventArgs
	{
		PlayToSource CurrentSource
		{
			get;
		}
		PlayToSource PreviousSource
		{
			get;
		}
	}
}
