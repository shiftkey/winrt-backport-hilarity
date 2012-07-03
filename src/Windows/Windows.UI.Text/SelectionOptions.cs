using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Flags, Version(100794368u)]
	public enum SelectionOptions : uint
	{
		StartActive = 1u,
		AtEndOfLine = 2u,
		Overtype = 4u,
		Active = 8u,
		Replace = 16u
	}
}
