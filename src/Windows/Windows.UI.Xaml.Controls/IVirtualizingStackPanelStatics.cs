using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingStackPanel)), Guid(2199185272u, 37331, 19798, 172, 9, 34, 58, 220, 210, 189, 63), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingStackPanelStatics
	{
		DependencyProperty AreScrollSnapPointsRegularProperty
		{
			get;
		}
		DependencyProperty IsVirtualizingProperty
		{
			get;
		}
		DependencyProperty OrientationProperty
		{
			get;
		}
		DependencyProperty VirtualizationModeProperty
		{
			get;
		}
		VirtualizationMode GetVirtualizationMode([In] DependencyObject element);
		void SetVirtualizationMode([In] DependencyObject element, [In] VirtualizationMode value);
		bool GetIsVirtualizing([In] DependencyObject o);
	}
}
