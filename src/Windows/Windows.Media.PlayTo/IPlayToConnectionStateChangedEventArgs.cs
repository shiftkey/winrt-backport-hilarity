using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToConnectionStateChangedEventArgs)), Guid(1757721871u, 3104, 18816, 134, 2, 88, 198, 34, 56, 212, 35), Version(100794368u)]
	internal interface IPlayToConnectionStateChangedEventArgs
	{
		PlayToConnectionState CurrentState
		{
			get;
		}
		PlayToConnectionState PreviousState
		{
			get;
		}
	}
}
