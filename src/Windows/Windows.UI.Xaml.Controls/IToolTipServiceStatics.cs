using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToolTipService)), Guid(2263239160u, 57925, 18602, 168, 200, 209, 7, 62, 215, 99, 25), Version(100794368u), WebHostHidden]
	internal interface IToolTipServiceStatics
	{
		DependencyProperty PlacementProperty
		{
			get;
		}
		DependencyProperty PlacementTargetProperty
		{
			get;
		}
		DependencyProperty ToolTipProperty
		{
			get;
		}
		PlacementMode GetPlacement([In] DependencyObject element);
		void SetPlacement([In] DependencyObject element, [In] PlacementMode value);
		UIElement GetPlacementTarget([In] DependencyObject element);
		void SetPlacementTarget([In] DependencyObject element, [In] UIElement value);
		object GetToolTip([In] DependencyObject element);
		void SetToolTip([In] DependencyObject element, [In] object value);
	}
}
