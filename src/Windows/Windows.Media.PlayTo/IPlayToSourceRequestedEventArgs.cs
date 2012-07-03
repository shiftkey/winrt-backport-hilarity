using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToSourceRequestedEventArgs)), Guid(3318596400u, 10719, 20166, 157, 169, 159, 189, 252, 252, 27, 62), Version(100794368u)]
	internal interface IPlayToSourceRequestedEventArgs
	{
		PlayToSourceRequest SourceRequest
		{
			get;
		}
	}
}
