using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(MediaElementAutomationPeer)), Guid(2997697320u, 30069, 16755, 155, 199, 128, 54, 122, 22, 78, 210), Version(100794368u), WebHostHidden]
	internal interface IMediaElementAutomationPeerFactory
	{
		MediaElementAutomationPeer CreateInstanceWithOwner([In] MediaElement owner, [In] object outer, out object inner);
	}
}
