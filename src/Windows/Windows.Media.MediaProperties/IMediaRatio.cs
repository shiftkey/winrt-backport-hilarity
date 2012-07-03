using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(MediaRatio)), Guid(3536912101u, 35113, 16413, 172, 120, 125, 53, 126, 55, 129, 99), Version(100794368u)]
	internal interface IMediaRatio
	{
		uint Denominator
		{
			get;
			set;
		}
		uint Numerator
		{
			get;
			set;
		}
	}
}
