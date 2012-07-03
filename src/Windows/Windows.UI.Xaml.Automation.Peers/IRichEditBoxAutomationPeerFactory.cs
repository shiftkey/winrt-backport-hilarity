using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RichEditBoxAutomationPeer)), Guid(1965851545u, 53910, 19847, 144, 32, 164, 117, 14, 136, 91, 60), Version(100794368u), WebHostHidden]
	internal interface IRichEditBoxAutomationPeerFactory
	{
		RichEditBoxAutomationPeer CreateInstanceWithOwner([In] RichEditBox owner, [In] object outer, out object inner);
	}
}
