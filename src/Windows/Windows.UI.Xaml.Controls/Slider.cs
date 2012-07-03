using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(ISliderFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISliderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Slider : RangeBase, ISlider
	{
		public extern double IntermediateValue
		{
			get;
			set;
		}
		public extern bool IsDirectionReversed
		{
			get;
			set;
		}
		public extern bool IsThumbToolTipEnabled
		{
			get;
			set;
		}
		public extern Orientation Orientation
		{
			get;
			set;
		}
		public extern SliderSnapsTo SnapsTo
		{
			get;
			set;
		}
		public extern double StepFrequency
		{
			get;
			set;
		}
		public extern IValueConverter ThumbToolTipValueConverter
		{
			get;
			set;
		}
		public extern double TickFrequency
		{
			get;
			set;
		}
		public extern TickPlacement TickPlacement
		{
			get;
			set;
		}
		public static extern DependencyProperty IntermediateValueProperty
		{
			get;
		}
		public static extern DependencyProperty IsDirectionReversedProperty
		{
			get;
		}
		public static extern DependencyProperty IsThumbToolTipEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty OrientationProperty
		{
			get;
		}
		public static extern DependencyProperty SnapsToProperty
		{
			get;
		}
		public static extern DependencyProperty StepFrequencyProperty
		{
			get;
		}
		public static extern DependencyProperty ThumbToolTipValueConverterProperty
		{
			get;
		}
		public static extern DependencyProperty TickFrequencyProperty
		{
			get;
		}
		public static extern DependencyProperty TickPlacementProperty
		{
			get;
		}
		public extern Slider();
	}
}
