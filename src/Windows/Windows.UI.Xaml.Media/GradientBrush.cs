using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IGradientBrushFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGradientBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "GradientStops")]
	public class GradientBrush : Brush, IGradientBrush
	{
		public extern ColorInterpolationMode ColorInterpolationMode
		{
			get;
			set;
		}
		public extern GradientStopCollection GradientStops
		{
			get;
			set;
		}
		public extern BrushMappingMode MappingMode
		{
			get;
			set;
		}
		public extern GradientSpreadMethod SpreadMethod
		{
			get;
			set;
		}
		public static extern DependencyProperty ColorInterpolationModeProperty
		{
			get;
		}
		public static extern DependencyProperty GradientStopsProperty
		{
			get;
		}
		public static extern DependencyProperty MappingModeProperty
		{
			get;
		}
		public static extern DependencyProperty SpreadMethodProperty
		{
			get;
		}
		protected extern GradientBrush();
	}
}
