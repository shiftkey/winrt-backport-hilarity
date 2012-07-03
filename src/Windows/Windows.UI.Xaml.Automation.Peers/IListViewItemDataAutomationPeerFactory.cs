using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListViewItemDataAutomationPeer)), Guid(3504018107u, 55061, 17699, 172, 192, 30, 16, 114, 216, 227, 43), Version(100794368u), WebHostHidden]
	internal interface IListViewItemDataAutomationPeerFactory
	{
		ListViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ListViewBaseAutomationPeer parent, [In] object outer, out object inner);
	}
}
