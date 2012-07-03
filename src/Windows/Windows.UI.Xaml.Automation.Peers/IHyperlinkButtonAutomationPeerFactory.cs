using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(HyperlinkButtonAutomationPeer)), Guid(1505498721u, 49538, 18863, 149, 38, 68, 184, 142, 98, 132, 85), Version(100794368u), WebHostHidden]
	internal interface IHyperlinkButtonAutomationPeerFactory
	{
		HyperlinkButtonAutomationPeer CreateInstanceWithOwner([In] HyperlinkButton owner, [In] object outer, out object inner);
	}
}
