using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(TextBlockAutomationPeer)), Guid(1992266315u, 31904, 19201, 188, 92, 168, 207, 77, 54, 145, 222), Version(100794368u), WebHostHidden]
	internal interface ITextBlockAutomationPeerFactory
	{
		TextBlockAutomationPeer CreateInstanceWithOwner([In] TextBlock owner, [In] object outer, out object inner);
	}
}
