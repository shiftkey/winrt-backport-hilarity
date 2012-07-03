using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(ImageEncodingProperties)), Guid(2019710517u, 62257, 16777, 177, 195, 180, 141, 90, 224, 52, 241), Version(100794368u)]
	internal interface IImageEncodingProperties : IMediaEncodingProperties
	{
		uint Height
		{
			get;
			set;
		}
		uint Width
		{
			get;
			set;
		}
	}
}
