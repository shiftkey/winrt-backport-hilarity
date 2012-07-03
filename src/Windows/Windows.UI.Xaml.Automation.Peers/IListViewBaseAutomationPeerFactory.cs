using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListViewBaseAutomationPeer)), Guid(1892926142u, 35152, 17991, 147, 98, 253, 0, 47, 143, 248, 46), Version(100794368u), WebHostHidden]
	internal interface IListViewBaseAutomationPeerFactory
	{
		ListViewBaseAutomationPeer CreateInstanceWithOwner([In] ListViewBase owner, [In] object outer, out object inner);
	}
}
