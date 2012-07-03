using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RichTextBlockOverflowAutomationPeer)), Guid(3177100899u, 11284, 18021, 173, 239, 242, 176, 51, 148, 123, 235), Version(100794368u), WebHostHidden]
	internal interface IRichTextBlockOverflowAutomationPeerFactory
	{
		RichTextBlockOverflowAutomationPeer CreateInstanceWithOwner([In] RichTextBlockOverflow owner, [In] object outer, out object inner);
	}
}
