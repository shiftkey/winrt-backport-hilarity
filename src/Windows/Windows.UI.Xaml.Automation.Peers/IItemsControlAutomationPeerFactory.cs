using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ItemsControlAutomationPeer)), Guid(1077453401u, 11802, 18890, 165, 51, 198, 79, 24, 21, 119, 230), Version(100794368u), WebHostHidden]
	internal interface IItemsControlAutomationPeerFactory
	{
		ItemsControlAutomationPeer CreateInstanceWithOwner([In] ItemsControl owner, [In] object outer, out object inner);
	}
}
