using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ImageAutomationPeer)), Guid(2419081219u, 26749, 18367, 179, 162, 75, 171, 202, 216, 239, 80), Version(100794368u), WebHostHidden]
	internal interface IImageAutomationPeerFactory
	{
		ImageAutomationPeer CreateInstanceWithOwner([In] Image owner, [In] object outer, out object inner);
	}
}
