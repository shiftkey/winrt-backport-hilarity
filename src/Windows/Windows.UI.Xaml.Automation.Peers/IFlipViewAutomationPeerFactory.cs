using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FlipViewAutomationPeer)), Guid(1133882125u, 36227, 18492, 136, 235, 226, 97, 123, 13, 41, 63), Version(100794368u), WebHostHidden]
	internal interface IFlipViewAutomationPeerFactory
	{
		FlipViewAutomationPeer CreateInstanceWithOwner([In] FlipView owner, [In] object outer, out object inner);
	}
}
