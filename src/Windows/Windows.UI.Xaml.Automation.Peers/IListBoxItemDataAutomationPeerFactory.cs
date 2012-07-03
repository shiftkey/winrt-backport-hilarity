using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListBoxItemDataAutomationPeer)), Guid(3616689686u, 48525, 18018, 169, 149, 32, 255, 154, 5, 96, 147), Version(100794368u), WebHostHidden]
	internal interface IListBoxItemDataAutomationPeerFactory
	{
		ListBoxItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ListBoxAutomationPeer parent, [In] object outer, out object inner);
	}
}
