using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Version(100794368u)]
	public enum PngFilterMode
	{
		Automatic,
		None,
		Sub,
		Up,
		Average,
		Paeth,
		Adaptive
	}
}
