using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Slider)), Guid(2319672279u, 32735, 19760, 152, 254, 206, 120, 192, 91, 49, 207), Version(100794368u), WebHostHidden]
	internal interface ISliderStatics
	{
		DependencyProperty IntermediateValueProperty
		{
			get;
		}
		DependencyProperty IsDirectionReversedProperty
		{
			get;
		}
		DependencyProperty IsThumbToolTipEnabledProperty
		{
			get;
		}
		DependencyProperty OrientationProperty
		{
			get;
		}
		DependencyProperty SnapsToProperty
		{
			get;
		}
		DependencyProperty StepFrequencyProperty
		{
			get;
		}
		DependencyProperty ThumbToolTipValueConverterProperty
		{
			get;
		}
		DependencyProperty TickFrequencyProperty
		{
			get;
		}
		DependencyProperty TickPlacementProperty
		{
			get;
		}
	}
}
