using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListViewBase)), Guid(1023939514u, 26768, 17719, 191, 229, 121, 109, 148, 88, 237, 214), Version(100794368u), WebHostHidden]
	internal interface IListViewBase
	{
		event DragItemsStartingEventHandler DragItemsStarting;
		event ItemClickEventHandler ItemClick;
		bool CanDragItems
		{
			get;
			set;
		}
		bool CanReorderItems
		{
			get;
			set;
		}
		double DataFetchSize
		{
			get;
			set;
		}
		object Header
		{
			get;
			set;
		}
		DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		TransitionCollection HeaderTransitions
		{
			get;
			set;
		}
		double IncrementalLoadingThreshold
		{
			get;
			set;
		}
		IncrementalLoadingTrigger IncrementalLoadingTrigger
		{
			get;
			set;
		}
		bool IsItemClickEnabled
		{
			get;
			set;
		}
		bool IsSwipeEnabled
		{
			get;
			set;
		}
		IVector<object> SelectedItems
		{
			get;
		}
		ListViewSelectionMode SelectionMode
		{
			get;
			set;
		}
		[DefaultOverload, Overload("ScrollIntoView")]
		void ScrollIntoView([In] object item);
		void SelectAll();
		IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();
		[Overload("ScrollIntoViewWithAlignment")]
		void ScrollIntoView([In] object item, [In] ScrollIntoViewAlignment alignment);
	}
}
