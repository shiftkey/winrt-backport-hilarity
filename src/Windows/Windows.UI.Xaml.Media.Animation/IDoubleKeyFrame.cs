using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleKeyFrame)), Guid(1732531965u, 59422, 20302, 180, 173, 10, 207, 237, 158, 205, 104), Version(100794368u), WebHostHidden]
	internal interface IDoubleKeyFrame
	{
		KeyTime KeyTime
		{
			get;
			set;
		}
		double Value
		{
			get;
			set;
		}
	}
}
