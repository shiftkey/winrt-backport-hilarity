using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Slider)), Guid(2304188455u, 19528, 18176, 128, 118, 73, 123, 167, 61, 156, 24), Version(100794368u), WebHostHidden]
	internal interface ISlider
	{
		double IntermediateValue
		{
			get;
			set;
		}
		bool IsDirectionReversed
		{
			get;
			set;
		}
		bool IsThumbToolTipEnabled
		{
			get;
			set;
		}
		Orientation Orientation
		{
			get;
			set;
		}
		SliderSnapsTo SnapsTo
		{
			get;
			set;
		}
		double StepFrequency
		{
			get;
			set;
		}
		IValueConverter ThumbToolTipValueConverter
		{
			get;
			set;
		}
		double TickFrequency
		{
			get;
			set;
		}
		TickPlacement TickPlacement
		{
			get;
			set;
		}
	}
}
