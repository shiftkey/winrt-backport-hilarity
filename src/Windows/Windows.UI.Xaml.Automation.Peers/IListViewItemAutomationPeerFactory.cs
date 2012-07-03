using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListViewItemAutomationPeer)), Guid(3296590784u, 64204, 16420, 167, 59, 23, 236, 78, 102, 38, 84), Version(100794368u), WebHostHidden]
	internal interface IListViewItemAutomationPeerFactory
	{
		ListViewItemAutomationPeer CreateInstanceWithOwner([In] ListViewItem owner, [In] object outer, out object inner);
	}
}
