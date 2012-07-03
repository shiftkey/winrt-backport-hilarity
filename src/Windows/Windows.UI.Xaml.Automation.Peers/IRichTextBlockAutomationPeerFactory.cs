using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RichTextBlockAutomationPeer)), Guid(540585569u, 5001, 18042, 174, 214, 55, 51, 77, 169, 98, 43), Version(100794368u), WebHostHidden]
	internal interface IRichTextBlockAutomationPeerFactory
	{
		RichTextBlockAutomationPeer CreateInstanceWithOwner([In] RichTextBlock owner, [In] object outer, out object inner);
	}
}
