using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SemanticZoomViewChangedEventArgs)), Guid(1205846120u, 46441, 19225, 132, 45, 142, 108, 249, 9, 137, 175), Version(100794368u), WebHostHidden]
	internal interface ISemanticZoomViewChangedEventArgs
	{
		SemanticZoomLocation DestinationItem
		{
			get;
			set;
		}
		bool IsSourceZoomedInView
		{
			get;
			set;
		}
		SemanticZoomLocation SourceItem
		{
			get;
			set;
		}
	}
}
