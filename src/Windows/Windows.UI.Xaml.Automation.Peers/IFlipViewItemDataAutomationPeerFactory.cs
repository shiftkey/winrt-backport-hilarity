using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FlipViewItemDataAutomationPeer)), Guid(1015432083u, 2794, 20088, 188, 17, 183, 117, 202, 196, 17, 76), Version(100794368u), WebHostHidden]
	internal interface IFlipViewItemDataAutomationPeerFactory
	{
		FlipViewItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] FlipViewAutomationPeer parent, [In] object outer, out object inner);
	}
}
