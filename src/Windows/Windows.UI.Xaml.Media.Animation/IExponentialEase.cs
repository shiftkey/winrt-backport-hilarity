using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ExponentialEase)), Guid(2092557341u, 61627, 19402, 157, 165, 155, 163, 161, 23, 52, 196), Version(100794368u), WebHostHidden]
	internal interface IExponentialEase
	{
		double Exponent
		{
			get;
			set;
		}
	}
}
