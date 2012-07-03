using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RangeBase)), Guid(1116843833u, 32523, 19394, 153, 196, 6, 231, 6, 38, 130, 216), Version(100794368u), WebHostHidden]
	internal interface IRangeBaseOverrides
	{
		void OnMinimumChanged([In] double oldMinimum, [In] double newMinimum);
		void OnMaximumChanged([In] double oldMaximum, [In] double newMaximum);
		void OnValueChanged([In] double oldValue, [In] double newValue);
	}
}
