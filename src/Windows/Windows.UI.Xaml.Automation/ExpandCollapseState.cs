using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[Version(100794368u), WebHostHidden]
	public enum ExpandCollapseState
	{
		Collapsed,
		Expanded,
		PartiallyExpanded,
		LeafNode
	}
}
