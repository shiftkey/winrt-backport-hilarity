using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointerUpThemeAnimation)), Guid(3924414589u, 25408, 18472, 173, 18, 105, 6, 148, 185, 145, 11), Version(100794368u), WebHostHidden]
	internal interface IPointerUpThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
