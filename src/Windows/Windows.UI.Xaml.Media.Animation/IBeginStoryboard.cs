using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(BeginStoryboard)), Guid(1679335373u, 18924, 20050, 166, 246, 85, 50, 76, 146, 16, 83), Version(100794368u), WebHostHidden]
	internal interface IBeginStoryboard
	{
		Storyboard Storyboard
		{
			get;
			set;
		}
	}
}
