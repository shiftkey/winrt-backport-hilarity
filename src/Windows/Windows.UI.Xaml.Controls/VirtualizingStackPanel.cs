using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IVirtualizingStackPanelStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class VirtualizingStackPanel : OrientedVirtualizingPanel, IVirtualizingStackPanel, IVirtualizingStackPanelOverrides
	{
		public extern event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent
		{
			add;
			remove;
		}
		public extern bool AreScrollSnapPointsRegular
		{
			get;
			set;
		}
		public extern Orientation Orientation
		{
			get;
			set;
		}
		public static extern DependencyProperty AreScrollSnapPointsRegularProperty
		{
			get;
		}
		public static extern DependencyProperty IsVirtualizingProperty
		{
			get;
		}
		public static extern DependencyProperty OrientationProperty
		{
			get;
		}
		public static extern DependencyProperty VirtualizationModeProperty
		{
			get;
		}
		public extern VirtualizingStackPanel();
		protected virtual extern void OnCleanUpVirtualizedItem([In] CleanUpVirtualizedItemEventArgs e);
		public static extern VirtualizationMode GetVirtualizationMode([In] DependencyObject element);
		public static extern void SetVirtualizationMode([In] DependencyObject element, [In] VirtualizationMode value);
		public static extern bool GetIsVirtualizing([In] DependencyObject o);
	}
}
