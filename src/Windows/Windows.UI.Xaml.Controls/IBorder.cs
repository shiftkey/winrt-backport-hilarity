using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Border)), Guid(2038187321u, 17853, 17971, 160, 68, 191, 176, 46, 245, 23, 15), Version(100794368u), WebHostHidden]
	internal interface IBorder
	{
		Brush Background
		{
			get;
			set;
		}
		Brush BorderBrush
		{
			get;
			set;
		}
		Thickness BorderThickness
		{
			get;
			set;
		}
		UIElement Child
		{
			get;
			set;
		}
		TransitionCollection ChildTransitions
		{
			get;
			set;
		}
		CornerRadius CornerRadius
		{
			get;
			set;
		}
		Thickness Padding
		{
			get;
			set;
		}
	}
}
