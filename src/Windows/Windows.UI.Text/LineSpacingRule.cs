using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Version(100794368u)]
	public enum LineSpacingRule
	{
		Undefined,
		Single,
		OneAndHalf,
		Double,
		AtLeast,
		Exactly,
		Multiple,
		Percent
	}
}
