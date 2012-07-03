using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(FrameworkElement)), Guid(3657465428u, 46018, 19354, 170, 142, 211, 240, 113, 38, 43, 151), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElementOverrides
	{
		Size MeasureOverride([In] Size availableSize);
		Size ArrangeOverride([In] Size finalSize);
		void OnApplyTemplate();
	}
}
