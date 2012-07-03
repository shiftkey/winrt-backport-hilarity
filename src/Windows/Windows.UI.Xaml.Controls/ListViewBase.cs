using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IListViewBaseFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IListViewBaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListViewBase : Selector, IListViewBase, ISemanticZoomInformation
	{
		public extern event DragItemsStartingEventHandler DragItemsStarting
		{
			add;
			remove;
		}
		public extern event ItemClickEventHandler ItemClick
		{
			add;
			remove;
		}
		public extern bool CanDragItems
		{
			get;
			set;
		}
		public extern bool CanReorderItems
		{
			get;
			set;
		}
		public extern double DataFetchSize
		{
			get;
			set;
		}
		public extern object Header
		{
			get;
			set;
		}
		public extern DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		public extern TransitionCollection HeaderTransitions
		{
			get;
			set;
		}
		public extern double IncrementalLoadingThreshold
		{
			get;
			set;
		}
		public extern IncrementalLoadingTrigger IncrementalLoadingTrigger
		{
			get;
			set;
		}
		public extern bool IsItemClickEnabled
		{
			get;
			set;
		}
		public extern bool IsSwipeEnabled
		{
			get;
			set;
		}
		public extern IVector<object> SelectedItems
		{
			get;
		}
		public extern ListViewSelectionMode SelectionMode
		{
			get;
			set;
		}
		public extern bool IsActiveView
		{
			get;
			set;
		}
		public extern bool IsZoomedInView
		{
			get;
			set;
		}
		public extern SemanticZoom SemanticZoomOwner
		{
			get;
			set;
		}
		public static extern DependencyProperty CanDragItemsProperty
		{
			get;
		}
		public static extern DependencyProperty CanReorderItemsProperty
		{
			get;
		}
		public static extern DependencyProperty DataFetchSizeProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty IncrementalLoadingThresholdProperty
		{
			get;
		}
		public static extern DependencyProperty IncrementalLoadingTriggerProperty
		{
			get;
		}
		public static extern DependencyProperty IsActiveViewProperty
		{
			get;
		}
		public static extern DependencyProperty IsItemClickEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsSwipeEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsZoomedInViewProperty
		{
			get;
		}
		public static extern DependencyProperty SelectionModeProperty
		{
			get;
		}
		public static extern DependencyProperty SemanticZoomOwnerProperty
		{
			get;
		}
		protected extern ListViewBase();
		[DefaultOverload, Overload("ScrollIntoView")]
		public extern void ScrollIntoView([In] object item);
		public extern void SelectAll();
		public extern IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();
		[Overload("ScrollIntoViewWithAlignment")]
		public extern void ScrollIntoView([In] object item, [In] ScrollIntoViewAlignment alignment);
		public extern void InitializeViewChange();
		public extern void CompleteViewChange();
		public extern void MakeVisible([In] SemanticZoomLocation item);
		public extern void StartViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		public extern void StartViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		public extern void CompleteViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		public extern void CompleteViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
	}
}
