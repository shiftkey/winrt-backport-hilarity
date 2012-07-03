using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Compression
{
	[Version(100794368u)]
	public enum CompressAlgorithm
	{
		InvalidAlgorithm,
		NullAlgorithm,
		Mszip,
		Xpress,
		XpressHuff,
		Lzms
	}
}
