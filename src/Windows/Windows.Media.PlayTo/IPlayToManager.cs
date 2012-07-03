using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToManager)), Guid(4117373038u, 7031, 17135, 143, 13, 185, 73, 248, 217, 178, 96), Version(100794368u)]
	internal interface IPlayToManager
	{
		event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;
		event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;
		bool DefaultSourceSelection
		{
			get;
			set;
		}
	}
}
