using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EdgeUIThemeTransition)), Guid(1552335259u, 18903, 6636, 207, 25, 131, 167, 60, 109, 231, 94), Version(100794368u), WebHostHidden]
	internal interface IEdgeUIThemeTransition
	{
		EdgeTransitionLocation Edge
		{
			get;
			set;
		}
	}
}
