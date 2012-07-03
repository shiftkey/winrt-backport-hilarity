using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Shape)), Guid(494619733u, 40435, 18652, 145, 148, 157, 48, 111, 170, 96, 137), Version(100794368u), WebHostHidden]
	internal interface IShapeStatics
	{
		DependencyProperty FillProperty
		{
			get;
		}
		DependencyProperty StretchProperty
		{
			get;
		}
		DependencyProperty StrokeDashArrayProperty
		{
			get;
		}
		DependencyProperty StrokeDashCapProperty
		{
			get;
		}
		DependencyProperty StrokeDashOffsetProperty
		{
			get;
		}
		DependencyProperty StrokeEndLineCapProperty
		{
			get;
		}
		DependencyProperty StrokeLineJoinProperty
		{
			get;
		}
		DependencyProperty StrokeMiterLimitProperty
		{
			get;
		}
		DependencyProperty StrokeProperty
		{
			get;
		}
		DependencyProperty StrokeStartLineCapProperty
		{
			get;
		}
		DependencyProperty StrokeThicknessProperty
		{
			get;
		}
	}
}
