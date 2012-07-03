using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Shape)), Guid(2020551541u, 39584, 17741, 174, 6, 162, 70, 110, 55, 200, 50), Version(100794368u), WebHostHidden]
	internal interface IShape
	{
		Brush Fill
		{
			get;
			set;
		}
		Transform GeometryTransform
		{
			get;
		}
		Stretch Stretch
		{
			get;
			set;
		}
		Brush Stroke
		{
			get;
			set;
		}
		DoubleCollection StrokeDashArray
		{
			get;
			set;
		}
		PenLineCap StrokeDashCap
		{
			get;
			set;
		}
		double StrokeDashOffset
		{
			get;
			set;
		}
		PenLineCap StrokeEndLineCap
		{
			get;
			set;
		}
		PenLineJoin StrokeLineJoin
		{
			get;
			set;
		}
		double StrokeMiterLimit
		{
			get;
			set;
		}
		PenLineCap StrokeStartLineCap
		{
			get;
			set;
		}
		double StrokeThickness
		{
			get;
			set;
		}
	}
}
