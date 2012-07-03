using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(ScaleTransform)), Guid(3983012237u, 37742, 17323, 146, 154, 233, 205, 10, 81, 30, 82), Version(100794368u), WebHostHidden]
	internal interface IScaleTransform
	{
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
		double ScaleX
		{
			get;
			set;
		}
		double ScaleY
		{
			get;
			set;
		}
	}
}
