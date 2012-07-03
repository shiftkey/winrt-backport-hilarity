using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Border)), Guid(3088913977u, 59665, 20439, 164, 196, 185, 199, 240, 8, 183, 252), Version(100794368u), WebHostHidden]
	internal interface IBorderStatics
	{
		DependencyProperty BackgroundProperty
		{
			get;
		}
		DependencyProperty BorderBrushProperty
		{
			get;
		}
		DependencyProperty BorderThicknessProperty
		{
			get;
		}
		DependencyProperty ChildTransitionsProperty
		{
			get;
		}
		DependencyProperty CornerRadiusProperty
		{
			get;
		}
		DependencyProperty PaddingProperty
		{
			get;
		}
	}
}
