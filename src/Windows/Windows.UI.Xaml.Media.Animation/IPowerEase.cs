using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PowerEase)), Guid(1774716281u, 61151, 16475, 134, 128, 217, 96, 104, 128, 201, 55), Version(100794368u), WebHostHidden]
	internal interface IPowerEase
	{
		double Power
		{
			get;
			set;
		}
	}
}
