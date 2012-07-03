using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ThumbAutomationPeer)), Guid(2533835775u, 44865, 17920, 181, 93, 38, 212, 61, 248, 96, 225), Version(100794368u), WebHostHidden]
	internal interface IThumbAutomationPeerFactory
	{
		ThumbAutomationPeer CreateInstanceWithOwner([In] Thumb owner, [In] object outer, out object inner);
	}
}
