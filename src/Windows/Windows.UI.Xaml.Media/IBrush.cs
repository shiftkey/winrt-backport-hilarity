using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Brush)), Guid(2282136353u, 7686, 16940, 161, 204, 1, 105, 101, 89, 224, 33), Version(100794368u), WebHostHidden]
	internal interface IBrush
	{
		double Opacity
		{
			get;
			set;
		}
		Transform RelativeTransform
		{
			get;
			set;
		}
		Transform Transform
		{
			get;
			set;
		}
	}
}
