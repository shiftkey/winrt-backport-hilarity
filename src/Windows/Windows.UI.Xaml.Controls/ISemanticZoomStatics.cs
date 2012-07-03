using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SemanticZoom)), Guid(2398191346u, 39064, 18022, 178, 133, 62, 211, 138, 7, 145, 14), Version(100794368u), WebHostHidden]
	internal interface ISemanticZoomStatics
	{
		DependencyProperty CanChangeViewsProperty
		{
			get;
		}
		DependencyProperty IsZoomedInViewActiveProperty
		{
			get;
		}
		DependencyProperty ZoomedInViewProperty
		{
			get;
		}
		DependencyProperty ZoomedOutViewProperty
		{
			get;
		}
	}
}
