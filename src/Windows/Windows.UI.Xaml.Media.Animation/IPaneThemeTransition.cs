using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PaneThemeTransition)), Guid(1191766926u, 19452, 60998, 212, 249, 112, 141, 239, 63, 187, 43), Version(100794368u), WebHostHidden]
	internal interface IPaneThemeTransition
	{
		EdgeTransitionLocation Edge
		{
			get;
			set;
		}
	}
}
