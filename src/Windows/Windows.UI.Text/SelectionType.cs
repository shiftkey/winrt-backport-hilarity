using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Version(100794368u)]
	public enum SelectionType
	{
		None,
		InsertionPoint,
		Normal,
		InlineShape = 7,
		Shape
	}
}
