using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Flags, Version(100794368u)]
	public enum TextGetOptions : uint
	{
		None = 0u,
		AdjustCrlf = 1u,
		UseCrlf = 2u,
		UseObjectText = 4u,
		AllowFinalEop = 8u,
		NoHidden = 32u,
		IncludeNumbering = 64u,
		FormatRtf = 8192u
	}
}
