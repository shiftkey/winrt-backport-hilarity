using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ProgressRingAutomationPeer)), Guid(4091224139u, 5502, 16572, 149, 147, 85, 188, 92, 113, 164, 246), Version(100794368u), WebHostHidden]
	internal interface IProgressRingAutomationPeerFactory
	{
		ProgressRingAutomationPeer CreateInstanceWithOwner([In] ProgressRing owner, [In] object outer, out object inner);
	}
}
