using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RangeBaseAutomationPeer)), Guid(2189194753u, 12408, 17529, 149, 234, 145, 55, 76, 160, 98, 7), Version(100794368u), WebHostHidden]
	internal interface IRangeBaseAutomationPeerFactory
	{
		RangeBaseAutomationPeer CreateInstanceWithOwner([In] RangeBase owner, [In] object outer, out object inner);
	}
}
