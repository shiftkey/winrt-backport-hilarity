using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GradientStop)), Guid(1717519614u, 11865, 19530, 171, 83, 7, 106, 16, 12, 205, 129), Version(100794368u), WebHostHidden]
	internal interface IGradientStop
	{
		Color Color
		{
			get;
			set;
		}
		double Offset
		{
			get;
			set;
		}
	}
}
