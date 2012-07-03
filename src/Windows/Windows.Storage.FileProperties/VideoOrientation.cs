using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public enum VideoOrientation
	{
		Normal,
		Rotate90 = 90,
		Rotate180 = 180,
		Rotate270 = 270
	}
}
