using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DragOverThemeAnimation)), Guid(1928815351u, 32337, 19051, 185, 55, 220, 75, 76, 28, 84, 88), Version(100794368u), WebHostHidden]
	internal interface IDragOverThemeAnimation
	{
		AnimationDirection Direction
		{
			get;
			set;
		}
		string TargetName
		{
			get;
			set;
		}
		double ToOffset
		{
			get;
			set;
		}
	}
}
