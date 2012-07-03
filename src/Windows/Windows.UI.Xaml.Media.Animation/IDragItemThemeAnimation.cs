using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DragItemThemeAnimation)), Guid(209542581u, 32470, 18761, 180, 230, 167, 140, 159, 79, 151, 141), Version(100794368u), WebHostHidden]
	internal interface IDragItemThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
