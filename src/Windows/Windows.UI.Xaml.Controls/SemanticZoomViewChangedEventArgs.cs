using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SemanticZoomViewChangedEventArgs : ISemanticZoomViewChangedEventArgs
	{
		public extern SemanticZoomLocation DestinationItem
		{
			get;
			set;
		}
		public extern bool IsSourceZoomedInView
		{
			get;
			set;
		}
		public extern SemanticZoomLocation SourceItem
		{
			get;
			set;
		}
		public extern SemanticZoomViewChangedEventArgs();
	}
}
