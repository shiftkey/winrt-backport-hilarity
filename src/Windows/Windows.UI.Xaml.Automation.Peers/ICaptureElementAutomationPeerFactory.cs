using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(CaptureElementAutomationPeer)), Guid(2610097992u, 34281, 18537, 177, 117, 143, 124, 244, 90, 109, 159), Version(100794368u), WebHostHidden]
	internal interface ICaptureElementAutomationPeerFactory
	{
		CaptureElementAutomationPeer CreateInstanceWithOwner([In] CaptureElement owner, [In] object outer, out object inner);
	}
}
