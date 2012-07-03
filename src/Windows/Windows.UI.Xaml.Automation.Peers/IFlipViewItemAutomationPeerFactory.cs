using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FlipViewItemAutomationPeer)), Guid(1762693974u, 53477, 19472, 160, 156, 173, 11, 241, 176, 203, 1), Version(100794368u), WebHostHidden]
	internal interface IFlipViewItemAutomationPeerFactory
	{
		FlipViewItemAutomationPeer CreateInstanceWithOwner([In] FlipViewItem owner, [In] object outer, out object inner);
	}
}
