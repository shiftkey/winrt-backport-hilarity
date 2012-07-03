using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(GroupItemAutomationPeer)), Guid(1453737319u, 61980, 19600, 179, 121, 21, 162, 124, 127, 132, 9), Version(100794368u), WebHostHidden]
	internal interface IGroupItemAutomationPeerFactory
	{
		GroupItemAutomationPeer CreateInstanceWithOwner([In] GroupItem owner, [In] object outer, out object inner);
	}
}
