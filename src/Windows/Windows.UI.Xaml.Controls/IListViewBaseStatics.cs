using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListViewBase)), Guid(2234693879u, 15894, 17755, 137, 168, 193, 52, 98, 35, 246, 211), Version(100794368u), WebHostHidden]
	internal interface IListViewBaseStatics
	{
		DependencyProperty CanDragItemsProperty
		{
			get;
		}
		DependencyProperty CanReorderItemsProperty
		{
			get;
		}
		DependencyProperty DataFetchSizeProperty
		{
			get;
		}
		DependencyProperty HeaderProperty
		{
			get;
		}
		DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		DependencyProperty HeaderTransitionsProperty
		{
			get;
		}
		DependencyProperty IncrementalLoadingThresholdProperty
		{
			get;
		}
		DependencyProperty IncrementalLoadingTriggerProperty
		{
			get;
		}
		DependencyProperty IsActiveViewProperty
		{
			get;
		}
		DependencyProperty IsItemClickEnabledProperty
		{
			get;
		}
		DependencyProperty IsSwipeEnabledProperty
		{
			get;
		}
		DependencyProperty IsZoomedInViewProperty
		{
			get;
		}
		DependencyProperty SelectionModeProperty
		{
			get;
		}
		DependencyProperty SemanticZoomOwnerProperty
		{
			get;
		}
	}
}
