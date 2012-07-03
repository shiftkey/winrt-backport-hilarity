using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapTransform)), Guid(2926924612u, 57960, 19765, 173, 207, 233, 149, 211, 26, 141, 52), Version(100794368u)]
	internal interface IBitmapTransform
	{
		BitmapBounds Bounds
		{
			get;
			set;
		}
		BitmapFlip Flip
		{
			get;
			set;
		}
		BitmapInterpolationMode InterpolationMode
		{
			get;
			set;
		}
		BitmapRotation Rotation
		{
			get;
			set;
		}
		uint ScaledHeight
		{
			get;
			set;
		}
		uint ScaledWidth
		{
			get;
			set;
		}
	}
}
