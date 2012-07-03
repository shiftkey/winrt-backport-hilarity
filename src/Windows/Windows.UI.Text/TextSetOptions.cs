using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Flags, Version(100794368u)]
	public enum TextSetOptions : uint
	{
		None = 0u,
		UnicodeBidi = 1u,
		Unlink = 8u,
		Unhide = 16u,
		CheckTextLimit = 32u,
		FormatRtf = 8192u,
		ApplyRtfDocumentDefaults = 16384u
	}
}
