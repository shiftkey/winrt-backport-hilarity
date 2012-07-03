using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Flags, Version(100794368u)]
	public enum PointOptions : uint
	{
		None = 0u,
		IncludeInset = 1u,
		Start = 32u,
		ClientCoordinates = 256u,
		AllowOffClient = 512u,
		Transform = 1024u,
		NoHorizontalScroll = 65536u,
		NoVerticalScroll = 262144u
	}
}
