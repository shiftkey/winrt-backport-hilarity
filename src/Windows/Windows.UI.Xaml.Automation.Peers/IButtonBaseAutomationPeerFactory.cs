using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ButtonBaseAutomationPeer)), Guid(2315520286u, 59058, 19552, 167, 89, 193, 60, 164, 81, 101, 237), Version(100794368u), WebHostHidden]
	internal interface IButtonBaseAutomationPeerFactory
	{
		ButtonBaseAutomationPeer CreateInstanceWithOwner([In] ButtonBase owner, [In] object outer, out object inner);
	}
}
