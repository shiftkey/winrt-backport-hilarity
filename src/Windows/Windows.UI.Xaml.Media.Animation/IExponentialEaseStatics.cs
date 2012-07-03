using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ExponentialEase)), Guid(4085180387u, 42849, 17234, 154, 214, 112, 121, 69, 103, 88, 26), Version(100794368u), WebHostHidden]
	internal interface IExponentialEaseStatics
	{
		DependencyProperty ExponentProperty
		{
			get;
		}
	}
}
