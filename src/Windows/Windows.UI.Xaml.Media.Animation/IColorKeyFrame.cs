using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorKeyFrame)), Guid(3038610137u, 2320, 17801, 162, 132, 176, 201, 32, 88, 88, 233), Version(100794368u), WebHostHidden]
	internal interface IColorKeyFrame
	{
		KeyTime KeyTime
		{
			get;
			set;
		}
		Color Value
		{
			get;
			set;
		}
	}
}
