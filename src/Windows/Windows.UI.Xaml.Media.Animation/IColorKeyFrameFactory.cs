using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorKeyFrame)), Guid(1989925002u, 40187, 19069, 150, 196, 161, 231, 222, 111, 219, 75), Version(100794368u), WebHostHidden]
	internal interface IColorKeyFrameFactory
	{
		ColorKeyFrame CreateInstance([In] object outer, out object inner);
	}
}
