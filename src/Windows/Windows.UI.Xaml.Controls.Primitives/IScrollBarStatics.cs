using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ScrollBar)), Guid(1173025677u, 47124, 18639, 151, 242, 83, 158, 177, 109, 253, 77), Version(100794368u), WebHostHidden]
	internal interface IScrollBarStatics
	{
		DependencyProperty IndicatorModeProperty
		{
			get;
		}
		DependencyProperty OrientationProperty
		{
			get;
		}
		DependencyProperty ViewportSizeProperty
		{
			get;
		}
	}
}
