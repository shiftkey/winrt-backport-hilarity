using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ToggleButtonAutomationPeer)), Guid(3374419140u, 44363, 19715, 166, 164, 125, 89, 230, 54, 0, 4), Version(100794368u), WebHostHidden]
	internal interface IToggleButtonAutomationPeerFactory
	{
		ToggleButtonAutomationPeer CreateInstanceWithOwner([In] ToggleButton owner, [In] object outer, out object inner);
	}
}
