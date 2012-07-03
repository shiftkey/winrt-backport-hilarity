using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListViewAutomationPeer)), Guid(1710461300u, 60066, 20036, 139, 230, 76, 202, 40, 205, 2, 136), Version(100794368u), WebHostHidden]
	internal interface IListViewAutomationPeerFactory
	{
		ListViewAutomationPeer CreateInstanceWithOwner([In] ListView owner, [In] object outer, out object inner);
	}
}
