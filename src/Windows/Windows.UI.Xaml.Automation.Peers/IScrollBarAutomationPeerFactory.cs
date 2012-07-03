using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ScrollBarAutomationPeer)), Guid(3778027792u, 45035, 17813, 142, 61, 237, 192, 132, 74, 43, 33), Version(100794368u), WebHostHidden]
	internal interface IScrollBarAutomationPeerFactory
	{
		ScrollBarAutomationPeer CreateInstanceWithOwner([In] ScrollBar owner, [In] object outer, out object inner);
	}
}
