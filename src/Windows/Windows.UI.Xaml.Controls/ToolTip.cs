using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IToolTipFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IToolTipStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ToolTip : ContentControl, IToolTip
	{
		public extern event RoutedEventHandler Closed
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler Opened
		{
			add;
			remove;
		}
		public extern double HorizontalOffset
		{
			get;
			set;
		}
		public extern bool IsOpen
		{
			get;
			set;
		}
		public extern PlacementMode Placement
		{
			get;
			set;
		}
		public extern UIElement PlacementTarget
		{
			get;
			set;
		}
		public extern ToolTipTemplateSettings TemplateSettings
		{
			get;
		}
		public extern double VerticalOffset
		{
			get;
			set;
		}
		public static extern DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty IsOpenProperty
		{
			get;
		}
		public static extern DependencyProperty PlacementProperty
		{
			get;
		}
		public static extern DependencyProperty PlacementTargetProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalOffsetProperty
		{
			get;
		}
		public extern ToolTip();
	}
}
