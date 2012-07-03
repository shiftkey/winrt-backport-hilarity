using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SemanticZoom)), Guid(27262753u, 60646, 20412, 191, 64, 137, 56, 212, 129, 62, 39), Version(100794368u), WebHostHidden]
	internal interface ISemanticZoom
	{
		event SemanticZoomViewChangedEventHandler ViewChangeCompleted;
		event SemanticZoomViewChangedEventHandler ViewChangeStarted;
		bool CanChangeViews
		{
			get;
			set;
		}
		bool IsZoomedInViewActive
		{
			get;
			set;
		}
		ISemanticZoomInformation ZoomedInView
		{
			get;
			set;
		}
		ISemanticZoomInformation ZoomedOutView
		{
			get;
			set;
		}
		void ToggleActiveView();
	}
}
