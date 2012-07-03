using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointKeyFrame)), Guid(4241001729u, 32642, 19886, 128, 38, 123, 126, 8, 104, 120, 179), Version(100794368u), WebHostHidden]
	internal interface IPointKeyFrame
	{
		KeyTime KeyTime
		{
			get;
			set;
		}
		Point Value
		{
			get;
			set;
		}
	}
}
