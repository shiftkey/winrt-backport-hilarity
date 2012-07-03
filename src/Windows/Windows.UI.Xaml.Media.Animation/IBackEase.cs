using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(BackEase)), Guid(3833042663u, 63493, 19087, 129, 201, 56, 230, 71, 44, 170, 148), Version(100794368u), WebHostHidden]
	internal interface IBackEase
	{
		double Amplitude
		{
			get;
			set;
		}
	}
}
