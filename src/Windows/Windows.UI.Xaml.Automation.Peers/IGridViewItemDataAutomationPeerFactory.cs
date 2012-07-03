using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(GridViewItemDataAutomationPeer)), Guid(2791209608u, 30477, 16428, 153, 111, 103, 80, 106, 242, 164, 175), Version(100794368u), WebHostHidden]
	internal interface IGridViewItemDataAutomationPeerFactory
	{
		GridViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] GridViewAutomationPeer parent, [In] object outer, out object inner);
	}
}
