using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(SkewTransform)), Guid(1317681941u, 31247, 17943, 158, 152, 30, 101, 189, 201, 33, 21), Version(100794368u), WebHostHidden]
	internal interface ISkewTransform
	{
		double AngleX
		{
			get;
			set;
		}
		double AngleY
		{
			get;
			set;
		}
		double CenterX
		{
			get;
			set;
		}
		double CenterY
		{
			get;
			set;
		}
	}
}
