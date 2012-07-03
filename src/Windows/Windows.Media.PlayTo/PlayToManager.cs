using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPlayToManagerStatics), 100794368u), Version(100794368u)]
	public sealed class PlayToManager : IPlayToManager
	{
		public extern event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected
		{
			add;
			remove;
		}
		public extern bool DefaultSourceSelection
		{
			get;
			set;
		}
		public static extern PlayToManager GetForCurrentView();
		public static extern void ShowPlayToUI();
	}
}
