using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[Composable(typeof(IShapeFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IShapeStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Shape : FrameworkElement, IShape
	{
		public extern Brush Fill
		{
			get;
			set;
		}
		public extern Transform GeometryTransform
		{
			get;
		}
		public extern Stretch Stretch
		{
			get;
			set;
		}
		public extern Brush Stroke
		{
			get;
			set;
		}
		public extern DoubleCollection StrokeDashArray
		{
			get;
			set;
		}
		public extern PenLineCap StrokeDashCap
		{
			get;
			set;
		}
		public extern double StrokeDashOffset
		{
			get;
			set;
		}
		public extern PenLineCap StrokeEndLineCap
		{
			get;
			set;
		}
		public extern PenLineJoin StrokeLineJoin
		{
			get;
			set;
		}
		public extern double StrokeMiterLimit
		{
			get;
			set;
		}
		public extern PenLineCap StrokeStartLineCap
		{
			get;
			set;
		}
		public extern double StrokeThickness
		{
			get;
			set;
		}
		public static extern DependencyProperty FillProperty
		{
			get;
		}
		public static extern DependencyProperty StretchProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeDashArrayProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeDashCapProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeDashOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeEndLineCapProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeLineJoinProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeMiterLimitProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeStartLineCapProperty
		{
			get;
		}
		public static extern DependencyProperty StrokeThicknessProperty
		{
			get;
		}
		protected extern Shape();
	}
}
