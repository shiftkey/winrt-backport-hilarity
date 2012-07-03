using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointKeyFrame)), Guid(3407956959u, 17002, 17298, 131, 85, 194, 174, 82, 133, 38, 35), Version(100794368u), WebHostHidden]
	internal interface IPointKeyFrameFactory
	{
		PointKeyFrame CreateInstance([In] object outer, out object inner);
	}
}
