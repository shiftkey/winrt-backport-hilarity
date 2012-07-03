using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FrameworkElementAutomationPeer)), Guid(230275260u, 47122, 18659, 175, 31, 219, 197, 118, 0, 195, 37), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElementAutomationPeerFactory
	{
		FrameworkElementAutomationPeer CreateInstanceWithOwner([In] FrameworkElement owner, [In] object outer, out object inner);
	}
}
