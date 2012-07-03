using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DropTargetItemThemeAnimation)), Guid(411158888u, 6180, 17963, 135, 232, 195, 87, 33, 43, 151, 123), Version(100794368u), WebHostHidden]
	internal interface IDropTargetItemThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
