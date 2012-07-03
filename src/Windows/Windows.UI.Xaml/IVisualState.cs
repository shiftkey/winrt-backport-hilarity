using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualState)), Guid(1663086588u, 49946, 17488, 175, 222, 246, 234, 123, 209, 245, 134), Version(100794368u), WebHostHidden]
	internal interface IVisualState
	{
		string Name
		{
			get;
		}
		Storyboard Storyboard
		{
			get;
			set;
		}
	}
}
