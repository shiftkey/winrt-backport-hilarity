using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Flags, Version(100794368u)]
	public enum FindOptions : uint
	{
		None = 0u,
		Word = 2u,
		Case = 4u
	}
}
