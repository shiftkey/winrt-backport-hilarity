using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DragOverThemeAnimation)), Guid(342883927u, 15517, 16857, 165, 255, 141, 114, 57, 81, 104, 16), Version(100794368u), WebHostHidden]
	internal interface IDragOverThemeAnimationStatics
	{
		DependencyProperty DirectionProperty
		{
			get;
		}
		DependencyProperty TargetNameProperty
		{
			get;
		}
		DependencyProperty ToOffsetProperty
		{
			get;
		}
	}
}
