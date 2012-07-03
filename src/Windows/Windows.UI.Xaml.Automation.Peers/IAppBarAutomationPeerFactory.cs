using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AppBarAutomationPeer)), Guid(2204169442u, 58262, 17687, 175, 93, 244, 207, 52, 197, 78, 223), Version(100794368u), WebHostHidden]
	internal interface IAppBarAutomationPeerFactory
	{
		AppBarAutomationPeer CreateInstanceWithOwner([In] AppBar owner, [In] object outer, out object inner);
	}
}
