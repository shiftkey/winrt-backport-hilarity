using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IToolTipServiceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ToolTipService : IToolTipService
	{
		public static extern DependencyProperty PlacementProperty
		{
			get;
		}
		public static extern DependencyProperty PlacementTargetProperty
		{
			get;
		}
		public static extern DependencyProperty ToolTipProperty
		{
			get;
		}
		public static extern PlacementMode GetPlacement([In] DependencyObject element);
		public static extern void SetPlacement([In] DependencyObject element, [In] PlacementMode value);
		public static extern UIElement GetPlacementTarget([In] DependencyObject element);
		public static extern void SetPlacementTarget([In] DependencyObject element, [In] UIElement value);
		public static extern object GetToolTip([In] DependencyObject element);
		public static extern void SetToolTip([In] DependencyObject element, [In] object value);
	}
}
