using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToSourceSelectedEventArgs)), Guid(211649809u, 20994, 19915, 140, 103, 171, 218, 18, 187, 60, 18), Version(100794368u)]
	internal interface IPlayToSourceSelectedEventArgs
	{
		string FriendlyName
		{
			get;
		}
		IRandomAccessStreamWithContentType Icon
		{
			get;
		}
		bool SupportsAudio
		{
			get;
		}
		bool SupportsImage
		{
			get;
		}
		bool SupportsVideo
		{
			get;
		}
	}
}
