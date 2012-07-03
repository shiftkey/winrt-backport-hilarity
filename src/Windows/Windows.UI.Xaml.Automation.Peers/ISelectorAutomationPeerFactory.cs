using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(SelectorAutomationPeer)), Guid(2068993606u, 33435, 19916, 189, 82, 90, 141, 3, 153, 56, 122), Version(100794368u), WebHostHidden]
	internal interface ISelectorAutomationPeerFactory
	{
		SelectorAutomationPeer CreateInstanceWithOwner([In] Selector owner, [In] object outer, out object inner);
	}
}
