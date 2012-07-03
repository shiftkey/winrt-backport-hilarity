using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(RepositionThemeAnimation)), Guid(1301459377u, 34315, 19449, 165, 157, 30, 177, 204, 190, 143, 224), Version(100794368u), WebHostHidden]
	internal interface IRepositionThemeAnimationStatics
	{
		DependencyProperty FromHorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty FromVerticalOffsetProperty
		{
			get;
		}
		DependencyProperty TargetNameProperty
		{
			get;
		}
	}
}
