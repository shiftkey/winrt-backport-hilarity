using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IBrushFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Brush : DependencyObject, IBrush
	{
		public extern double Opacity
		{
			get;
			set;
		}
		public extern Transform RelativeTransform
		{
			get;
			set;
		}
		public extern Transform Transform
		{
			get;
			set;
		}
		public static extern DependencyProperty OpacityProperty
		{
			get;
		}
		public static extern DependencyProperty RelativeTransformProperty
		{
			get;
		}
		public static extern DependencyProperty TransformProperty
		{
			get;
		}
		protected extern Brush();
	}
}
