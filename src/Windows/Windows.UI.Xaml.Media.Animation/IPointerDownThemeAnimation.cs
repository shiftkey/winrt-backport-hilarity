using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointerDownThemeAnimation)), Guid(3046011214u, 50333, 18312, 162, 51, 10, 232, 93, 153, 221, 90), Version(100794368u), WebHostHidden]
	internal interface IPointerDownThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
