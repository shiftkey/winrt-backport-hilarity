using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToolTip)), Guid(2112214879u, 17429, 17055, 181, 35, 105, 155, 219, 140, 48, 219), Version(100794368u), WebHostHidden]
	internal interface IToolTip
	{
		event RoutedEventHandler Closed;
		event RoutedEventHandler Opened;
		double HorizontalOffset
		{
			get;
			set;
		}
		bool IsOpen
		{
			get;
			set;
		}
		PlacementMode Placement
		{
			get;
			set;
		}
		UIElement PlacementTarget
		{
			get;
			set;
		}
		ToolTipTemplateSettings TemplateSettings
		{
			get;
		}
		double VerticalOffset
		{
			get;
			set;
		}
	}
}
