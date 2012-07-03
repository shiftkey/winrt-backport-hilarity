using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(BounceEase)), Guid(737232462u, 64625, 18413, 133, 161, 59, 169, 87, 119, 24, 180), Version(100794368u), WebHostHidden]
	internal interface IBounceEase
	{
		int Bounces
		{
			get;
			set;
		}
		double Bounciness
		{
			get;
			set;
		}
	}
}
