using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public enum PhotoOrientation
	{
		Unspecified,
		Normal,
		FlipHorizontal,
		Rotate180,
		FlipVertical,
		Transpose,
		Rotate270,
		Transverse,
		Rotate90
	}
}
