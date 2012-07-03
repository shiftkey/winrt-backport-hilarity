using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ToggleSwitchAutomationPeer)), Guid(838415331u, 65272, 17433, 157, 245, 217, 239, 113, 150, 234, 52), Version(100794368u), WebHostHidden]
	internal interface IToggleSwitchAutomationPeerFactory
	{
		ToggleSwitchAutomationPeer CreateInstanceWithOwner([In] ToggleSwitch owner, [In] object outer, out object inner);
	}
}
